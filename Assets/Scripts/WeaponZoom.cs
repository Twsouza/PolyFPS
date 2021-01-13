using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponZoom : MonoBehaviour
{
    [SerializeField] Camera fpsCamera;
    [SerializeField] float zoomedOutFOV = 60f;
    [SerializeField] float zoomedInFOV = 20f;

    bool zoomedInToogle = false;

    private void Update()
    {
        if (Input.GetMouseButtonDown(1))
        {
            zoomedInToogle = !zoomedInToogle;
            fpsCamera.fieldOfView = zoomedInToogle ? zoomedInFOV : zoomedOutFOV;
        }
    }
}
