using BeardedManStudios.Forge.Networking;
using BeardedManStudios.Forge.Networking.Generated;
using System.Collections;
using UnityEngine;

public class ShipMove : ShipMoveBehavior
{
    private float speed = 80.0F; //Velocidad de movimiento
    private float rotationSpeed = 100.0F; //Velocidad de rotación
    public GameObject particles;
    public GameObject boostAudio;
    public GameObject damageAudio;

    void Update()
    {
        //movimiento nave azul
        if (!networkObject.IsOwner)
        {
            transform.position = networkObject.position;
            transform.rotation = networkObject.rotation;
            return;
        }

        float mHorizontal = Input.GetAxis("Horizontal") * rotationSpeed * Time.deltaTime;
        float mVertical = Input.GetAxis("Vertical") * speed * Time.deltaTime;


        transform.Translate(0, 0, mVertical, Space.Self);
        transform.Rotate(0, mHorizontal, 0, Space.Self);

        networkObject.position = transform.position;
        networkObject.rotation = transform.rotation;

        //Restart horizontal naves
        if (Input.GetKey(KeyCode.Space)) {
            GameObject.FindGameObjectWithTag("naveAzul").transform.position = new Vector3(GameObject.FindGameObjectWithTag("naveAzul").transform.localPosition.x, 26, GameObject.FindGameObjectWithTag("naveAzul").transform.localPosition.z);
            GameObject.FindGameObjectWithTag("naveAzul").transform.rotation = Quaternion.Euler(0, GameObject.FindGameObjectWithTag("naveAzul").transform.localRotation.eulerAngles.y, 0);
        }
    }
    void OnCollisionEnter(Collision collision)
    {
        //reducción de velocidad al colisionar con pinchos
        if (collision.gameObject.tag == "pinchos")
        {
            speed = 20.0F;
            damageAudio.SetActive(true);

        }
        //aumento de velocidad al colisionar con boostspeed
        if (collision.gameObject.tag == "boost")
        {
            speed = 200.0F;
            particles.SetActive(true);
            boostAudio.SetActive(true);
        }
        StartCoroutine(velocidad());
    }
    //Después de 5 segundos vuelve a la velocidad normal
    IEnumerator velocidad()
    {
        yield return new WaitForSecondsRealtime(5);
        speed = 80.0F;
        particles.SetActive(false);
        boostAudio.SetActive(false);
        damageAudio.SetActive(false);
    }
}

