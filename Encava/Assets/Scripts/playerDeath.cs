using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerDeath : MonoBehaviour
{
    public Animator explosion;
    public GameObject spawnDeEnemigos;
    public MovimientoBus movimientoPlayer;
    public Rigidbody2D postesVelocidad;

    // Start is called before the first frame update
    void Start()
    {
        
    }
    public void OnTriggerEnter2D(Collider2D collider)
    {
        Debug.Log("Colisiono");
        if (collider.gameObject.tag == "Enemigo")
        {
            explosion.enabled = true;
            spawnDeEnemigos.SetActive(false);
            spawnDeEnemigos.SetActive(true);
            movimientoPlayer.enabled = false;
            postesVelocidad.velocity = new Vector2(0, 0);
            Debug.Log("Exploto");
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
