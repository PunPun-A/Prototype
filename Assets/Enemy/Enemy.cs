using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public int Health = 100;

    public GameObject deathEffect;
    public int heal;
  
    public void TakeDamage (int damage)
    {
        
        Health -= damage;

        if (Health <= 0) 
        {
            ScoreManager.instance.AddPoint();
            PlayerHealth.instance.Health += heal;
            PlayerHealth.instance.healthbar.SetHealth(PlayerHealth.instance.Health);
            Die();
        }

        
    }

    void Die()
    {
        Instantiate(deathEffect, transform.position, Quaternion.identity);
        Destroy(gameObject);
    }

    
}
