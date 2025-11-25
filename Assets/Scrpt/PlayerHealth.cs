using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    public static PlayerHealth instance;

    public GameObject Player;
    public int Health;
    public int MaxHealth;
    public GameObject Menu;

    public HealthbarScript healthbar;

    void Awake()
    {
        instance = this;
    }
    void Start()
    {
        MaxHealth = Health;
        healthbar.SetMaxHealth(MaxHealth);
    }

    void Update()
    {
        if(Health <= 0)
        {
            
            Destroy(gameObject);
            Menu.SetActive(true);

        }
    }
}
