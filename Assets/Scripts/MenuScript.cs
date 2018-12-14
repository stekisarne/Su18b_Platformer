using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuScript : MonoBehaviour
{
    public static string levelName = "SampleScene";
    public GameObject main;
    public GameObject howTo;

    public void NextLevel()
    {
        //laddar scenen som är inskrivet i levelName
        SceneManager.LoadScene(levelName); 
    }

    public void MainMenu()
    {
        //laddar scenen "Main Menu"
        SceneManager.LoadScene("Main Menu");
    }
    public void QuitGame()
    {
        //stänger ner programmet (fungerar endast om spelet är byggt)
        Application.Quit();
    }

    public void BackToMain()
    {
        //aktiverar duken som kallas main 
        main.SetActive(true);

        //avaktiverar duken som kallas howTo
        howTo.SetActive(false);
    }
    public void HowToMenu()
    {
        //avaktiverar duken som kallas main
        main.SetActive(false);

        //aktiverar duken som kallas howTo
        howTo.SetActive(true);
    }

    public void Tutorial()
    {
        //laddar scenen som kallas "Tutorial"
        SceneManager.LoadScene("Tutorial");
    }
}
