using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DontDestroy : MonoBehaviour
{
    //public GameObject music;
    void Awake()
    {
        DontDestroyOnLoad(this.gameObject);
    }
}
//puedo ponerle un if para destrtuirlo en algun momento concreto y ya i guess