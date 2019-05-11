using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AmmoGun : MonoBehaviour
{
    public GameObject ammoGunPack;
    public AudioSource getAmmoAudio;

    public int currentAmmo;
    public Text countAmmo;

    public GameObject Gun;

    private void OnTriggerEnter(Collider other)
    {

        ammoGunPack.SetActive(false);
        getAmmoAudio.Play();

        //GameObject.Find("gun").GetComponent<ShootGun>().currentAmmo = 10;
        Gun.GetComponent<ShootGun>().currentAmmo = 10;
        //currentAmmo = 10;
        countAmmo.text = currentAmmo.ToString();
    }
}
