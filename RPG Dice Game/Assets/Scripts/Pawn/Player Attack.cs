using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DiceNS;
using EnemyNS;

namespace PlayerAttackNS
{
public class PlayerAttack : MonoBehaviour
{
    public int Pierce;
    public int Slash;
    public int Cleave;
    public EnemyNS.Enemy enemy;
    private bool isPlayerTurn = true;
    public int maxHealth = 100;
    public int currentHealth;

    private void Start()
    {
        currentHealth = maxHealth;
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            Pierce = RollDice(6);
            Attack(Pierce);
            Debug.Log("Pierced for " + Pierce + " damage!");
        }
        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            Slash = RollDice(12);
            Attack(Slash);
            Debug.Log("Slashed for " + Slash + " damage!");
        }
        if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            Cleave = RollDice(20);
            Attack(Cleave);
            Debug.Log("Cleaved for " + Cleave + " damage!");
        }
    }

    private void Attack(int damage)
    {
        if (enemy != null)
        {
            enemy.TakeDamage(damage);
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
        Debug.Log("Took" + damage +"damage!");
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
}
}
