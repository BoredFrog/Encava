using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class motoMovement : MonoBehaviour
{
    //VELOCIDAD DEBE SER CAMBIADA A UNA VARIABLE GLOBAL QUE INCREMENTA CON LA DIFICULTAD
    public float Velocidad;
    public float velocidadY; //Positivo para ir arriba y negativo para abajo
    private Rigidbody2D myRigidbody;
    private new Transform transform;

    // Start is called before the first frame update
    void Start()
    {
        myRigidbody = GetComponent<Rigidbody2D>();
        transform = GetComponent<Transform>();
        myRigidbody.velocity = new Vector2(-Velocidad, velocidadY);
        StartCoroutine(cambiarY());
    }

    IEnumerator cambiarY()
    {
        while (true)
        {
            yield return new WaitForSeconds(1f);
            myRigidbody.velocity = new Vector2(-Velocidad, myRigidbody.velocity.y * -1);
        }

    }

    // Update is called once per frame
    void Update()
    {

    }
}