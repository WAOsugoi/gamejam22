using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StoveController : MonoBehaviour
{

    private bool isSpawnable;
    private GameObject spawner;
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
        spawner = GameObject.Find("Spawner");
        logic = GameObject.Find("GameLogicManager");
        isSpawnable = true;
    }

    // Update is called once per frame
    void Update()
    {
        if (GameObject.FindWithTag("CatObject") == null)
        {
            isSpawnable = true;
        }

        spawnCat();

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
        InvokeRepeating("incrTemp", 0, 1);

    }

    // Turn off fire and flip switch to OFF position
    public void switchOff()
    {
        CancelInvoke();
        switchIsOn = false;
        GetComponent<Transform>().eulerAngles = new Vector3(0, 0, 45);
        InvokeRepeating("decrTemp", 0, 0.5f);
    }

    // Spawn cat if cat was judged and current pot is empty
    private void spawnCat()
    {
        if (logic.GetComponent<GameLogicManager>().AllowedToSpawn() && isSpawnable)
        {
            spawner.GetComponent<Spawner>().spawnObject();
            cat = GameObject.FindWithTag("CatObject");
            isSpawnable = false;
            InvokeRepeating("decrTemp", coolingBuffer, 0.5f);
        }
    }

    private void incrTemp()
    {
        cat.GetComponent<Cat_Behaviour>().temperature += heatRate * Time.deltaTime;
        Debug.Log(cat.GetComponent<Cat_Behaviour>().temperature);
    }

    private void decrTemp()
    {
        cat.GetComponent<Cat_Behaviour>().temperature -= coolRate * Time.deltaTime;
        Debug.Log(cat.GetComponent<Cat_Behaviour>().temperature);
    }


}
