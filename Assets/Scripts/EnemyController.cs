using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using SAE;
using UnityEngine.AI;

[RequireComponent(typeof(NavMeshAgent))]
public class EnemyController : MonoBehaviour
{
    [SerializeField] int health;
    [SerializeField] GameManager manager;
    NavMeshAgent agent;
    // Start is called before the first frame update
    void Start()
    {
        agent = this.GetComponent<NavMeshAgent>();
        
    }
    public void TakeDamage(int damage, ArcadeMachine.PlayerColorId player)
    {
        health -= damage;
        if (health <= 0)
        {
            manager.UpdateScore(1, player);
            manager.SetEnemyKilled(1);
            Destroy(this.gameObject);
        }
    }
    // Update is called once per frame
    void Update()
    {
        agent.speed = manager.GetEnemyMoveSpeed();
        agent.SetDestination(manager.GetActiveCamera().transform.position);
    }
}
