using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameBoundaries : MonoBehaviour
{

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            FindObjectOfType<DeathHandler>().HandleDeath();
        }
    }
}
