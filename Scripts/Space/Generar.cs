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
        naveAzulCamera.GetComponentInChildren<Camera>().gameObject.SetActive(false);
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