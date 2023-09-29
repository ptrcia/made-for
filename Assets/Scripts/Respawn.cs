using UnityEngine;
using UnityEngine.SceneManagement;

//Patricia Gracia Artero
//Free to use
public class RespawnScene : MonoBehaviour
{
    public Transform respawnPoint;
    public Transform player;

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player")) //If it is the player who falls, then: 
        {
            player.transform.position = respawnPoint.transform.position;
            player.transform.rotation = respawnPoint.transform.rotation;
        }
        //Debug.Log(other);
    }

}
