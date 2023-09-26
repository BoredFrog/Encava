using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class drag : MonoBehaviour
{

    private Transform transformo;
    private Rigidbody2D myRigidbody;
    public float velocidad;

    // Start is called before the first frame update
    void Start()
    {
        transformo = GetComponent<Transform>();
        myRigidbody = GetComponent<Rigidbody2D>();
        myRigidbody.velocity = new Vector2(-velocidad, 0);
    }

    // Update is called once per frame
    void Update()
    {

        if (transformo.position.x <= -29.32f)
        {
            transformo.position = new Vector3(0, 0, 0);
        }
        
    }
}
