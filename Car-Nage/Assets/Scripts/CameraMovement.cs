﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour
{
    public float ZoomSpeed;
    public float PanSpeed;
    public float PanBuffer = 50.0f;

    private Plane _Plane;
    void Start()
    {
        //_Plane = new Plane();
        _Plane = new Plane(Vector3.up, Vector3.zero);
       // Vector3 mapCenter = Map.Instance.Center; //16, 0, 16
        //transform.LookAt(mapCenter);
    }
    //Update is called once per frame
    void Update()
    {
        //HandleZoom();
        HandlePan();
    }

    private void HandlePan()
    {
        Vector2 mousePos = Input.mousePosition;
        /* Vector3 dRight = transform.right.XZ();
       Vector3 dUp = transform.up.XZ();

        if (mousePos.x < PanBuffer)
        {
            transform.position -= dRight * Time.fixedDeltaTime * PanSpeed;
        }
        else if (mousePos.x > Screen.width - PanBuffer)
        { transform.position += dRight * Time.fixedDeltaTime * PanSpeed; }
        if (mousePos.y < PanBuffer)
        { transform.position -= dUp * Time.fixedDeltaTime * PanSpeed; }
        else if (mousePos.y > Screen.height - PanBuffer)
        { transform.position -= dUp * Time.fixedDeltaTime * PanSpeed; }
        Debug.Log($"Mouse position: {mousePos}");
        transform.position -= transform.right * Time.fixedDeltaTime * PanSpeed; */
    }

    /* private void HandleZoom()
    {
        float scrollValue = Input.mouseScrollDelta.y;

        if (scrollValue != 0.0)
        {
            if (Input.GetKey(KeyCode.LeftControl))
            {
                //rotation
                Vector3 center = GetCenter();
                Vector3 dToCenter = transform.position - center;
                Vector3 angles = new Vector3(0, scrollValue, 0);
                Quaternion newRot = Quaternion.Euler(angles);
                Vector3 newDir = newRot * dToCenter;
                transform.position = center + newDir;
                transform.LookAt(center);


                //transform.forward = -dNew;
            }
            else
            {
                float newSize = Camera.main.orthographicSize - scrollValue;
                Camera.main.orthographicSize = Mathf.Clamp(newSize, 3.0f, 20.0f);
            }
        }
    } */
}

    /* private Vector3 GetCenter
    {
        Ray ray =  new Ray(transform.position, transform.forward);

    float distance = 0.0f;

    if (_Plane.Raycast(ray, out distance)){
        return ray.GetPoint(distance);
        }
return Vector3.zero;
    } */
