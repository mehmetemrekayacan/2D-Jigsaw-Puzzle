using UnityEngine;
using UnityEngine.SceneManagement;

public class BackToMainMenu : MonoBehaviour
{
    // Bu metot, butona týklandýðýnda çaðrýlacak
    public void LoadMainMenu()
    {
        // MainMenu sahnesine geçiþ yap
        SceneManager.LoadScene("MainMenu");
    }
}
