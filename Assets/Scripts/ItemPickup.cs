using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ItemPickup : MonoBehaviour
{
    [SerializeField] ObjectiveType objective;
    [SerializeField] TextMeshProUGUI objectiveText;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            objectiveText.color = Color.green;
            FindObjectOfType<Objective>().SetObjectiveCompleted(objective);
            Destroy(gameObject);
        }
    }
}
