using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelManager : MonoBehaviour
{
    
    public void LoadLevel(int levelNumber)
    {
        
        string levelName = "Level_" + levelNumber;

        
        SceneManager.LoadScene(levelName);
    }
}

