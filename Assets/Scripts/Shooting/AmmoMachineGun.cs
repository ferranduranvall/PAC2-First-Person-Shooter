using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AmmoMachineGun : MonoBehaviour
{
    public GameObject ammoMachineGunPack;
    public AudioSource getAmmoAudio;

    public int currentAmmo;
    public Text countAmmo;

    public GameObject MachineGun;

    private void OnTriggerEnter(Collider other)
    {

        ammoMachineGunPack.SetActive(false);
        getAmmoAudio.Play();

        //GameObject.Find("gun").GetComponent<ShootGun>().currentAmmo = 10;
        MachineGun.GetComponent<ShootMachineGun>().currentAmmo = 100;
        //currentAmmo = 10;
        countAmmo.text = currentAmmo.ToString();
    }
}
