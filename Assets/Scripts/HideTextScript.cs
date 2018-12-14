using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HideTextScript : MonoBehaviour
{
    private MeshRenderer mRend;

    void Start()
    {
        //hämtar komponenten MeshRenderer i föräldern och ger mRend det värdet
        mRend = GetComponentInParent<MeshRenderer>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        //kollar om objektet som inträdde triggern har taggen "Player"
        if(collision.tag == "Player")
        {
            //sätter på mRend / komponenten MeshRenderer
            mRend.enabled = true;
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        //kollar om objektet som utträdde triggern har taggen "Player"
        if (collision.tag == "Player")
        {
            //stänger avs mRend / komponenten MeshRenderer
            mRend.enabled = false;
        }
    }
}
