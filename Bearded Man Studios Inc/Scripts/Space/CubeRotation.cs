using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeRotation : MonoBehaviour
{
    private float z;
    private GameObject[] cube;

    // Rotación de cubos
    void Start()
    {
        z = 1f; //velocidad
    }
    void Update()
    {
        cube = GameObject.FindGameObjectsWithTag("cube");
        for (int i = 0; i < cube.Length; i++)
        {
            cube[i].transform.Rotate(new Vector3(0, 0, z));
        }
    }
}
