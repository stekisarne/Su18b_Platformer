using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyHorizontalMovement : MonoBehaviour
{
    public float speed = 2f;
    public bool left = true;

    private Rigidbody2D rbody;

    void Start()
    {
        rbody = GetComponent<Rigidbody2D>();
    }

    void FixedUpdate()
    {
        //kollar om left är sann
        if (left == true)
        {
            //ger fienden en hastighet åt vänster som gångras med speed
            rbody.velocity = -(Vector2)transform.right * speed;

            //sätter skalan på råttan till 1, 1, 1
            transform.localScale = new Vector3(1, 1, 1); 
        }
        else
        {
            // ger fienden en hastighet åt höger som gångras med speed
            rbody.velocity = (Vector2)transform.right * speed;

            // sätter skalan på råttan till -1, 1, 1
            transform.localScale = new Vector3(-1, 1, 1); 
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        //sätter left till sitt nuvarande motstående värde
        left = !left; 
    }
}
