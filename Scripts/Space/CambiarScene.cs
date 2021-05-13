
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
        canvas.SetActive(false);
        naveAzul.transform.position = new Vector3(-220, 21, 1260);
        naveRoja.transform.position = new Vector3(-220, 21, 1300);
    }
}
