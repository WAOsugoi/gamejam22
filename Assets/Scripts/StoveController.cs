using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StoveController : MonoBehaviour
{

    private bool isSpawnable;
    private GameObject spawner;
    private GameObject logic;

    // Start is called before the first frame update
    void Start()
    {
        spawner = GameObject.Find("Spawner");
        logic = GameObject.Find("GameLogicManager");
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

        spawnCat();

    }

    // Turn on fire and flip switch to ON position
    private void switchOn()
    {
        // add line to increase temperature
        GetComponent<Transform>().eulerAngles = new Vector3(0, 0, 135);
    }

    // Turn off fire and flip switch to OFF position
    private void switchOff()
    {
        // add line to decrease temperature
        GetComponent<Transform>().eulerAngles = new Vector3(0, 0, 45);
    }

    // Spawn cat if cat was judged and current pot is empty
    private void spawnCat()
    {
        if (logic.GetComponent<GameLogicManager>().AllowedToSpawn() && GameObject.FindWithTag("CatObject") == null)
        {
            spawner.GetComponent<Spawner>().spawnObject();
            isSpawnable = false;
        }
    }

}
