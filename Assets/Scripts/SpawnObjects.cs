using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnObjects : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject prefab;
    public Transform transformChild;
    //public float force = 5;
    public float speed = 5;


    void Start()
    {
        Invoke("CreateObjects", Random.Range(2f, 4f));
    }

    // Update is called once per frame
    void Update()
    {

         //CreateObjects();

    }

    void CreateObjects()
    {
        GameObject prefabClone = Instantiate(prefab, transformChild.position, transformChild.rotation);

        prefabClone.transform.Translate(Vector3.forward * speed * Time.deltaTime);

        Destroy(prefabClone, 5);
        Invoke("CreateObjects", Random.Range(2f, 4f));

    }
}

