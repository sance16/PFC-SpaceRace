using UnityEngine;
using BeardedManStudios.Forge.Networking.Unity;

public class Generar : MonoBehaviour
{
    public GameObject naveRoja;
    public GameObject naveAzul;
    public float speed = 10f;
    public object naveRojaText;

    //Generar nave Roja al pulsar botón
    public void GenerarNave1()
    {
        NetworkManager.Instance.InstantiateSpaceMove();
        naveAzul.GetComponentInChildren<Camera>().gameObject.SetActive(false);
    }
    //Generar nave Azul al pulsar botón
    public void GenerarNave2()
    {
        NetworkManager.Instance.InstantiateShipMove();
        naveRoja.GetComponentInChildren<Camera>().gameObject.SetActive(false);
    }
    //En caso de que exista más de una nave se borran para haber una de cada
    private void Update()
    {
        if (GameObject.FindGameObjectsWithTag("naveAzul").Length > 1)
        {
            Destroy(GameObject.FindGameObjectWithTag("naveAzul"));
        }
        if (GameObject.FindGameObjectsWithTag("naveRoja").Length > 1)
        {
            Destroy(GameObject.FindGameObjectWithTag("naveRoja"));
        }
    }
}