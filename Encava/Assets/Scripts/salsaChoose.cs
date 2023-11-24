using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class salsaChoose : MonoBehaviour
{
    public AudioClip[] audioClips;
    [TextArea]
    public string[] songsName;
    private AudioSource salsaSource;
    public int currentSong = 0;
    public Animator animador;
    public TextMeshProUGUI texto;

    private bool timeOffset = false;
    private bool funcionActive = false;

    // Start is called before the first frame update
    void Start()
    {

       
        currentSong = Random.Range(0, audioClips.Length);
        salsaSource = GetComponent<AudioSource>();
        salsaSource.clip = audioClips[currentSong];
        texto.text = songsName[currentSong];
        salsaSource.Play();
        if (PlayerPrefs.HasKey("volumen"))
        {
            salsaSource.volume = PlayerPrefs.GetFloat("volumen");
        }
        StartCoroutine(animationTrigger());
    }
    IEnumerator animationTrigger()
    {
        StartCoroutine(checkFinish());
        funcionActive = true;
        timeOffset = false;
        yield return new WaitForSeconds(3);
        if (timeOffset)
        {
            StartCoroutine(animationTrigger());
        }
        else
        {
            funcionActive = false;
            animador.SetTrigger("fade");
        }
    }

    IEnumerator checkFinish()
    {
        var waitForClipRemainingTime = new WaitForSeconds(salsaSource.clip.length);
        yield return waitForClipRemainingTime;
        yield return new WaitForSeconds(1f);
        if (salsaSource.isPlaying == false)
        {
            currentSong++;
            if (currentSong > audioClips.Length - 1)
            {
                currentSong = 0;
            }
            salsaSource.clip = audioClips[currentSong];
            salsaSource.Play();
            texto.text = songsName[currentSong];


            timeOffset = true;
            if (animador.GetCurrentAnimatorStateInfo(0).IsName("FadeOut"))
            {
                if (funcionActive == false) { StartCoroutine(animationTrigger()); }
            }
            else
            {
                animador.SetTrigger("fade");
                StartCoroutine(animationTrigger());
            }
        }
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
            texto.text = songsName[currentSong];


            timeOffset = true;
            if (animador.GetCurrentAnimatorStateInfo(0).IsName("FadeOut"))
            {
                if (funcionActive == false) { StartCoroutine(animationTrigger()); }
            }
            else
            {
                animador.SetTrigger("fade");
                StartCoroutine(animationTrigger());
            }

        }
    }
}
