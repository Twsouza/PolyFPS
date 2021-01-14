using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum ObjectiveType
{
    ScrewDriver,
    Wirecutter,
    Wrench
}

public class Objective : MonoBehaviour
{
    [SerializeField] CompletedObjectives[] objectives;
    [SerializeField] Canvas gameFinished;

    [System.Serializable]
    private class CompletedObjectives
    {
        public ObjectiveType objective;
        public bool completed;
    }

    private void Start()
    {
        gameFinished.enabled = false;
    }

    public void SetObjectiveCompleted(ObjectiveType newObjective)
    {
        foreach (CompletedObjectives objective in objectives)
        {
            if (objective.objective == newObjective)
            {
                objective.completed = true;
                return;
            }
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player" && IsObjectivesCompleted())
        {
            GameFinished();
        }
    }

    private bool IsObjectivesCompleted()
    {
        foreach (CompletedObjectives objective in objectives)
        {
            if (!objective.completed)
            {
                return false;
            }
        }

        return true;
    }

    public void GameFinished()
    {
        gameFinished.enabled = true;
        Time.timeScale = 0;
        FindObjectOfType<WeaponSwitcher>().enabled = false;
        Cursor.visible = true;
        Cursor.lockState = CursorLockMode.None;
    }
}
