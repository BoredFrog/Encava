using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerDeath : MonoBehaviour
{
    public Animator explosion;
    public GameObject spawnDeEnemigos;
    public MovimientoBus movimientoPlayer;
    public Rigidbody2D postesVelocidad;
    public GameObject textoMusica;
    public Score textoScore;
    public GameObject musica;
    public AudioSource aS;
    public AudioClip[] deathTrack;

    public GameObject negrito;

    // Start is called before the first frame update
    void Start()
    {
        
    }
    public void OnTriggerEnter2D(Collider2D collider)
    {

        if (collider.gameObject.tag == "Enemigo")
        {
            if (collider.gameObject.GetComponent<motoMovement>())
            {
                aS.clip = deathTrack[1];
            }
            else
            {

                aS.clip = deathTrack[0];
            }
            explosion.enabled = true;
            negrito.SetActive(true);
            spawnDeEnemigos.SetActive(false);
            spawnDeEnemigos.SetActive(true);
            movimientoPlayer.enabled = false;
            textoMusica.SetActive(false);
            textoScore.enabled = false;
            musica.SetActive(false);
            GetComponent<Rigidbody2D>().velocity = new Vector2(0, 0);
            GetComponent<AudioSource>().enabled = false;
            postesVelocidad.velocity = new Vector2(0, 0);

            int highScore = (int) (textoScore.score);
            if (PlayerPrefs.HasKey("hiScore"))
            {
                if (highScore > PlayerPrefs.GetInt("hiScore"))
                {
                    PlayerPrefs.SetInt("hiScore", highScore);
                    PlayerPrefs.Save();
                    Debug.Log(PlayerPrefs.GetInt("hiScore"));
                }
            }
            else
            {
                PlayerPrefs.SetInt("hiScore", highScore);
                PlayerPrefs.Save();
                Debug.Log(PlayerPrefs.GetInt("hiScore"));
            }

            
        }
        if (collider.gameObject.tag == "Door2")
        {

            if (gameObject.activeSelf)
            {

                collider.gameObject.SetActive(false);
                Destroy(collider.gameObject);
            }

        }
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
