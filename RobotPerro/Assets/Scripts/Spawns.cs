using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawns : MonoBehaviour
{
    public float tiempomax, tiempomin;
    public float tiempo;
    public GameObject[] obstaculos;


    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(spawnearobstaculos());
    }

    // Update is called once per frame
    void Update()
    {

    }

    IEnumerator spawnearobstaculos()
    {
        while (true)
        {
            tiempo = Random.Range(tiempomin, tiempomax);
            yield return new WaitForSeconds(tiempo);
            Instantiate(obstaculos[Random.Range(0, obstaculos.Length)], transform.position, Quaternion.identity);
        }

    }
}
