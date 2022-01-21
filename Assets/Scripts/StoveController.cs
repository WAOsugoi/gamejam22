using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StoveController : MonoBehaviour
{

    private bool isSpawnable;
    private GameObject spawner;

    // Start is called before the first frame update
    void Start()
    {
        spawner = GameObject.Find("Spawner");
        isSpawnable = true;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Q))
        {
            switchOn();
        }

        if (Input.GetKeyDown(KeyCode.W))
        {
            switchOff();
        }


    }

    private void switchOn()
    {
        Debug.Log("key q is pressed");
        GetComponent<Transform>().eulerAngles = new Vector3(0, 0, 135);
    }

    private void switchOff()
    {
        Debug.Log("key w is pressed");
        GetComponent<Transform>().eulerAngles = new Vector3(0, 0, 45);
    }

    private void spawnCat()
    {
        if (isSpawnable)
        {
            spawner.GetComponent<Spawner>().spawnObject();
            isSpawnable = false;
        }
    }

}
