using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mouselook : MonoBehaviour
{
    public Transform playerBody;
    public float mouseSensivity = 620f;
    float xRotation = 0f;
    public bool ButtonI;
    public bool CursorMouse = true;
    
    // Start is called before the first frame update
    void Start()

    {
        Cursor.lockState = CursorLockMode.Locked;
    }

    // Update is called once per frame
    void Update()
    {
       
            if (Input.GetKeyDown(KeyCode.I))
            {
                ButtonI = !ButtonI;
                if (ButtonI)
                {
                mouseSensivity = 0f;
                Cursor.lockState = CursorLockMode.None;
            }
                else
                {
                mouseSensivity = 620f;
                Cursor.lockState = CursorLockMode.Locked;
            }
            }
            float mouseX = Input.GetAxis("Mouse X") * mouseSensivity * Time.deltaTime; 
        float mouseY = Input.GetAxis("Mouse Y") * mouseSensivity * Time.deltaTime;

        xRotation -= mouseY;
        xRotation = Mathf.Clamp(xRotation, -90f, 90f);

        transform.localRotation = Quaternion.Euler(xRotation, 0f, 0f);
        playerBody.Rotate(Vector3.up * mouseX);
    }
}