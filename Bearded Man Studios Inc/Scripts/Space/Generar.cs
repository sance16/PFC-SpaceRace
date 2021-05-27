using UnityEngine;
using BeardedManStudios.Forge.Networking.Unity;

public class Generar : MonoBehaviour
{
    public GameObject naveRojaCamera;
    public GameObject naveAzulCamera;
    public float speed = 10f;



    public void GenerarNave1()
    {
        NetworkManager.Instance.InstantiateSpaceMove();
        naveRojaCamera.GetComponentInChildren<Camera>().gameObject.SetActive(false);
        //naveRoja.GetComponent<Canvas>().gameObject.SetActive(false);
    }

    public void GenerarNave2()
    {
        NetworkManager.Instance.InstantiateShipMove();
        naveRojaCamera.GetComponentInChildren<Camera>().gameObject.SetActive(false);
        //naveAzul.GetComponent<Canvas>().gameObject.SetActive(false);
    }
    private void Update()
    {
        if (GameObject.FindGameObjectsWithTag("NaveAzul").Length > 1)
        {
            Destroy(GameObject.FindGameObjectWithTag("NaveAzul"));
        }
        if (GameObject.FindGameObjectsWithTag("NaveRoja").Length > 1)
        {
            Destroy(GameObject.FindGameObjectWithTag("NaveRoja"));
        }
    }
}