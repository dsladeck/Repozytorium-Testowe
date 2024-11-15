using System.Collections;
using System.Collections.Generic;
using TMPro.Examples;
using UnityEngine;

public class EndGameController : MonoBehaviour
{
    public PlayerController playerController;
    public int iloscPunktowZebrania;

    public AudioSource audioSource;
    public AudioClip audioClip;

    // Start is called before the first frame update
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            if (playerController.zebranePunkty == iloscPunktowZebrania)
            {
                Debug.Log("Zebrano wszystkie punkty. Koniec Gry");
            }
            
        }
    }
}
