using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Patricia Gracia Artero
//Free to use
public class AddForceObject : MonoBehaviour
{
    [SerializeField]
    float force;
    [SerializeField]
    Rigidbody rb;
 
    private void Awake()
    {
        rb = GetComponent<Rigidbody>();      
    }
    void Start()
    {
        AddForce();
    }

    void AddForce()
    {
        rb.AddForce(transform.right * force);
    }
}
