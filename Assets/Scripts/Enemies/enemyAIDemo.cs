using UnityEngine;
using System.Collections;

public class enemyAIDemo : MonoBehaviour
{
    [HideInInspector] public IdleStateDemo    idleState;
    [HideInInspector] public AlertStateDemo   alertState;
    [HideInInspector] public IEnemyStateDemo  currentState;
    [HideInInspector] public UnityEngine.AI.NavMeshAgent navMeshAgent;

    public Transform[] wayPoints;
    public float rotationTime = 3.0f;

    public Material myMaterial;

    public PlayerHealth playerHealth;

    private float timeBetweenAttacks = 15f;     // The time in seconds between each attack.
    private int attackDamage = 1;               // The amount of health taken away per attack.
    private int armorDamage = 1;

    public GameObject shootPurple;

    void Start()
    {
        // Creamos los estados de nuestra IA.
        idleState = new IdleStateDemo(this);
        alertState  = new AlertStateDemo(this);

        // Le decimos que inicialmente empezará en Idle
        currentState = idleState;

        //Guardamos la referencia es nuestro NavMesh Agent
        navMeshAgent = GetComponent<UnityEngine.AI.NavMeshAgent>();
    }
    
    void Update()
    {
        // Como nuestros estados no heredan de
        // MonoBehaviour, no se llama a su update 
        // automáticamente, y nos encargaremos 
        // nosotros de llamarlo a cada frame.
        currentState.UpdateState();
    }

    // Ya que nuestros states no heredan de 
    // MonoBehaviour, tendremos que avisarles
    // cuando algo entra, está o sale de nuestro
    // trigger.
    void OnTriggerEnter(Collider col)
    {
        currentState.OnTriggerEnter(col);
    }

    void OnTriggerStay(Collider col)
    {
        currentState.OnTriggerStay(col);

        StartCoroutine(Attack());
    }

        IEnumerator Attack()
        {
            if (playerHealth.currentHealth > 0)
            {
                // ... damage the player.
                //playerHealth.TakeDamage(attackDamage);
                playerHealth.TakeDamage(attackDamage, armorDamage);
                shootPurple.SetActive(true);
                yield return 200;
            }
        }
        
    

    void OnTriggerExit(Collider col)
    {
        currentState.OnTriggerExit(col);
    }
}
