using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CardDoor : MonoBehaviour
{

    public GameObject cardDoorCanvas;
    public GameObject cardDoor;

    public AudioSource pickupCard;

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            pickupCard.Play();
            cardDoorCanvas.SetActive(true);
            cardDoor.SetActive(false);
        }
    }
}
