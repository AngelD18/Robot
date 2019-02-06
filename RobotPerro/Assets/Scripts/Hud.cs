using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Hud : MonoBehaviour
{

    public Slider barravida;
    public vida vidaref;  
    public Image[] imgs;

    // Start is called before the first frame update
    IEnumerator Start()
    {
        while (true)
        {
            if (vidaref.hp < 30)
            {
                for (int i = 0; i < imgs.Length; i++)
                {
                    imgs[i].enabled = !imgs[i].enabled;
                }
            }
            else
            {
                for (int i = 0; i < imgs.Length; i++)
                {
                    imgs[i].enabled = true;
                }
            }
            yield return new WaitForSeconds(0.2f);
        }
    }

    // Update is called once per frame
    void Update()
    {
        barravida.value = vidaref.hp;
        
    }
}
