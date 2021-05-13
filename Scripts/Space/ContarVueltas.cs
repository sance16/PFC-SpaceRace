using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ContarVueltas : MonoBehaviour
{
    public Text t;
    int contador=-1;
    // Start is called before the first frame update

    void OnCollisionEnter(Collision collision)
    {
        //Quitar vida al Boss
        if (collision.gameObject.tag == "Finish")
        {
            contador = contador + 1;
            t.text = contador.ToString() + "/10";
        }
        if(contador == 10)
        {
            t.text = "FINISH";
        }
    }
}

