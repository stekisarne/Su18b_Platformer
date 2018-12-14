using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class scoreText : MonoBehaviour
{
    private TextMeshProUGUI loremIpsum;
    void Start()
    {
        //hämtar komponenten TextMeshProUGUI och ger loremIpsum det värdet
        loremIpsum = GetComponent<TextMeshProUGUI>();
    }


    void Update()
    {
        //sätter texten till "Score: (insert score here)" baserat på hur mycket poäng man har
        loremIpsum.text = string.Format("Score: {0:0000}", CoinPickup.score);
    }
}
