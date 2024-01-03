using UnityEngine;
using UnityEngine.UI;

public class SoundControl : MonoBehaviour
{
    private bool isMuted = false;
    public AudioSource audioSource;
    public Sprite soundOnSprite; // Ses açýk durumu için sprite
    public Sprite soundOffSprite; // Ses kapalý durumu için sprite
    public Image soundButtonImage; // Ses düðmesi için Image bileþeni

    void Start()
    {
        // Baþlangýçta ses kapalýysa, düðme görüntüsünü güncelle
        UpdateSoundButtonImage();
    }

    // Ses düðmesine týklandýðýnda çaðrýlacak fonksiyon
    public void ToggleSound()
    {
        isMuted = !isMuted;

        // Ses durumuna göre düðme görüntüsünü güncelle
        UpdateSoundButtonImage();

        // Ses durumuna göre sesi aç veya kapat
        if (isMuted)
        {
            audioSource.volume = 0;
        }
        else
        {
            audioSource.volume = (float)0.4;
        }
    }

    // Ses düðmesi görüntüsünü güncelleyen yardýmcý fonksiyon
    private void UpdateSoundButtonImage()
    {
        if (isMuted)
        {
            soundButtonImage.sprite = soundOffSprite; // Ses kapalý durumu için görüntü
        }
        else
        {
            soundButtonImage.sprite = soundOnSprite; // Ses açýk durumu için görüntü
        }
    }
}

