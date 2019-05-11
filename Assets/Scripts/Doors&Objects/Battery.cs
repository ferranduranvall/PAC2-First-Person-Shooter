using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Battery : MonoBehaviour
{
    public GameObject colliderFinal;
    public GameObject battery;

    public GameObject batteryCanvas;

    public AudioSource audioPickup;

    // Start is called before the first frame update
    void Start()
    {
        colliderFinal.SetActive(false);
    }

    private void OnTriggerEnter(Collider other)
    {
        audioPickup.Play();
        battery.SetActive(false);
        colliderFinal.SetActive(true);
        batteryCanvas.SetActive(true);
    }
}
