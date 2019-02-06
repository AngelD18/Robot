using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Continue : MonoBehaviour
{
   public void continuar(){
       SceneManager.LoadScene(1);
   }
  
 public void menu(){
       SceneManager.LoadScene(0);
   }
public void volver()
    {
       SceneManager.LoadScene(0);
    }
    public void iniciar_partida()
    {
        SceneManager.LoadScene(0);
    }


    public void creditos()
    {
        SceneManager.LoadScene(2);
    }

    public void salir()
    {
        Application.Quit();
    }






}
