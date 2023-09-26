using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovimientoBus : MonoBehaviour
{
    public Vector3 Movimiento;
    public float Velocidad;
    public float velocidadY;
    public string IndicadorIdle = "down";
    private Rigidbody2D myRigidbody;
    private new Transform transform;
    public bool MoviendoseEnDireccionX = false;
    public bool MoviendoseEnDireccionY = false;
    public bool InvertirEjes;
    public bool InvertirSentido;
    // Start is called before the first frame update
    void Start()
    {
        myRigidbody = GetComponent<Rigidbody2D>();
        transform = GetComponent<Transform>();
    }


    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Space))
        {
            Velocidad = 3.5f;
            velocidadY = 1.5f;
        }
        else
        {
            velocidadY = 1.5f;
            Velocidad = 1.5f;
        }

        Movimiento = new Vector3(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical"), 0);
        if (InvertirEjes == true)
        {
            Movimiento = new Vector3(Input.GetAxisRaw("Vertical"), Input.GetAxisRaw("Horizontal"), 0);
        }
        if (InvertirSentido == true)
        {
            Movimiento.x = Movimiento.x * -1;
            Movimiento.y = Movimiento.y * -1;
        }


        if (Movimiento.x >= 0.5f)
        {
   
            //gameObject.GetComponent<Animator>().SetBool("movingside", true);
            myRigidbody.velocity = new Vector2(Movimiento.x * Velocidad, myRigidbody.velocity.y);
            MoviendoseEnDireccionX = true;
        }
        if (Movimiento.x <= -0.5f)
        {
            //gameObject.GetComponent<Animator>().SetBool("movingside", true);

            myRigidbody.velocity = new Vector2(Movimiento.x * Velocidad * 2f, myRigidbody.velocity.y);
            MoviendoseEnDireccionX = true;
        }
        if (Movimiento.y >= 0.5f)
        {
            //gameObject.GetComponent<Animator>().SetBool("movingside", true);
            myRigidbody.velocity = new Vector2(myRigidbody.velocity.x, Movimiento.y * Velocidad *velocidadY);
            MoviendoseEnDireccionX = true;
        }
        if (Movimiento.y <= -0.5f)
        {
            //gameObject.GetComponent<Animator>().SetBool("movingside", true);
            myRigidbody.velocity = new Vector2(myRigidbody.velocity.x, Movimiento.y * Velocidad*velocidadY);
            MoviendoseEnDireccionX = true;
        }

        if (Movimiento.x < 0.4f && Movimiento.x > -0.4f)
        {
            //gameObject.GetComponent<Animator>().SetBool("movingside", false);
            //gameObject.GetComponent<Animator>().SetBool("check_idle", true);
            myRigidbody.velocity = new Vector2(0f, myRigidbody.velocity.y);
            MoviendoseEnDireccionX = false;
        }
        if (Movimiento.y < 0.4f && Movimiento.y > -0.4f)
        {
            //gameObject.GetComponent<Animator>().SetBool("movingside", false);
            //gameObject.GetComponent<Animator>().SetBool("check_idle", true);
            myRigidbody.velocity = new Vector2(myRigidbody.velocity.x, 0f);
            MoviendoseEnDireccionY = false;
        }
        if (Movimiento.y == 0f && Movimiento.x == 0f)
        {
            if (transform.position.x > -6f)
            {
                myRigidbody.velocity = new Vector2(-1.5f, 0f);
                MoviendoseEnDireccionY = false;
                MoviendoseEnDireccionX = false;
            }
        }
    }
}
