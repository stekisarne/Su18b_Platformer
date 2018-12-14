using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundChecker : MonoBehaviour
{
    public int isGrounded;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        //sätter isGrounded till 1 eller mer om man nuddar marken
        isGrounded++; 
    }

    //blir kallad när collidern "collision" utträder från triggern
    private void OnTriggerExit2D(Collider2D collision) 
    {
        //tar bort 1 från isGrounded
        isGrounded--; 
    }
}
