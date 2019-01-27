using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class vida : MonoBehaviour
{
    public float hp;
    public GameObject panelMuerte;

    public void DescontarVida(float descontar){
        hp-= descontar;

        if(hp<=0)
            panelMuerte.SetActive(true);
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
