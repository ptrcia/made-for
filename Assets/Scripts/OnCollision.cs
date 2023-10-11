using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

//Patricia Gracia Artero
//Free to use
public class OnCollision : MonoBehaviour
{
    [SerializeField]
    private Collider objectCollider;
    [SerializeField]
    private UnityEvent action;
    void Awake()
    {
        objectCollider = GetComponent<Collider>();
    }

    void Update()
    {
        if (objectCollider.isTrigger == true)
        {
            action.Invoke();
        }
   
    }
}
