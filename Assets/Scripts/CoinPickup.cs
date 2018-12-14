using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinPickup : MonoBehaviour
{
    public static int score; //skapar en int som är samma överallt

    public int coinAmount = 1;

    public float spinSpeed = 180;

    void Start()
    {

    }

    private void Update()
    {
        //roterar pengen med spinSpeed som hastighet
        transform.Rotate(0, spinSpeed * Time.deltaTime, 0);
    }

    private void OnTriggerEnter2D(Collider2D collision) //blir kallad när collidern "collision" inträder triggern
    {
        //kollar om objektet man kolliderar med har taggen Player
        if (collision.tag == "Player") 
        {
            //förstör objektet 
            Destroy(gameObject);

            //ökar poängen med coinAmount
            CoinPickup.score += coinAmount;
        }
    }
}
