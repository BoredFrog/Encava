using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class sliderStart : MonoBehaviour
{
   
    // Start is called before the first frame update
    void Start()
    {
        Slider barra = GetComponent<Slider>();
        if (PlayerPrefs.HasKey("volumen"))
            {
            Debug.Log("Si hay volumen");
                barra.value = PlayerPrefs.GetFloat("volumen");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
