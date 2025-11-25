using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine.InputSystem;

public class PlayerMovement : MonoBehaviour
{
    public Playerinput PlayerControls;
    public PlayerHealth playerHealth;
    public int heal;
    private InputAction move;
    private InputAction fire;
    private InputAction jump;
    private InputAction sprint;
    private InputAction ragehealing;
    private InputAction chainsaw;
    public GameObject _col;
    float horizontalInput;
    float moveSpeed = 5f;
    bool isFacingRight = false;
    public float jumpPower = 5f;
    bool isGrounded = false;
    public float initialSpeed = 5f;
    public float runMultiplier;
    bool DoubleJump;
    public float chainsawCoolDown;
    public float chainsawAbilityTimer;
    public float HealCoolDown;
    public float HealAbilityTimer;



    public float Attackrate = 2f;
    public float nextAttacktime = 0f;

    public Rigidbody2D rb;
    public Animator animator;
    // Start is called before the first frame update
    void Start()
    {

        rb = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
    }

    void Awake()
    {
        PlayerControls = new Playerinput();
    }
    // Update is called once per frame
    void Update()
    {
        

        horizontalInput = move.ReadValue<float>();

        FlipSprite();

        chainsawAbilityTimer -= Time.deltaTime;
        HealAbilityTimer -= Time.deltaTime;



    }
    private void OnEnable()
    {
        move = PlayerControls.Player.Move;
        move.Enable();
        jump = PlayerControls.Player.Jump;
        jump.Enable();
        jump.performed += Jumped;
        fire = PlayerControls.Player.Fire;
        fire.Enable();
        fire.performed += Fire;
        sprint = PlayerControls.Player.Sprint;
        sprint.Enable();
        sprint.performed += Sprint;
        ragehealing = PlayerControls.Player.Rage;
        ragehealing.Enable();
        ragehealing.performed += RageHealing;
        chainsaw = PlayerControls.Player.Chainsaw;
        chainsaw.Enable();
        chainsaw.performed += Chainsawed;


    }

    private void OnDisable()
    {
        move.Disable();
        fire.Disable();
        sprint.Disable();
        ragehealing.Disable();
        chainsaw.Disable();
    }

    private void Jumped(InputAction.CallbackContext context)
    {
        if (context.performed && isGrounded)
        {
            rb.velocity = new Vector2(rb.velocity.x, jumpPower);
            isGrounded = false;
            animator.SetBool("isJumping", !isGrounded);
            DoubleJump = true;

        }
        else if (context.performed && DoubleJump)
        {
            rb.velocity = new Vector2(rb.velocity.x, jumpPower);
            DoubleJump = false;

        };
    }
    void attack()
    {
        animator.SetTrigger("punching");


    }

    public void Chainsawing()
    {
        if (chainsawAbilityTimer > 0)
            return;

        chainsawAbilityTimer = chainsawCoolDown;
        animator.SetTrigger("chainsawing");

    }
   
    void RageMode()
    {

        animator.SetTrigger("RageMode");
    }


    private void FixedUpdate()
    {
        rb.velocity = new Vector2(horizontalInput * moveSpeed, rb.velocity.y);
        animator.SetFloat("xVelocity", Math.Abs(rb.velocity.x));
        animator.SetFloat("yVelocity", rb.velocity.y);
    }

    void FlipSprite()
    {
        if (isFacingRight && horizontalInput > 0f || !isFacingRight && horizontalInput < 0f)
        {
            isFacingRight = !isFacingRight;
            transform.Rotate(0f, 180f, 0f);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        isGrounded = true;
        animator.SetBool("isJumping", !isGrounded);
    }
    private void Fire(InputAction.CallbackContext context)
    {
        animator.SetTrigger("punching");
        if (Time.time >= nextAttacktime && !Input.GetKey(KeyCode.LeftShift))
        {
            if (context.performed)
            {
                attack();
                nextAttacktime = Time.time + 1f / Attackrate;
            }
        }
    }

    private void Sprint(InputAction.CallbackContext context)
    {
        if (context.performed)
        {
            moveSpeed = context.performed ? initialSpeed * runMultiplier : initialSpeed;
        }
        else if (context.canceled)
        {
            moveSpeed = initialSpeed;
        }
    }

    public void Damage()
    {
        animator.SetTrigger("Damage");
    }

    public void RageHealing(InputAction.CallbackContext context)
    {
        if (chainsawAbilityTimer > 0)
            return;

        chainsawAbilityTimer = chainsawCoolDown;
        if (context.performed && isGrounded)
        {
            playerHealth.Health += heal;
            playerHealth.healthbar.SetHealth(playerHealth.Health);

        }
        RageMode();

    }
    public void Chainsawed(InputAction.CallbackContext context)
    {
      
        
        Chainsawing();
       
      
    }

         

}
