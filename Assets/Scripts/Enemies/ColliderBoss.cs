using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ColliderBoss : MonoBehaviour
{
    public GameObject alien, alienIdle1;

    public GameObject batteryCanvas;

    public AudioSource alienBossAudio;

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player" && batteryCanvas.activeSelf)
        {
            alien.SetActive(true);
            alienIdle1.SetActive(false);
            alienBossAudio.Play();
        }
    }
}
