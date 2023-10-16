
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SimpleCarMovement : MonoBehaviour
{
    public float speed = 10.0f; // Car speed
    public float turnSpeed = 100.0f; // Turning speed

    void Update()
    {
        float verticalMovement = Input.GetAxis("Vertical"); // Vertical axis (W or S or arrow keys up/down)
        float horizontalMovement = Input.GetAxis("Horizontal"); // Horizontal axis (A or D or arrow keys left/right)

        // Calculate the translation based on keyboard input
        float verticalTranslation = verticalMovement * speed * Time.deltaTime;
        float horizontalRotation = horizontalMovement * turnSpeed * Time.deltaTime;

        // Apply vertical movement to the car
        transform.Translate(Vector3.forward * verticalTranslation);

        // Apply horizontal rotation to the car
        transform.Rotate(Vector3.up * horizontalRotation);
    }
}