using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadLevel : MonoBehaviour
{
    public int minimumScoreNeeded = 0;
    public string SceneToLoad = "SampleScene";
    public string NextLevel;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        //kollar om objektet som inträdde triggern hade taggen "Player" och om score är högre eller lika med minimumScoreNeeded
        if(collision.tag == "Player" && CoinPickup.score >= minimumScoreNeeded)
        {
            //sätter score till 0
            CoinPickup.score = 0;

            //laddar scenen SceneToLoad
            SceneManager.LoadScene(SceneToLoad);

            //ger levelName samma värde som NextLevel
            MenuScript.levelName = NextLevel;
        }
    }
}
