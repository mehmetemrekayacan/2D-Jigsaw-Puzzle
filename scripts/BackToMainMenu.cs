using UnityEngine;
using UnityEngine.SceneManagement;

public class BackToMainMenu : MonoBehaviour
{
    // Bu metot, butona t�kland���nda �a�r�lacak
    public void LoadMainMenu()
    {
        // MainMenu sahnesine ge�i� yap
        SceneManager.LoadScene("MainMenu");
    }
}
