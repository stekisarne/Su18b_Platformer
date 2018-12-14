using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;

public class FakeScript : MonoBehaviour
{
    private CompositeCollider2D cc;

    private TilemapRenderer tmRend;

    void Start()
    {
        //hämtar komponenten CompositeCollider2D hos föräldern och ger cc det värdet
        cc = GetComponentInParent<CompositeCollider2D>();

        //hämtar komponenten TilemapRenderer hos föräldern och ger tmRend det värdet
        tmRend = GetComponentInParent<TilemapRenderer>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "Player")
        {
            //stänger av komponenten cc
            cc.enabled = false;

            //stänger av komponenten tmRend
            tmRend.enabled = false;
        }
    }
}
