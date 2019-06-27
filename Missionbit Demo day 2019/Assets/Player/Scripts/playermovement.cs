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
    //bool crouch = false;
    void Start()
    {
        anim = GetComponent<Animator>();
    }

    void Update()
    {
        horizantialMove = Input.GetAxisRaw("Horizontal") * runspeed;
        if ((Input.GetKeyDown("w") || Input.GetKeyDown("up")))
        {
            jump = true;
        }
        //if(Input.GetKeyDown("s")){
        //    crouch = true;
        //}
        //if(Input.GetKeyUp("s"))
        //{
        //    crouch = false;
        //}
        if(Input.GetAxis("Horizontal") > 0  || Input.GetAxis("Horizontal")<0){
            anim.SetBool("IsRun", true);
        }
        else{
            anim.SetBool("IsRun", false);

        }

        //if (Input.GetKeyDown("a") || Input.GetKeyDown("s") || Input.GetKeyDown("left")|| Input.GetKeyDown("right"))
        //{
        //    anim.SetBool("IsRun", true);
        //}

        //else{
        //    anim.SetBool("IsRun", false);

        //}




    }
    void FixedUpdate()
    {
        controller.Move(horizantialMove * Time.fixedDeltaTime, false, jump);
        jump = false;
    }
}
