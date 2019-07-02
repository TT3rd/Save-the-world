using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playermovement : MonoBehaviour
{
    public CharacterController2D controller;
    float horizantialMove = 0f;
    public float runspeed = 40f;
    bool jump = false;
    Animator anim;
    bool inair = false;
    public bool isGrounded;
    //bool crouch = false;
    void Start()
    {
        anim = GetComponent<Animator>();
    }

    void Update()
    {

        horizantialMove = Input.GetAxisRaw("Horizontal") * runspeed;
        if (isGrounded = true && Input.GetButtonDown("Jump") || Input.GetKeyDown("up") )
        {
            jump = true;
            anim.Play("Jump");

        }




        if (Input.GetAxis("Horizontal") > 0 || Input.GetAxis("Horizontal") < 0)
        {
            anim.SetBool("IsRun", true);
        }
        else
        {
            anim.SetBool("IsRun", false);

        }

    }
   
    void FixedUpdate()
    {
        controller.Move(horizantialMove * Time.fixedDeltaTime, false, jump);
        jump = false;
    }
}
