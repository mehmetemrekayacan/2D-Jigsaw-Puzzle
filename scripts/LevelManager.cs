using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelManager : MonoBehaviour
{
    // Bu metot, butona týklandýðýnda çaðrýlacak
    public void LoadLevel(int levelNumber)
    {
        // levelNumber parametresi, butona týklandýðýnda geçilecek seviyenin numarasýný belirtir
        string levelName = "Level_" + levelNumber;

        // Belirtilen seviyeye geçiþ yap
        SceneManager.LoadScene(levelName);
    }
}

