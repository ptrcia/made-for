using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

//When the swich rotates, like when a normal switch is pressed, things happen.

public class Switch : MonoBehaviour
{
    Transform switchButton;
    [SerializeField] UnityEvent pressSwitch;
    float rotX;

    void Start()
    {
        switchButton = GetComponent<Transform>();
    }
    void Update()
    {
        rotX = switchButton.transform.rotation.eulerAngles.x; 
        //Debug.Log(rotX);
        if(rotX  > 300)
        {
            pressSwitch.Invoke();
            //canvasCam.SetActive = true;
            //switch.gameObject.SetActive = true;
            //hospitalAudio.Stop();
        }
    }
}
