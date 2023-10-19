using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

//Patricia Gracia Artero
//Free to use
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
