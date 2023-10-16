using UnityEngine;
using UnityEngine.SceneManagement;

//Patricia Gracia Artero
//Free to use
public class RespawnScene : MonoBehaviour
{
     [SerializeField]Transform respawnPoint;
     [SerializeField]GameObject player;

    private void Start()
    {
        //player = GameObject.FindGameObjectWithTag("Player");
    }
    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player")) 
        {
            player.transform.position = respawnPoint.transform.position;
            player.transform.rotation = respawnPoint.transform.rotation;
        }
    }

}
