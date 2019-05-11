using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GetArmor : MonoBehaviour
{
    public GameObject armorBox;
    public GameObject player;

    public int currentArmor;                                   // The current armor the player has.
    public Slider armorSlider;

    public AudioSource audioArmor;

    private void OnTriggerEnter(Collider other)
    {
        audioArmor.Play();
        armorBox.SetActive(false);
        player.GetComponent<PlayerHealth>().currentArmor = 100;
        armorSlider.value = currentArmor;
    }
}