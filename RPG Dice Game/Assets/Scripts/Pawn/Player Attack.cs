using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DiceNS;
using EnemyNS;

public class PlayerAttack : MonoBehaviour
{
    public int Pierce;
    public int Slash;
    public int Cleave;
    public EnemyNS.Enemy enemy;

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
        }
    }   
    private int RollDice(int sides)
    {
        return Random.Range(1, sides+1);
    }
}
