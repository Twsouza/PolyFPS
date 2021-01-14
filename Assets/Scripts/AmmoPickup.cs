using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AmmoPickup : MonoBehaviour
{
    [SerializeField] AmmoType type;
    [SerializeField] int amount;

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("Triggered");
        if (other.gameObject.tag == "Player")
        {
            Debug.Log("Object Player");

            FindObjectOfType<Ammo>().IncreaseAmmo(type, amount);
            Destroy(gameObject);
        }
    }
}
