using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EscMenuScript : MonoBehaviour
{
    public bool pPressed;

    public GameObject go;

    private movementScript mScript;

    void Start()
    {
        //hämtar komponenten movementScript och ger mScript det värdet
        mScript = GetComponent<movementScript>();
    }

    void Update()
    {
        //kollar om P är nedtryckt
        if (Input.GetKeyDown(KeyCode.P))
        {
            //sätter pPressed till sitt nuvarande motstående värde
            pPressed = !pPressed;
        }

        //kollar om pPressed är sann
        if(pPressed == true)
        {
            //aktiverar spelobjektet go
            go.SetActive(true);

            //stänger av komponenten mScript
            mScript.enabled = false;
        }
        else
        {
            //avaktiverar spelobjektet go
            go.SetActive(false);

            //sätter på komponenten mScript
            mScript.enabled = true;
        }
    }
}
