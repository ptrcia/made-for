using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class OnCollision : MonoBehaviour
{
    public Collider objectCollider;
    public UnityEvent action;
    // Start is called before the first frame update
    void Awake()
    {
        objectCollider = GetComponent<Collider>();
    }

    // Update is called once per frame
    void Update()
    {
        if (objectCollider.isTrigger == true)
        {
            action.Invoke();
        }
   
    }
}
