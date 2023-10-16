using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

//Patricia Gracia Artero
//Free to use

public class IndependentMovement : MonoBehaviour
{
    [SerializeField] public float speedMovement = 10; //the velocity that takes to do the movement
    [SerializeField] float distanceDestination = 20;
    private Vector3 destination; //where i want the gameobject to be
    [SerializeField] bool right;
    [SerializeField] bool up;


    private void Start()
    {
        if (right)
        {
            destination = transform.position + Vector3.right * distanceDestination;
        }
        else if (up)
        {//tendria que hacer que el destination fuera mas a tomar por culo GGGGGGGGGGGGGGGG
            destination = transform.position + Vector3.up * distanceDestination;

        }
    }

    void Update()
    {  
        transform.Translate((destination - transform.position).normalized 
            * speedMovement
            * Time.deltaTime);
    }
}