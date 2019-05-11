using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeWeapon : MonoBehaviour
{

    public GameObject Gun;
    public GameObject uiGun;

    public GameObject MachineGun;
    public GameObject uiMachineGun;

    public AudioSource changeWeaponAudio;


    public int WeaponMode;

 

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Weaponamode"))
        {
            changeWeaponAudio.Play();
            if (WeaponMode == 1)
            {
                WeaponMode = 0;
            }
            else
            {
                WeaponMode += 1;
            }
            StartCoroutine(ModeChange());
        }
    }

    IEnumerator ModeChange()
    {
        yield return new WaitForSeconds(0.01f);
        if (WeaponMode == 0)
        {
            Gun.SetActive(true);
            uiGun.SetActive(true);
            MachineGun.SetActive(false);
            uiMachineGun.SetActive(false);
        }
        if (WeaponMode == 1)
        {
            Gun.SetActive(false);
            uiGun.SetActive(false);
            MachineGun.SetActive(true);
            uiMachineGun.SetActive(true);
        }
    }
}
