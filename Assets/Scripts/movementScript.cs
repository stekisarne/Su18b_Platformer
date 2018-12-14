using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movementScript : MonoBehaviour
{
    //ändra hur snabbt man springer
    public float moveSpeed = 6f;

    //ändra hur högt man hoppar
    public float jumpSpeed = 12f;

    public GroundChecker gcheck;

    private Rigidbody2D rbody;

    void Start()
    {
        //hämtar en rigidbody2D komponent och ger rbody det värdet
        rbody = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        //sätter en hastighet åt ett speciellt håll när du klickar på någon av dem horisontella knapparna
        rbody.velocity = new Vector2(Input.GetAxisRaw("Horizontal") * moveSpeed, rbody.velocity.y);

        //känner av ifall spelaren klickar på en hopp knapp
        if (Input.GetButtonDown("Jump"))
        {
            //kollar om isGrounded är mer ån 0
            if (gcheck.isGrounded > 0 )
            {
                //ger objektet hastigheten jumpspeed på Y axeln
                rbody.velocity = new Vector2(rbody.velocity.x,jumpSpeed);
            }
        }

    }
}
