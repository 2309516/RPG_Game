using UnityEngine;
using PlayerAttackNS;
using HealthNS;
using TMPro;
using UnityEngine.SceneManagement;

namespace EnemyNS
{
public class Enemy : MonoBehaviour
{
    public PlayerAttackNS.PlayerAttack player;
    public int maxHealth = 50;
    public int currentHealth; 
    public int AtkDamage;

    public TMP_Text enemyHealthText;

    private void Start()
    {
        currentHealth = maxHealth;
    }
    public void TakeDamage(int damage)
    {
        currentHealth -= damage;
        Debug.Log("Enemy took " + damage + " damage. Current Health: " + currentHealth);
        UpdateHealthText();

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
    private void UpdateHealthText()
    {
        enemyHealthText.text = "Health: " + currentHealth.ToString();
    }
    private void Die()
    {
        SceneManager.LoadScene(2);
    }
}
}

