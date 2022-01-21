using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject spawnObject;
    // Start is called before the first frame update
    void Start()
    {
        Instantiate(spawnObject, transform.position, transform.rotation);
    }

    // Update is called once per frame
    void Update()
    {

    }
}
