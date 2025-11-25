using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOntouch : MonoBehaviour
{
    public GameObject player;
    public int damage = 10;
    public Transform respawnPoint;
    

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            other.gameObject.GetComponent<PlayerMovement>().Damage();
            other.gameObject.GetComponent<PlayerHealth>().Health -= damage;
            player.transform.position = respawnPoint.position;
        }
           
    }
}
