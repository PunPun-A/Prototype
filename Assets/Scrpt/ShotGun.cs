using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class ShotGun : MonoBehaviour
{
    public Transform Firepoint1;
    public Transform Firepoint2;
    public GameObject BulletPrefab;
    public Playerinput PlayerControls;
    private InputAction fire;
    // Update is called once per frame
    void Awake()
    {
        PlayerControls = new Playerinput();
    }
   
    private void OnEnable()
    {
      

        fire = PlayerControls.Player.Fire;
        fire.Enable();
        fire.performed += Fire;
    }

    private void OnDisable()
    {
    
        fire.Disable();
    }
    private void Fire(InputAction.CallbackContext context)
    {
        Shoot();
    }
    void Shoot()
    {
        Instantiate(BulletPrefab, Firepoint1.position, Firepoint1.rotation);
        Instantiate(BulletPrefab, Firepoint2.position, Firepoint2.rotation);
    }
    
}
