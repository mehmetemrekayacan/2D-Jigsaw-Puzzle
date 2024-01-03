using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarryPuzzle : MonoBehaviour
{
    new Camera camera;
    Vector2 startPosition;

    GameObject[] boxSet;

    static AudioSource sharedAudioSource; 
    public AudioClip puzzleCompleteSound;  

    bool isSoundPlayed = false;  

    private void OnMouseDrag()
    {
        Vector3 position = camera.ScreenToWorldPoint(Input.mousePosition);
        position.z = 0;
        transform.position = position;
    }

    
    void Start()
    {
        camera = GameObject.Find("Main Camera").GetComponent<Camera>();
        startPosition = transform.position;

        boxSet = GameObject.FindGameObjectsWithTag("Box");

        
        if (sharedAudioSource == null)
        {
            sharedAudioSource = gameObject.AddComponent<AudioSource>();
            sharedAudioSource.clip = puzzleCompleteSound;
        }
    }

    
    void Update()
    {
        if (Input.GetMouseButtonUp(0))
        {
            foreach (GameObject box in boxSet)
            {
                if (box.name == gameObject.name)
                {
                    float length = Vector3.Distance(box.transform.position, transform.position);
                    if (length <= 0.5)
                    {
                        transform.position = box.transform.position;

                        
                        if (sharedAudioSource && puzzleCompleteSound && !isSoundPlayed)
                        {
                            sharedAudioSource.PlayOneShot(puzzleCompleteSound);
                            isSoundPlayed = true;  
                        }
                    }
                    else
                    {
                        transform.position = startPosition;
                    }
                }
            }
        }
    }
}



