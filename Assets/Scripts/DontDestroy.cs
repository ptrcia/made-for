using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
//Patricia Gracia Artero
//Free to use
public class DontDestroy : MonoBehaviour
{
    void Awake()
    {
        DontDestroyOnLoad(this.gameObject); //Method from Unity that prevents something to be deleted when the scene is changed
    }
    private void Start()
    {  
        if(SceneManager.GetActiveScene().name == "06-FinalRoom")
        {
            DestroyNow();
        }         
    }

    //This may be a way to stop the audio
    public void DestroyNow()
    {
        Destroy(this);
    }
}
