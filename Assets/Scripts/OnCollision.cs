using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

//I can told to do whatever when collisioned

public class OnCollision : MonoBehaviour
{
    private Collider objectCollider;
    [SerializeField]
    private UnityEvent action;
    void Awake()
    {
        objectCollider = GetComponent<Collider>();
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            //Debug.Log("Player has collisioned");
            action.Invoke();
        }
    }
}
