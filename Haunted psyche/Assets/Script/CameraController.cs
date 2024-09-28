using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController: MonoBehaviour
{
    int sensitivity;
    float horizontal;
    float vertical;
    float xRotation;
    float yRotation;
    [SerializeField] Transform orientation;
    void Start()
    {
        sensitivity = 200;
        xRotation = 0f;
        yRotation = 0f;
        Cursor.visible = true;
        Cursor.lockState = CursorLockMode.Locked;
    }

    public void Look() 
    {
        horizontal = Input.GetAxisRaw("Mouse X") * Time.deltaTime * sensitivity;
        vertical = Input.GetAxisRaw("Mouse Y") * Time.deltaTime * sensitivity;

        yRotation += horizontal;
        xRotation -= vertical;
        xRotation = Mathf.Clamp(xRotation, -90f, 90f);

        
        transform.rotation = Quaternion.Euler(0f, yRotation, 0f);
        orientation.transform.rotation = Quaternion.Euler(xRotation, yRotation, 0f);
    }
}
