using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Contador : MonoBehaviour
{
    public Text TextContador;
    public GameObject countSound;
    void Start()
    {
        StartCoroutine(Countdown(3));
    }

    IEnumerator Countdown(int seconds)
    {
        int count = seconds;
        
            while (count > 0)
            {
                countSound.SetActive(true);
                TextContador.text = count.ToString();
                yield return new WaitForSeconds(1);
                count--;
            }

            yield return new WaitForSeconds(2);
            StartGame();
        
    }

    void StartGame()
    {
        countSound.SetActive(false);
        TextContador.enabled = false;
        GameObject.FindGameObjectWithTag("naveRoja").GetComponent<SpaceMove>().enabled = true;
        GameObject.FindGameObjectWithTag("naveAzul").GetComponent<ShipMove>().enabled = true;
    }
}
