using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObsMov : MonoBehaviour
{
    public float speed = 1;
    public Transform puntodellegada;
    public Vector3 direccion;

    // Update is called once per frame
    void Update()
    {
        transform.Translate(speed * direccion*Time.deltaTime);
    }
}
