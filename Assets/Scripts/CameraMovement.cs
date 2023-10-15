using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Patricia Gracia Artero
//Free to use

public class CameraMovement : MonoBehaviour
{
    [SerializeField]
    public float speedMovement = 5.0f;
    [SerializeField]
    public float speedRotation = 30.0f;
    private Transform cameraTransform;
    private Vector3 puntoY;
    private void Start()
    {
        puntoY = transform.position + Vector3.right * 10.0f;
    }

    void Update()
    {
        // Mueve el objeto hacia el punto Y a la velocidad especificada.
        transform.Translate((puntoY - transform.position).normalized 
            * speedMovement
            * Time.deltaTime);
    }
}
