using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    [SerializeField] float playerHealth = 100f;

    public void TakeDamage(float damage)
    {
        Debug.Log("I've been hit");

        playerHealth -= damage;

        if (playerHealth <= 0)
        {
            GetComponent<DeathHandler>().HandleDeath();
        }
    }
}
