using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovTerr : MonoBehaviour
{
    public float scrollspeed;
    private Vector3 posicioninicial;
    private float tilesize;


    // Start is called before the first frame update
    void Start()
    {
        posicioninicial = transform.position;
        tilesize = transform.localScale.z;

    }

    // Update is called once per frame
    void Update()
    {
        float newposition = Mathf.Repeat(Time.time * scrollspeed, tilesize);
        transform.position = posicioninicial + (Vector3.left * newposition);
    }
}
