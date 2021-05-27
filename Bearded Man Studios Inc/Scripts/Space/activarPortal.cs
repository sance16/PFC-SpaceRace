using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class activarPortal : MonoBehaviour
{
    public GameObject cube;
    public GameObject portal;
    public GameObject portalAudio;
    void OnCollisionEnter(Collision collision)
    {
        //Activar objetos de cajas si colisionan las naves contra las cajas
        if (collision.gameObject.tag == "naveAzul" || collision.gameObject.tag == "naveRoja")
        {
            portal.SetActive(true);
            portalAudio.SetActive(true);
        }
        StartCoroutine(activar());
    }
    IEnumerator activar()
    {
        yield return new WaitForSecondsRealtime(3);
        portal.SetActive(false);
        portalAudio.SetActive(false);
    }
}
