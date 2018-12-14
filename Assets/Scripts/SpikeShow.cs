using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpikeShow : MonoBehaviour
{
    private SpriteRenderer spikeRend;

    void Start()
    {
        //hämtar SpriteRenderer komponenten i objektets förälder och ger spkieRend det värdet
        spikeRend = GetComponentInParent<SpriteRenderer>();
    }


    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "Player")
        {
            //ger spikeRend färgen vit/1 på röd, 1 på grön, 1 på blå och 1 på genomskynlighet
            spikeRend.color = new Color(1, 1, 1, 1);
        }
    }
}
