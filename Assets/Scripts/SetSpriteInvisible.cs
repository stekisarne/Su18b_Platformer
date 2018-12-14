using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetSpriteInvisible : MonoBehaviour
{
    void Start()
    {
        //hämtar SpriteRenderer komponenten och stänger av den
        GetComponent<SpriteRenderer>().enabled = false;
    }
}
