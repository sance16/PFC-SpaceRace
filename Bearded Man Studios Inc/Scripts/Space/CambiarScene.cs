
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class CambiarScene : MonoBehaviour
{
    public GameObject canvas;
    public GameObject naveRoja;
    public GameObject naveAzul;

    public void cambiarescena(string SampleScene) {
        naveAzul.transform.position = new Vector3(142, 0, 870);
        naveRoja.transform.position = new Vector3(142, 0, 910);
        canvas.SetActive(false);
    }
}
