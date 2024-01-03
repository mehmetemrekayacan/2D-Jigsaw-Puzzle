using UnityEngine;
using UnityEngine.SceneManagement;

public class BackToMainMenu : MonoBehaviour
{
    // Bu metot, butona tıklandığında çağrılacak
    public void LoadMainMenu()
    {
        // MainMenu sahnesine geçiş yap
        SceneManager.LoadScene("MainMenu");
    }
}
