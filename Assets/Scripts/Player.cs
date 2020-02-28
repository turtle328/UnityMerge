using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    const string k_MOUSE_X = "Mouse X";
    const string k_MOUSE_Y = "Mouse Y";

    [SerializeField]
    float sensitivity = 10f;

    Vector2 currentRotation;

    void Update()
    {
        currentRotation.x += Input.GetAxis(k_MOUSE_X) * sensitivity;
        currentRotation.y -= Input.GetAxis(k_MOUSE_Y) * sensitivity;

        currentRotation.x = Mathf.Repeat(currentRotation.x, 360);

        Camera.main.transform.rotation = Quaternion.Euler(currentRotation.y, currentRotation.x, 0);
    }
}
