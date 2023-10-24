using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AddForceObject : MonoBehaviour
{
    //Spawn the object with some force added
    [SerializeField] float force;
    [SerializeField] Rigidbody rb;
 
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
