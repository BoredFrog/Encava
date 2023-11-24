using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class drossChooser : MonoBehaviour
{
    public AudioClip[] audioClips;
    private AudioSource salsaSource;
    public int currentSong = 0;
    // Start is called before the first frame update
    void Awake()
    {
        currentSong = Random.Range(0, audioClips.Length);
        salsaSource = GetComponent<AudioSource>();
        salsaSource.clip = audioClips[currentSong];
        salsaSource.Play();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
