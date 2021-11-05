using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class MainMenu : MonoBehaviour
{
  public void PlayGame()
    {
        SceneManager.LoadScene("MarsInvaders");
    }

    public void QuitGame()
    {
        Application.Quit();
       // Debug.Log("Exit");  
    }
    public void Settings()
    {

    }


    public void RestartGame()
    {
        SceneManager.LoadScene("Main Menu");
    }
}
