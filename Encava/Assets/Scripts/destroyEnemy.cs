using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class destroyEnemy : MonoBehaviour
{
    private Transform transformo;
    public bool tienePapa;

    // Start is called before the first frame update
    void Start()
    {
        transformo = GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {

        if (transformo.position.x <= -20f)
        {
            Destroy(gameObject);
            if (tienePapa)
            {
                Destroy(transformo.parent.gameObject);
            }
        }

    }
}
