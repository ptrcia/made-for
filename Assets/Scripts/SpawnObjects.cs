using System.Collections;
using System.Collections.Generic;
using UnityEngine;


//Patricia Gracia Artero
//Free to use
public class SpawnObjects : MonoBehaviour
{
    [SerializeField]
    private GameObject prefab;
    [SerializeField]
    private Transform transformChild;

    void Start()
    {
        Invoke("CreateObjects", Random.Range(2f, 4f));
    }

    void Update()
    {
         //CreateObjects();
    }

    void CreateObjects()
    {
        Quaternion rotation = Quaternion.Euler(
                Random.Range(0, 360),
                Random.Range(0, 360),
                Random.Range(0, 360));
        GameObject prefabClone = Instantiate(prefab, transformChild.position, transform.rotation);

        Invoke("CreateObjects", Random.Range(2f, 4f));
    }

}

