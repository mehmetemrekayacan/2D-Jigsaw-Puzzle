using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuManager : MonoBehaviour
{
    
    public void PlayGame()
    {
        SceneManager.LoadScene("LevelMenu"); 
    }

    public void OpenGallery()
    {
        SceneManager.LoadScene("GalleryMenu");
    }

    public void OpenSettings()
    {
        SceneManager.LoadScene("Settings");
    }
    
    public void QuitGame()
    {
        Debug.Log("Quit Game button clicked");
        Application.Quit();
    }
}
