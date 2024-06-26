using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playercontrol : MonoBehaviour
{
    Rigidbody2D rgb;
    Vector3 velocity;

    float speedAmount = 5.0f;
    float jumpAmount = 5f;


    void Start()
    {
        rgb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        velocity = new Vector3(Input.GetAxis("Horizontal"), 0f);
        transform.position += velocity * speedAmount *Time.deltaTime ;
        if ( Input.GetButtonDown("Jump") && Mathf.Approximately(rgb.velocity.y,0)) 
        {
            rgb.AddForce(Vector3.up * jumpAmount, ForceMode2D.Impulse);
            
        }

        if (Input.GetAxisRaw("Horizontal")==-1)
        {
            transform.rotation= Quaternion.Euler(0f,180f,0f);
        }

        else if (Input.GetAxisRaw("Horizontal") == 1)
        {
            transform.rotation = Quaternion.Euler(0f, 0f, 0f);
        }


    }
}
