using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class huecoMovement : MonoBehaviour
{
    //VELOCIDAD DEBE SER CAMBIADA A UNA VARIABLE GLOBAL QUE INCREMENTA CON LA DIFICULTAD
    public float Velocidad;
    private Rigidbody2D myRigidbody;
    private new Transform transform;

    // Start is called before the first frame update
    void Start()
    {
        myRigidbody = GetComponent<Rigidbody2D>();
        transform = GetComponent<Transform>();
        myRigidbody.velocity = new Vector2(-Velocidad, 0f);
    }


    // Update is called once per frame
    void Update()
    {
    }
}