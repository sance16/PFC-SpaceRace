using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ContarVueltas : MonoBehaviour
{
    public Text t;
    int contador = -1;

    //Contador de vueltas al colisionar con la linea de meta
    void OnCollisionEnter(Collision collision)
    {
 
        if (collision.gameObject.tag == "Finish")
        {
            contador = contador + 1;
            t.text = contador.ToString() + "/3";
        }
        if (contador >= 3)
        {
            t.text = "FINISH";
            StartCoroutine(Finish());
        }
    }
    //Cambio de escena con espera de 2 segundos al finalizar
    IEnumerator Finish()
    {
        yield return new WaitForSecondsRealtime(2);
        SceneManager.LoadScene("FinishScene", LoadSceneMode.Additive);  
    }
}

