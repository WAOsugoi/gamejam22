using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject objectToBeSpawned;

    public void spawnObject()
    {
        var obj = Instantiate(objectToBeSpawned, transform.position, transform.rotation);
        obj.transform.parent = gameObject.transform.parent;
    }
}
