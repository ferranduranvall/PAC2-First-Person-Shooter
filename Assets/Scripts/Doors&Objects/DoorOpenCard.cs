using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DoorOpenCard : MonoBehaviour
{

    private Animator doorAnim;

    public GameObject cardCanvas;

    public AudioSource correctAudio, doorAudio;

    // Start is called before the first frame update
    void Start()
    {
        doorAnim = GetComponent<Animator>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player" && cardCanvas.activeSelf)
        {
            correctAudio.Play();
            doorAudio.Play();
            doorAnim.Play("DoorOpen");
            cardCanvas.SetActive(false);
        }
    }
}
