using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelManager : MonoBehaviour
{
    // Bu metot, butona t�kland���nda �a�r�lacak
    public void LoadLevel(int levelNumber)
    {
        // levelNumber parametresi, butona t�kland���nda ge�ilecek seviyenin numaras�n� belirtir
        string levelName = "Level_" + levelNumber;

        // Belirtilen seviyeye ge�i� yap
        SceneManager.LoadScene(levelName);
    }
}

