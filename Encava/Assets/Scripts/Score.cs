using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Score : MonoBehaviour
{
    public float score;
    public TextMeshProUGUI texto;
    public float scoreFalso;
    public enemySpawner spawneadorEnemigo;

    // Start is called before the first frame update
    void Start()
    {
        texto = GetComponent<TextMeshProUGUI>();
    }

    // Update is called once per frame
    void Update()
    {
        scoreFalso += 10f * Time.deltaTime;
        score += 10f * Time.deltaTime;
        texto.text = "Score: " + Mathf.Round(score) + " m";
        if(scoreFalso >= 100)
        {
            if (spawneadorEnemigo.tiempo > 0.9f)
            {
                spawneadorEnemigo.tiempo -= .1f;
                scoreFalso = 0f;
            }
        }

    }
}
