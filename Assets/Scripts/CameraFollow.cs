using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class CameraFollow : MonoBehaviour
{
    [SerializeField] Transform player;
    [SerializeField] Vector3 offset;
    [SerializeField] float smoothTargetTime;
    Vector3 dampVelocity;

    // Start is called before the first frame update
    void Start()
    {
        offset = transform.position - player.position;
    }

    // Update is called once per frame
    void Update()
    {
        //transform.position = Vector3.SmoothDamp(transform.position,
       //player.position + offset, ref dampVelocity, smoothTargetTime);

        Vector3 targetCamPos = player.position + offset;

        transform.position = Vector3.Lerp
          (transform.position, targetCamPos, smoothTargetTime + Time.deltaTime);

    }
}