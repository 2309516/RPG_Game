using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthManager : MonoBehaviour
{

    public int maxHealth = 100;
    public int currentHealth;

    private void Start()
    {
        currentHealth = maxHealth;
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
