using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShootMachineGun : MonoBehaviour
{

    public GameObject decalPrefab;

    GameObject[] totalDecals;
    int actual_decal = 0;

    public AudioSource fireSound;
    public AudioSource explosionSound;

    public GameObject fireShoot;
    public GameObject explosionParticles, explosionParticles2, explosionParticles3, explosionParticles4, explosionParticles5, explosionParticles6, explosionParticles7;

    [SerializeField]
    public int currentAmmo;
    public Text countAmmo;

    public GameObject enemy1, enemy2, enemy3, enemy4, enemy5, enemy6, enemy7;

    ////Rate Od Fire
    //[SerializeField]
    //float rateOfFire;
    //float nextFire = 0;

    //[SerializeField]
    //float weaponRange;

    // Start is called before the first frame update
    void Start()
    {
        fireShoot.SetActive(false);
        totalDecals = new GameObject[5];
        countAmmo.text = currentAmmo.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        fireShoot.SetActive(false);

        if (Input.GetMouseButtonDown(0)&& currentAmmo > 0)
        {
            RaycastHit hit;

            if(Physics.Raycast(
                Camera.main.ViewportPointToRay(
                    new Vector3(0.5f, 0.5f, 0)),
                out hit, 30))
            {
                //¡IMPACTO!
                Destroy(totalDecals[actual_decal]);
                totalDecals[actual_decal]=
                Instantiate(decalPrefab, hit.point + hit.normal * 0.01f,
                    Quaternion.FromToRotation(Vector3.forward, -hit.normal));


                actual_decal++;
                if (actual_decal == 5) actual_decal = 0;
                fireSound.Play();
                fireShoot.SetActive(true);

                //currentAmmo--;
                currentAmmo= currentAmmo -2;
                countAmmo.text = currentAmmo.ToString();

                // If the Enemycomponent exist...

                if (hit.collider.CompareTag("Enemy"))
                {
                    //destroy enemy
                    explosionSound.Play();
                    explosionParticles.SetActive(true);
                    Destroy(enemy1, 1);
                }

                if (hit.collider.CompareTag("Enemy2"))
                {
                    //destroy enemy
                    explosionSound.Play();
                    explosionParticles2.SetActive(true);
                    Destroy(enemy2, 1);
                }

                if (hit.collider.CompareTag("Enemy3"))
                {
                    //destroy enemy
                    explosionSound.Play();
                    explosionParticles3.SetActive(true);
                    Destroy(enemy3, 1);
                }

                if (hit.collider.CompareTag("Enemy4"))
                {
                    //destroy enemy
                    explosionSound.Play();
                    explosionParticles4.SetActive(true);
                    Destroy(enemy4, 1);
                }

                if (hit.collider.CompareTag("Enemy5"))
                {
                    //destroy enemy
                    explosionSound.Play();
                    explosionParticles5.SetActive(true);
                    Destroy(enemy5, 1);
                }

                if (hit.collider.CompareTag("Enemy6"))
                {
                    //destroy enemy
                    explosionSound.Play();
                    explosionParticles6.SetActive(true);
                    Destroy(enemy6, 1);
                }

                if (hit.collider.CompareTag("Enemy7"))
                {
                    //destroy enemy
                    explosionSound.Play();
                    explosionParticles7.SetActive(true);
                    Destroy(enemy7, 1);
                }
            }
        }
    }
}
