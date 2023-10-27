using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class musicaTransicion : MonoBehaviour
{
    public bool transicion;
    public AudioSource musica;
    // Start is called before the first frame update
    void Start()
    {
        musica = GetComponent<AudioSource>();

    }

    // Update is called once per frame
    void Update()
    {
        if (transicion)
        {
            musica.volume -= 0.8f * Time.deltaTime;
        }
    }
}
