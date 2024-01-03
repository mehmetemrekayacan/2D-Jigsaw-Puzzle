using UnityEngine;
using UnityEngine.SceneManagement;

public class AudioManager : MonoBehaviour
{
    private static AudioManager instance;

    private void Awake()
    {
        // �lk �rneklenen AudioManager'� koru
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            // �kinci �rneklenenleri yok et
            Destroy(gameObject);
        }
    }

    void Start()
    {
        // �ark�y� �al
        PlayMusic();
    }

    void PlayMusic()
    {
        // Audio Source'u al
        AudioSource audioSource = GetComponent<AudioSource>();

        // �ark� �al�n�yorsa tekrar ba�lat
        if (!audioSource.isPlaying)
        {
            audioSource.Play();
        }
    }

    private void OnEnable()
    {
        // SceneManager'�n sceneLoaded olay�na abone ol
        SceneManager.sceneLoaded += OnSceneLoaded;
    }

    private void OnDisable()
    {
        // SceneManager'�n sceneLoaded olay�ndan ayr�l
        SceneManager.sceneLoaded -= OnSceneLoaded;
    }

    void OnSceneLoaded(Scene scene, LoadSceneMode mode)
    {
        // Sahne de�i�ti�inde m�zi�i kontrol et ve ba�lat
        PlayMusic();
    }
}
