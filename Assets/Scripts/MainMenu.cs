using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public GameObject mainMenu;
    public GameObject optionsMenu;
   // public GameObject GameManager;

   public void Start()
   {
       
   }

    public void PlayButton()
    {
        SceneManager.LoadScene(1);
    }

    public void OptionsButton()
    {
        mainMenu.SetActive(false);
        optionsMenu.SetActive(true);
    }

    public void QuitButton()
    {
        Application.Quit();
        Debug.Log("Quit");
    }

    public void RestartButton()
    {
        SceneManager.LoadScene(0);
    }

    public void MultiPlayerButton()
    {
        SceneManager.LoadScene(2);
    }
}

