using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemySpawner : MonoBehaviour
{
    public GameObject[] enemies;
    public float tiempo; //EN UN FUTURO SERA VARIABLE GLOBAL QUE DISMINUYA CON EL PASO DEL TIEMPO
    private int lastEnemy;
    private int invocadorMoto = 0; //Para que despues de que salgan muchos huecos obligado salga una motico

    // Start is called before the first frame update
    void Start()
    {
        //Delay de 5 segundos para que el usuario aprenda los controles
        //Random enemy pick
        //Instantiate(enemies[1]);
        StartCoroutine(ChooseEnemy());
    }

    IEnumerator ChooseEnemy()
    {
        int enemigo;
        yield return new WaitForSeconds(tiempo);
        enemigo = Random.Range(0, enemies.Length);

        lastEnemy = enemigo;
        if (enemigo > 5)
        {
            invocadorMoto++;
            if (invocadorMoto >= 4)
            {
                enemigo = Random.Range(6, enemies.Length);
                invocadorMoto = 0;
            }
           
        }

        var a = Instantiate(enemies[enemigo]);
        a.transform.parent = gameObject.GetComponent<Transform>();
       

        StartCoroutine(ChooseEnemy());
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
