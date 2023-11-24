using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class cinematica : MonoBehaviour
{
    public GameObject musica1;
    public Animator animator;
    public GameObject musica2;
    public GameObject sfx1;
    public GameObject sfx2;
    public GameObject sfx3;
    public GameObject texto;
    public GameObject negro;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(ChangeScene());
    }

    IEnumerator ChangeScene()
    {
        yield return new WaitForSeconds(63f);
        Debug.Log("Me cambie");
        cambiarEscena();
    }
    void cambiarEscena()
    {
        animator.enabled = false;
        musica1.SetActive(false);
        musica2.SetActive(false);
        sfx1.SetActive(false);
        sfx2.SetActive(false);
        sfx3.SetActive(false);
        texto.SetActive(false);
        negro.GetComponent<Image>().color = new Vector4(0,0,0,1);
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            cambiarEscena();
        }
    }
}
