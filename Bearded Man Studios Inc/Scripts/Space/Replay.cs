using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Replay : MonoBehaviour
{
    //Botón restart para reiniciar el juego
    public void Restart()
    {
        SceneManager.LoadScene("SampleScene", LoadSceneMode.Single);
    }
    //Botón X para quitar el juego
    public void QuitGame()
    {
        Application.Quit();
    }
}
