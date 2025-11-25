using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DealDamge : MonoBehaviour
{
    public int damage;
    public Animator animator;

    public void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            other.gameObject.GetComponent<PlayerMovement>().Damage();
            other.gameObject.GetComponent<PlayerHealth>().Health -= damage;
            other.gameObject.GetComponent<PlayerHealth>().healthbar.SetHealth(other.gameObject.GetComponent<PlayerHealth>().Health);
        }
        
    }
}
