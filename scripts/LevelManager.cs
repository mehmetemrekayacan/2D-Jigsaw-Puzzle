using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelManager : MonoBehaviour
{
    // Bu metot, butona tıklandığında çağrılacak
    public void LoadLevel(int levelNumber)
    {
        // levelNumber parametresi, butona tıklandığında geçilecek seviyenin numarasını belirtir
        string levelName = "Level_" + levelNumber;

        // Belirtilen seviyeye geçiş yap
        SceneManager.LoadScene(levelName);
    }
}

