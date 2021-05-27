using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class activarPinchos : MonoBehaviour
{
    public GameObject cube;
    public GameObject pinchos;
    void OnCollisionEnter(Collision collision)
     {
        //Activar objetos de cajas si colisionan las naves contra las cajas
         if (collision.gameObject.tag == "naveAzul" || collision.gameObject.tag == "naveRoja")
         {
            pinchos.SetActive(true);
        }
        StartCoroutine(activar());
    }
    IEnumerator activar()
    {
        yield return new WaitForSecondsRealtime(20);
        pinchos.SetActive(false);
    }
}
