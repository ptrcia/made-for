using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

//Patricia Gracia Artero
//Free to use
public class Switch : MonoBehaviour
{
    [SerializeField]
    Transform switchButton;
    [SerializeField]
    private UnityEvent pressSwitch;
    float rotX;

    void Start()
    {
        switchButton = GetComponent<Transform>();
        //rotX = switchButton.transform.rotation.eulerAngles.x; //i didnt understand why i wasnt getting the right mesurements
    }


    void Update()
    {
        rotX = switchButton.transform.rotation.eulerAngles.x; //i was because it must be on the update (duh!A)
        //Debug.Log(rotX);
        if(rotX  > 300)
        {
            pressSwitch.Invoke();
        }
    }
}
