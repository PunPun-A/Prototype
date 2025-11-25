using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float Speed = 20f;
    public Rigidbody2D Rb;
    public int damage = 40;
    public GameObject boomEffect;
   
    void Start()
    {

            Rb.velocity = transform.right * Speed;
     
    }

    void OnTriggerEnter2D(Collider2D HitInfo)
    {
        HitInfo.gameObject.CompareTag("Enemy");
        Enemy enemy = HitInfo.GetComponent<Enemy>();
        if (enemy != null)
        {
            enemy.TakeDamage(damage);
        }
        Instantiate(boomEffect, transform.position, transform.rotation);
        Destroy(gameObject);
    }
    
}
