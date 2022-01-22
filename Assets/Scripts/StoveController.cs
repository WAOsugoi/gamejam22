using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StoveController : MonoBehaviour
{

    private bool isSpawnable;
    public Transform spawner;
    private GameObject logic;
    private GameObject cat;

    private bool switchIsOn = false;

    [SerializeField]
    private double heatRate = 1500; //default
    [SerializeField]
    private double coolRate = 1500; //default
    [SerializeField]
    private float coolingBuffer = 3;

    // Start is called before the first frame update
    void Start()
    {
        //spawner = gameObject.transform.FindChild("Spawner");
        logic = GameObject.Find("GameLogicManager");
        isSpawnable = true;
    }

    // Update is called once per frame
    void Update()
    {
        if (!cat)
        {
            spawnCat();
            isSpawnable = false;
        }

        if (cat.GetComponent<Cat_Behaviour>().isPoofed)
        {
            CancelInvoke();
        }
    }

    // Turn on fire and flip switch to ON position
    public void switchOn()
    {
        CancelInvoke();
        switchIsOn = true;
        GetComponent<Transform>().eulerAngles = new Vector3(0, 0, 135);
        InvokeRepeating("incrTemp", 0, 0.5f);

    }

    // Turn off fire and flip switch to OFF position
    public void switchOff()
    {
        CancelInvoke();
        switchIsOn = false;
        GetComponent<Transform>().eulerAngles = new Vector3(0, 0, 45);
        InvokeRepeating("decrTemp", 0, 0.5f);
    }

    // Spawn cat if there are still cats to judge and current pot is empty
    private void spawnCat()
    {
        if (logic.GetComponent<GameLogicManager>().AllowedToSpawn() && isSpawnable)
        {
            cat = spawner.GetComponent<Spawner>().spawnObject();    // Spawn cat object
            logic.GetComponent<GameLogicManager>().SpawnCatIfAllowed(); // Total cat count - 1
            isSpawnable = false;
            InvokeRepeating("decrTemp", coolingBuffer, 0.5f);
        }
    }

    private void incrTemp()
    {
        cat.GetComponent<Cat_Behaviour>().temperature += heatRate * Time.deltaTime;
        //Debug.Log("Temperature is: " + cat.GetComponent<Cat_Behaviour>().temperature);
    }

    private void decrTemp()
    {
        cat.GetComponent<Cat_Behaviour>().temperature -= coolRate * Time.deltaTime;
        //Debug.Log("Temperature is: " + cat.GetComponent<Cat_Behaviour>().temperature);
    }


}
