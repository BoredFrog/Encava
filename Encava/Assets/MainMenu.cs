using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    // Start is called before the first frame update
    public Animator animador;
    public GameObject negro;
    public musicaTransicion musica;

        
  
    public void EscenaJuego()
    {
        animador.SetTrigger("trigger");
        negro.SetActive(true);
        musica.transicion = true;
        StartCoroutine(ChangeScene());
    }
    public void cambiarMusica()
    {
        PlayerPrefs.SetFloat("volumen",musica.musica.volume);
    }
    public IEnumerator ChangeScene()
    {
        yield return new WaitForSeconds(2.5f);
        Debug.Log("Me cambie");
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void Salir()
    {
        Application.Quit();
    }
}
