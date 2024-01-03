using UnityEngine;
using UnityEngine.SceneManagement;

public class AudioManager : MonoBehaviour
{
    private static AudioManager instance;

    private void Awake()
    {
        // Ýlk örneklenen AudioManager'ý koru
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            // Ýkinci örneklenenleri yok et
            Destroy(gameObject);
        }
    }

    void Start()
    {
        // Þarkýyý çal
        PlayMusic();
    }

    void PlayMusic()
    {
        // Audio Source'u al
        AudioSource audioSource = GetComponent<AudioSource>();

        // Þarký çalýnýyorsa tekrar baþlat
        if (!audioSource.isPlaying)
        {
            audioSource.Play();
        }
    }

    private void OnEnable()
    {
        // SceneManager'ýn sceneLoaded olayýna abone ol
        SceneManager.sceneLoaded += OnSceneLoaded;
    }

    private void OnDisable()
    {
        // SceneManager'ýn sceneLoaded olayýndan ayrýl
        SceneManager.sceneLoaded -= OnSceneLoaded;
    }

    void OnSceneLoaded(Scene scene, LoadSceneMode mode)
    {
        // Sahne deðiþtiðinde müziði kontrol et ve baþlat
        PlayMusic();
    }
}
