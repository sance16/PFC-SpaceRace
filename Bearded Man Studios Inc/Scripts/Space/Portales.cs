using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Portales : MonoBehaviour
{
    private int randomYDir;
    private int randomYDir2;
    private int rotacion;

    void Start()
    {

    }
    void Update()
    {
        //random para portal, probabilidad de 1/3
        var rand = Random.Range(1, 4);
        if (rand < 2)
        {
            randomYDir = 1228;
        }
        else if (rand == 3)
        {
            randomYDir = 704;
        }
        if (randomYDir == 704)
        {
            rotacion = -90;
        }else {
            rotacion = 90;
        }
    }
    //colision contra el portal que teletransporta las naves
    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "naveAzul")
        {
            GameObject.FindGameObjectWithTag("naveAzul").transform.position = new Vector3(50, 21, randomYDir);
            GameObject.FindGameObjectWithTag("naveAzul").transform.rotation = Quaternion.Euler(0, rotacion, 0);
        }
        if (collision.gameObject.tag == "naveRoja")
        {
            GameObject.FindGameObjectWithTag("naveRoja").transform.position = new Vector3(50, 21, randomYDir);
            GameObject.FindGameObjectWithTag("naveRoja").transform.rotation = Quaternion.Euler(0, rotacion, 0);
        }
    }
}

