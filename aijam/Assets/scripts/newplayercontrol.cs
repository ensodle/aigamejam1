using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using UnityEngine;

public class newplayercontrol : MonoBehaviour
{
    public float playerspeed, jumpspeed;
    public Rigidbody2D rb ;
    public Transform floorcheckpoint;
    public LayerMask Layername;
    bool isGround;
    public Animator anim;
    public float velocityY ;


    void Update()
    {
         if(Input.GetKeyDown(KeyCode.Space)&& isGround==true)
        {
            rb.velocity = new Vector2(rb.velocity.x, jumpspeed);
            

            
        }
    }

   
    void FixedUpdate()
    {
        isGround = Physics2D.OverlapCircle(floorcheckpoint.position, 0.2f, Layername);


        float moveX = Input.GetAxis("Horizontal");
        rb.velocity=new Vector3(moveX*playerspeed,rb.velocity.y,0);
        anim.SetFloat("speed", Mathf.Abs(rb.velocity.x));
        velocityY = rb.velocity.y;
        

        if (velocityY > 0)
        {
            anim.SetBool("isjumping", true);
        }
        else if (velocityY < 0)
        {
            anim.SetBool("isfalling", true);
        }/*
        else if (velocityY == 0)
        {
            anim.SetBool("isfalling", false);
            anim.SetBool("isjumping", false);
        }*/
        if (isGround == true)
        {
            anim.SetBool("isfalling", false);
            anim.SetBool("isjumping", false);
        }


        if (rb.velocity.x > 0) 
        {
            transform.localScale = new Vector3(4f, 4f, 1f);
        }
        if (rb.velocity.x < 0)
        {
            transform.localScale = new Vector3(-4f, 4f, 1f);
        }
    }
}
