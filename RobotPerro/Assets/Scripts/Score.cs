using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    private int puntos = 0;
    public vida vidaJugador;
    public int puntosSegundo;
    public Text UIPuntos;
     
    // Start is called before the first frame update
    void Start()
    {

    }

    public void SumarPuntos(int cantPoints)
    {
        puntos += puntosSegundo;
        UIPuntos.text = puntos + " puntos";
    }

}
