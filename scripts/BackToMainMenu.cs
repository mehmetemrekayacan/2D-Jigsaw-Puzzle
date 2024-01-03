using UnityEngine;
using UnityEngine.SceneManagement;

public class BackToMainMenu : MonoBehaviour
{
    
    public void LoadMainMenu()
    {
       
        SceneManager.LoadScene("MainMenu");
    }
}
