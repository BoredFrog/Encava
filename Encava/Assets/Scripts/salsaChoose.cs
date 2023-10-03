using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class salsaChoose : MonoBehaviour
{
    public AudioClip[] audioClips;
    private AudioSource salsaSource;
    public int currentSong = 0;
    // Start is called before the first frame update
    void Start()
    {
        salsaSource = GetComponent<AudioSource>();
        salsaSource.clip = audioClips[currentSong];
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.R))
        {
            currentSong++;
            if (currentSong > audioClips.Length - 1){
                currentSong = 0;
            }
            salsaSource.clip = audioClips[currentSong];
            salsaSource.Play();
        }
    }
}
