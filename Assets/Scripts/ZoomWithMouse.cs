using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Zoom forward and backward with mousewheel, Attach this script to camera
public class ZoomWithMouse : MonoBehaviour
{
    public float zoomSpeed = 20f;
    public float fovMin = 3f, fovMax = 150f;
    private float zoom = 10;
    private float camFov = 90f;


    private void Start()
    {
        
    }

    void Update()
    {
        
        zoom = zoom - (zoomSpeed * Input.GetAxis("Mouse ScrollWheel"));
        camFov = Mathf.Clamp(zoom, fovMin, fovMax);
        Debug.Log(camFov);

        Camera.main.fieldOfView = camFov;
    }
}