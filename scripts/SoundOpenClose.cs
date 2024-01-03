using UnityEngine;
using UnityEngine.UI;

public class SoundControl : MonoBehaviour
{
    private bool isMuted = false;
    public AudioSource audioSource;
    public Sprite soundOnSprite; // Ses a��k durumu i�in sprite
    public Sprite soundOffSprite; // Ses kapal� durumu i�in sprite
    public Image soundButtonImage; // Ses d��mesi i�in Image bile�eni

    void Start()
    {
        // Ba�lang��ta ses kapal�ysa, d��me g�r�nt�s�n� g�ncelle
        UpdateSoundButtonImage();
    }

    // Ses d��mesine t�kland���nda �a�r�lacak fonksiyon
    public void ToggleSound()
    {
        isMuted = !isMuted;

        // Ses durumuna g�re d��me g�r�nt�s�n� g�ncelle
        UpdateSoundButtonImage();

        // Ses durumuna g�re sesi a� veya kapat
        if (isMuted)
        {
            audioSource.volume = 0;
        }
        else
        {
            audioSource.volume = (float)0.4;
        }
    }

    // Ses d��mesi g�r�nt�s�n� g�ncelleyen yard�mc� fonksiyon
    private void UpdateSoundButtonImage()
    {
        if (isMuted)
        {
            soundButtonImage.sprite = soundOffSprite; // Ses kapal� durumu i�in g�r�nt�
        }
        else
        {
            soundButtonImage.sprite = soundOnSprite; // Ses a��k durumu i�in g�r�nt�
        }
    }
}

