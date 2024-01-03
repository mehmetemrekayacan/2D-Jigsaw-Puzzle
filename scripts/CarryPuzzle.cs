using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarryPuzzle : MonoBehaviour
{
    new Camera camera;
    Vector2 startPosition;

    GameObject[] boxSet;

    static AudioSource sharedAudioSource; // Tüm parçalar için ayný AudioSource
    public AudioClip puzzleCompleteSound;  // Ses efekti dosyasý

    bool isSoundPlayed = false;  // Sesin bir kez çalýnýp çalýnmadýðýný kontrol etmek için

    private void OnMouseDrag()
    {
        Vector3 position = camera.ScreenToWorldPoint(Input.mousePosition);
        position.z = 0;
        transform.position = position;
    }

    // Start is called before the first frame update
    void Start()
    {
        camera = GameObject.Find("Main Camera").GetComponent<Camera>();
        startPosition = transform.position;

        boxSet = GameObject.FindGameObjectsWithTag("Box");

        // Ýlk parçanýn Start fonksiyonu içinde bir kez atanmasý
        if (sharedAudioSource == null)
        {
            sharedAudioSource = gameObject.AddComponent<AudioSource>();
            sharedAudioSource.clip = puzzleCompleteSound;
        }
    }

    // Update is called once per frame
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

                        // Puzzle tamamlandýðýnda ses efekti çal (sadece bir kez)
                        if (sharedAudioSource && puzzleCompleteSound && !isSoundPlayed)
                        {
                            sharedAudioSource.PlayOneShot(puzzleCompleteSound);
                            isSoundPlayed = true;  // Ses çalýndý, bir daha çalmayacak
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



