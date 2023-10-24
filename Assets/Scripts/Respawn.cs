using UnityEngine;
using UnityEngine.SceneManagement;

//Respawn the player in the position I choose
//when it collision with the gameObject this is attached to
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
