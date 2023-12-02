using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurretControl : MonoBehaviour
{
    // This script allows the user to rotate the turret,
    // and raise and lower the barrel elevation.
    public Transform barrel;
    public float min = -30;
    public float max = 30;
    public float movementSpeed = 100.0f;

    float elevation = 0;

    void Update()
    {
        // horizontal rotation control
        transform.Rotate(0, Input.GetAxis("Horizontal"), 0);

        // barrel elevation control
        float v = Input.GetAxis("Vertical");
        elevation = Mathf.Clamp(elevation+v,min,max);
        barrel.localRotation = Quaternion.Euler(elevation,0,0);
        MovePlayer();
    }
     void MovePlayer()

    {

        float mouseX = Input.GetAxis("Mouse X");

        float mouseY = Input.GetAxis("Mouse Y");

 

        // Move the player along the x-axis and z-axis based on mouse input

        Vector3 movement = new Vector3(mouseX * movementSpeed * Time.deltaTime, 0f, mouseY * movementSpeed * Time.deltaTime);

        transform.Translate(movement);

    }
}