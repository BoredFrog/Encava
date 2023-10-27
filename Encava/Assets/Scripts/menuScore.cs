using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class menuScore : MonoBehaviour
{
    public TextMeshProUGUI textoScore;
    public TextMeshProUGUI textoHiScore;
    public Score puntaje;

    // Start is called before the first frame update
    void Start()
    {
        updateScore();
    }
    public void updateScore()
    {
        textoScore.text = "" + Mathf.Round(puntaje.score) + " m";
        textoHiScore.text = "" + PlayerPrefs.GetInt("hiScore") + " m";
    }
    public void reloadScene()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
    public void backScene()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
