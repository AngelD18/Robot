using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{ 
    public vida vidaJugador;
    public int puntos;
    public int puntosSegundo;
    public Text UIPuntos;

      public IEnumerator SumarPuntos() {
       while( vidaJugador.hp > 0) {
           yield return new WaitForSeconds(1);
           puntos+= puntosSegundo;
           UIPuntos.text = puntos + " puntos";
       }
   }
  
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(SumarPuntos());
    }
}
