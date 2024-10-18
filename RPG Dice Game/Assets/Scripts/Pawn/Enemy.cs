using UnityEngine;
using PlayerAttackNS;
using HealthNS;

namespace EnemyNS
{
public class Enemy : MonoBehaviour
{
    public PlayerAttackNS.PlayerAttack player;
    public int maxHealth = 50;
    public int currentHealth; 
    public int AtkDamage;

    private void Start()
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
    
    public void AttackPlayer()
    {
        if (player != null)
        {
            AtkDamage = Random.Range(0, 16);
            Debug.Log("You were hit with " + AtkDamage + " damage");
            player.TakingDamage(AtkDamage);
        }
    }
    private void Die()
    {
        Debug.Log("Enemy died!");
        Destroy(gameObject);
    }
}
}

