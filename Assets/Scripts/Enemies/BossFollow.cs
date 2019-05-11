using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.SceneManagement;

public class BossFollow : MonoBehaviour
{
    public GameObject target = null;
    private NavMeshAgent alien = null;

    private Animator alienAnim;

    // Start is called before the first frame update
    void Start()
    {
        alien = this.GetComponent<NavMeshAgent>();
        alienAnim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        alien.SetDestination(target.transform.position);
        alienAnim.Play("Running");
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Player")
        {
            SceneManager.LoadScene("GameOverAlien");
        }
    }
}
