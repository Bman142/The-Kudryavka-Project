using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using SAE;

public class EnemyController : MonoBehaviour
{
    [SerializeField] int health;
    [SerializeField] GameManager manager;
    // Start is called before the first frame update
    void Start()
    {
        
    }
    public void takeDamage(int damage, ArcadeMachine.PlayerColorId player)
    {
        health -= damage;
        if (health <= 0)
        {
            manager.UpdateScore(1, player);
            manager.enemiesKilled += 1;
            Destroy(this.gameObject);
        }
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
