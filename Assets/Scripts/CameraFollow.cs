using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Follow the player smooooth

public class CameraFollow : MonoBehaviour
{
    [SerializeField] Transform player;
    [SerializeField] Vector3 offset;
    [SerializeField] float smoothTargetTime;
    //Vector3 dampVelocity;

    void Start()
    {
        offset = transform.position - player.position;
    }
    void Update()
    {
        //transform.position = Vector3.SmoothDamp(transform.position,
       //player.position + offset, ref dampVelocity, smoothTargetTime);

        Vector3 targetCamPos = player.position + offset;

        transform.position = Vector3.Lerp
          (transform.position, targetCamPos, smoothTargetTime + Time.deltaTime);

    }
}