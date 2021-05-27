using BeardedManStudios.Forge.Networking;
using BeardedManStudios.Forge.Networking.Generated;
using UnityEngine;

public class ShipMove : ShipMoveBehavior
{
    private float speed = 80.0F; //Velocidad de movimiento
    private float rotationSpeed = 100.0F; //Velocidad de rotación

    void Update()
    {
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
    }
}

