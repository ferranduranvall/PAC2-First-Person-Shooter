using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GetHealth : MonoBehaviour
{
    public GameObject medicalBox;
    public GameObject player;

    public int currentHealth;                                   // The current health the player has.
    public Slider healthSlider;

    public AudioSource audioHealth;

    private void OnTriggerEnter(Collider other)
    {
        audioHealth.Play();
        medicalBox.SetActive(false);
        player.GetComponent<PlayerHealth>().currentHealth = 100;
        healthSlider.value = currentHealth;
    }
}