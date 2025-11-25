using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Pathfinding;

public class EnemyAI : MonoBehaviour
{
    
    private Transform target;
    public float speed = 200f;
    public float nextWaypointDistance = 3f;
    public float Boostspeed = 400f;
    public float speedreturn = 200f;

    Path path;
    int currentWaypoint = 0;
    bool reachedOfpath = false;
    public Transform EnemyGFX;

    Seeker seeker;
    Rigidbody2D rb;
    
    private void Awake()
    {
        target = FindObjectOfType<PlayerMovement>().transform;
    }
    
    public void Start()
    {
        seeker = GetComponent<Seeker>();
        rb = GetComponent<Rigidbody2D>();
        
        

        InvokeRepeating("Updatepath", 0f, .5f);
        
    }

    void Updatepath()
    {
        if (seeker.IsDone())
        seeker.StartPath(rb.position, target.position, OnPathComplete);
        
            
    }

  

    void OnPathComplete(Path p)
    {
        if (!p.error)
        {
            path = p;
            currentWaypoint = 0;
        }
    }

    void FixedUpdate()
    {
        
        
            if (path == null)
            {
                return;
            }
            if (currentWaypoint >= path.vectorPath.Count)
            {
                reachedOfpath = true;
                return;
            }
            else
            {
                reachedOfpath = false;
            }

            Vector2 direction = ((Vector2)path.vectorPath[currentWaypoint] - rb.position).normalized;
            Vector2 force = direction * speed * Time.deltaTime;

            rb.AddForce(force);

            float distance = Vector2.Distance(rb.position, path.vectorPath[currentWaypoint]);

            if (distance < nextWaypointDistance)
            {
                currentWaypoint++;
            }

            if (rb.velocity.x >= 0.01f)
            {
                EnemyGFX.localScale = new Vector3(1f, 1f, 1f);
            }
            else if (rb.velocity.x <= -0.01f)
            {
                EnemyGFX.localScale = new Vector3(-1f, 1f, 1f);
            }
        
       
    }
}
