using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Moves : MonoBehaviour
{

    public float distance;
    private vida vida;
    public int puntos;

    private void Start()
    {
        vida = GetComponent<vida>();
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.LeftArrow) && transform.position.z < 2.93)

        {
            transform.position = new Vector3(0, 0, distance + transform.position.z);

        }

        if (Input.GetKeyDown(KeyCode.RightArrow) && transform.position.z > 1.33)

        {
            transform.position = new Vector3(0, 0, -distance + transform.position.z);

        }

        
    }

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "Obstaculos")
        {
            print(collision.gameObject.name);
            vida.DescontarVida(10f);
            Destroy(collision.gameObject);
        }
    }
}
