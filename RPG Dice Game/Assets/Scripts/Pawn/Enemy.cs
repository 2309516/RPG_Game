using UnityEngine;

namespace EnemyNS
{
public class Enemy : MonoBehaviour
{
    public int maxHealth = 50;
    public int currentHealth; 

    void Start()
    {
        currentHealth = maxHealth;
    }
    public void TakeDamage(int damage)
    {
        currentHealth -= damage;
        Debug.Log("Enemy took " + damage + " damage. Current Health: " + currentHealth);

        if (currentHealth <= 0)
        {
            Die();
        }
    }
    void Die()
    {
        Debug.Log("Enemy died!");
        Destroy(gameObject);
    }
}
}

