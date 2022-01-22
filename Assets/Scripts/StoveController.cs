using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StoveController : MonoBehaviour
{

    private bool isSpawnable;
    private GameObject spawner;
    private GameObject logic;

    private bool switchIsOn = false;

    [SerializeField]
    private double heatRate = 10;

    // Start is called before the first frame update
    void Start()
    {
        spawner = GameObject.Find("Spawner");
        logic = GameObject.Find("GameLogicManager");
        //cat = GameObject.FindWithTag("CatObject");
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

        if (GameObject.FindWithTag("CatObject") == null)
        {
            isSpawnable = true;
        }

        if (switchIsOn)
        {
            incrTemp();
        }

        spawnCat();

    }

    // Turn on fire and flip switch to ON position
    private void switchOn()
    {
        switchIsOn = true;
        GetComponent<Transform>().eulerAngles = new Vector3(0, 0, 135);
    }

    // Turn off fire and flip switch to OFF position
    private void switchOff()
    {
        switchIsOn = false;
        GetComponent<Transform>().eulerAngles = new Vector3(0, 0, 45);
    }

    // Spawn cat if cat was judged and current pot is empty
    private void spawnCat()
    {
        if (logic.GetComponent<GameLogicManager>().AllowedToSpawn() && isSpawnable)
        {
            spawner.GetComponent<Spawner>().spawnObject();
            isSpawnable = false;
        }
    }

    private void incrTemp()
    {
        GameObject.FindWithTag("CatObject").GetComponent<Cat_Behaviour>().temperature += heatRate * Time.deltaTime;
        Debug.Log(GameObject.FindWithTag("CatObject").GetComponent<Cat_Behaviour>().temperature);
    }
}
