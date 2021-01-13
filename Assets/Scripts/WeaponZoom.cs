using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.Characters.FirstPerson;

public class WeaponZoom : MonoBehaviour
{
    [SerializeField] float zoomedOutFOV = 60f;
    [SerializeField] float zoomedInFOV = 20f;
    [SerializeField] float zoomedOutSensitivity = 2f;
    [SerializeField] float zoomedInSensitivity = .5f;
    [SerializeField] RigidbodyFirstPersonController fpsController;

    bool zoomedInToogle = false;

    private void Update()
    {
        if (Input.GetMouseButtonDown(1))
        {
            zoomedInToogle = !zoomedInToogle;
            if (zoomedInToogle)
            {
                ZoomIn();
            }
            else
            {
                ZoomOut();
            }
        }
    }

    public void ZoomOut()
    {
        Camera.main.fieldOfView = zoomedOutFOV;
        fpsController.mouseLook.XSensitivity = zoomedOutSensitivity;
        fpsController.mouseLook.YSensitivity = zoomedOutSensitivity;
    }

    private void ZoomIn()
    {
        Camera.main.fieldOfView = zoomedInFOV;
        fpsController.mouseLook.XSensitivity = zoomedInSensitivity;
        fpsController.mouseLook.YSensitivity = zoomedInSensitivity;
    }
}
