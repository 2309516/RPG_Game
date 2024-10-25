using UnityEngine;
using DiceNS;
using EnemyNS;
using TMPro;
using DamageTextNS;
namespace PlayerAttackNS
{
public class PlayerAttack : MonoBehaviour
{
    public int Pierce;
    public int Slash;
    public int Cleave;
    public EnemyNS.Enemy enemy;
    public DamageTextNS.DamageText damageText;
    private bool isPlayerTurn = true;
    public int maxHealth = 100;
    public int currentHealth;
    public TMP_Text healthText;

    private void Start()
    {
        currentHealth = maxHealth;
    }
    public void PierceCard()
    {
        if (isPlayerTurn)
        {
            Pierce = RollDice(6);
            if (Pierce <= 1)
            {
                Attack(0);
                Debug.Log("Missed");                
            }
            else if(Pierce == 6)
            {
                Attack(Pierce + 2);
                Debug.Log("Critical Hit! You did 8 Damage");
            }
            else
            {
                Attack(Pierce);
                Debug.Log("Pierced for " + Pierce + " damage!");
            }
            
        }
    }
    public void SlashCard()
    {
        if (isPlayerTurn)
        {
            Slash = RollDice(12);
            if (Slash <= 4)
            {
                Attack(0);
                Debug.Log("Missed");
            }
            else if (Slash == 12)
            {
                Attack(Slash + 4);
                Debug.Log("Critical Hit! You did 16 Damage");
            }
            else
            {
                Attack(Slash);
                Debug.Log("Slashed for " + Slash + " damage!");
            }
        }
    }
    public void CleaveCard()
    {
        if (isPlayerTurn)
        {
            Cleave = RollDice(20);
            if (Cleave <= 12)
            {
                Attack(0);
                Debug.Log("Missed");
            }
            else if(Cleave == 20)
            {
                Attack(Cleave + 8);
                Debug.Log("Critical Hit! You did 28 Damage");
            }
            else
            {
                Attack(Cleave);
                Debug.Log("Cleaved for " + Cleave + " damage!");
            }
            
        }
    }
    private void Attack(int damage)
    {
        if (enemy != null)
        {
            enemy.TakeDamage(damage);
            damageText.DisplayDamage(damage);
            isPlayerTurn = false;
            StartCoroutine(EnemyTurn());
        }
    }   
    private int RollDice(int sides)
    {
        return Random.Range(1, sides+1);
    }

    System.Collections.IEnumerator EnemyTurn()
    {
        yield return new WaitForSeconds(1f);
        if(enemy != null)
        {
            enemy.AttackPlayer();
        }
        isPlayerTurn = true;
    }  
    public void TakingDamage(int damage)
    {
        currentHealth -= damage;
        Debug.Log("Took " + damage +" damage!");
        UpdateHealthText();
        if (currentHealth<0)
        {
            currentHealth = 0;
            Death();
        }

    }
    private void Death()
    {
        Debug.Log("You Died");
    }
    private void UpdateHealthText()
    {
        healthText.text = "Health: " + currentHealth.ToString();
    }
}
}
