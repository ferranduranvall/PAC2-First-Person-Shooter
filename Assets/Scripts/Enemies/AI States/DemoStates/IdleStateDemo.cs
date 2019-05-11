using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IdleStateDemo : IEnemyStateDemo
{
    enemyAIDemo myEnemy;
    private int nextWayPoint = 0;

    // Cuando llamamos al constructor, guardamos 
    // una referencia a la IA de nuestro enemigo
    public IdleStateDemo(enemyAIDemo enemy)
    {
        myEnemy = enemy;
    }

    // Aquí va toda la funcionalidad que queramos 
    // que haga el enemigo cuando esté en este estado.
    public void UpdateState()
    {
        myEnemy.myMaterial.color = Color.green;

        // Le decimos al NavMeshAgent cuál es el punto
        // al que ha de dirigirse
        myEnemy.navMeshAgent.destination = myEnemy.wayPoints[nextWayPoint].position;
        // si hemos llegado al destino, cambiamos la
        // referencia al siguiente Waipoint
        if (myEnemy.navMeshAgent.remainingDistance <= myEnemy.navMeshAgent.stoppingDistance)
        {
            nextWayPoint = (nextWayPoint + 1) % myEnemy.wayPoints.Length;
        }
    }

    public void GoToAlertState()
    {
        myEnemy.currentState = myEnemy.alertState;
    }

    // Como ya estamos en el estado Idle, no
    // llamaremos nunca a esta función desde 
    // este estado
    public void GoToIdleState() { }


    public void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.tag == "Player")
            GoToAlertState();
    }

    // En el estado Idle, como el player está
    // fuera del trigger no haremos nada aquí
    public void OnTriggerStay(Collider col) { }
    public void OnTriggerExit(Collider col) { }
}
