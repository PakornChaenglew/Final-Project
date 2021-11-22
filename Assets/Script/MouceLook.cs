using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouceLook : MonoBehaviour
{
    public float mouseSensitivity = 100f;
    public Transform playerBody;
    public bool islooking = false;
    float xRotation = 0f;


    void Update()
    {   
        if(islooking)
        {
            float mouseX = Input.GetAxis("Mouse X") * mouseSensitivity * Time.deltaTime;
            float mouseY = Input.GetAxis("Mouse Y") * mouseSensitivity * Time.deltaTime;

            xRotation -= mouseY;
            xRotation = Mathf.Clamp(xRotation, -90f, 90f);

            transform.localRotation = Quaternion.Euler(xRotation, 0f, 0f);
            playerBody.Rotate(Vector3.up * mouseX);
        }
    }
}
