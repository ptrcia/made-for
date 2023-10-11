using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//Patricia Gracia Artero
//Free to use
public class DontDestroy : MonoBehaviour
{
    void Awake()
    {
        DontDestroyOnLoad(this.gameObject); //Method from Unity that prevents something to be deleted when hthe scene is changed
    }
    private void Start()
    {  /*
        if(something happens I don't know what now)
        {
            DestroyNow();
        }
         */
    }

    //This may be a way to stop the audio
    public void DestroyNow()
    {
        Destroy(this);
    }
}
