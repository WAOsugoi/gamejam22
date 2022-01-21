using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject objectToBeSpawned;

    public void spawnObject()
    {
        Instantiate(objectToBeSpawned, transform.position, transform.rotation);
    }
}
