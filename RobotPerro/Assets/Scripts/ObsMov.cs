using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObsMov : MonoBehaviour
{
    public float speed;
    public Transform puntodellegada;
    public Vector3 direccion;

    // Update is called once per frame
    void Update()
    {
        transform.Translate(direccion*Time.deltaTime);
    }
}
