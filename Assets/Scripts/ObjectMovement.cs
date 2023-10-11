using System.Collections;
using System.Collections.Generic;
using UnityEngine;


//Patricia Gracia Artero
//Free to use
public class ObjectMovement : MonoBehaviour
{
    [SerializeField]
    private float speed = 1;
    void Start()
    {
        
    }

    void Update()
    {
        transform.Translate(Vector3.left * speed);
    }
}
