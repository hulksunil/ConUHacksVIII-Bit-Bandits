using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void StartGame()
    {
        SceneManager.LoadScene("GamePlay");

        //Starts the next scene 
        //SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex+1);   
    }

    public void QuitGame()
    {
        Debug.Log("The game has been quitted");
        Application.Quit();
            
    }
}
