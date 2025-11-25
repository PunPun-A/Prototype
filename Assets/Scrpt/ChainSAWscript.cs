using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChainSAWscript : MonoBehaviour
{
    public int damage = 100;
    
    void OnTriggerEnter2D(Collider2D HitInfo)
    {
        HitInfo.gameObject.CompareTag("Enemy");
        Enemy enemy = HitInfo.GetComponent<Enemy>();
        if (enemy != null)
        {
            enemy.TakeDamage(damage);
        }
       
    }
}
