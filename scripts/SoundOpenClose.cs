using UnityEngine;
using UnityEngine.UI;

public class SoundControl : MonoBehaviour
{
    private bool isMuted = false;
    public AudioSource audioSource;
    public Sprite soundOnSprite; 
    public Sprite soundOffSprite; 
    public Image soundButtonImage; 

    void Start()
    {
        
        UpdateSoundButtonImage();
    }

    
    public void ToggleSound()
    {
        isMuted = !isMuted;

        
        UpdateSoundButtonImage();

        
        if (isMuted)
        {
            audioSource.volume = 0;
        }
        else
        {
            audioSource.volume = (float)0.4;
        }
    }

    
    private void UpdateSoundButtonImage()
    {
        if (isMuted)
        {
            soundButtonImage.sprite = soundOffSprite; 
        }
        else
        {
            soundButtonImage.sprite = soundOnSprite; 
        }
    }
}

