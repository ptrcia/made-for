using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnObjects : MonoBehaviour
{
    //This script creates clones of the prefabs I choose,
    //and spawns them in the position and rotation of the transform i also choose.
    [SerializeField] GameObject prefab;
    [SerializeField] Transform transformChild;

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
        GameObject prefabClone = Instantiate(prefab, transformChild.position, transform.rotation);
        Invoke("CreateObjects", Random.Range(2f, 4f));
    }

}

