using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BatteryPickup : MonoBehaviour
{
    [SerializeField] float restoreAngle = 50f;
    [SerializeField] float addIntensity = 1f;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            FlashLightSystem flash = other.GetComponentInChildren<FlashLightSystem>();
            flash.RestoreLightAngle(restoreAngle);
            flash.AddLightIntensity(addIntensity);
            Destroy(gameObject);
        }
    }
}
