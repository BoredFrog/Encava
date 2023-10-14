using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Score : MonoBehaviour
{
    public float score;
    public TextMeshProUGUI texto;

    // Start is called before the first frame update
    void Start()
    {
        texto = GetComponent<TextMeshProUGUI>();
    }

    // Update is called once per frame
    void Update()
    {
        
        score += 10f * Time.deltaTime;
        texto.text = "Score: " + Mathf.Round(score) + " m";
    }
}
