using UnityEngine;
using UnityEngine.SceneManagement;

//Patricia Gracia Artero
//Free to use
public class RespawnScene : MonoBehaviour
{
    public int scene;

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player")) //If it is the player who falls, then: 
        {
            //MenuController.LoadScene(scene); //¿como decirle que me vuelva a cargar el misma escena en la que estoy?
        }
        //Debug.Log(other);
    }


}
