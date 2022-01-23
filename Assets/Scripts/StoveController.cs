using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StoveController : MonoBehaviour
{

    public bool isSpawnable;
    public Transform spawner;
    private GameObject logic;
    public GameObject cat;
    private SpriteRenderer sr;

    private bool switchIsOn = false;

    [SerializeField]
    private double heatRate = 10; //default
    [SerializeField]
    private double coolRate = 10; //default
    [SerializeField]
    private float coolingBuffer = 3;
    [SerializeField]
    private GameObject stoveFire;

    private void Awake()
    {
        sr = GetComponent<SpriteRenderer>();
        logic = GameObject.Find("GameLogicManager");
    }

    // Start is called before the first frame update
    void Start()
    {
        sr.flipX = true;
        isSpawnable = true;
    }

    // Update is called once per frame
    void Update()
    {
        if (cat)
        {
            spawnCat();
            if (cat.GetComponent<Cat_Behaviour>().isPoofed)
            {
                CancelInvoke();
                Destroy(cat);
            }
        }
    }

    // Turn on fire and flip switch to ON position
    public void switchOn()
    {
        CancelInvoke();
        switchIsOn = true;
        sr.flipX = false;
        InvokeRepeating("incrTemp", 0, 1);
        stoveFire.GetComponent<Renderer>().enabled = true;
        stoveFire.GetComponent<Animator>().enabled = true;

    }

    // Turn off fire and flip switch to OFF position
    public void switchOff()
    {
        CancelInvoke();
        switchIsOn = false;
        sr.flipX = true;
        InvokeRepeating("decrTemp", 0, 1);
        stoveFire.GetComponent<Renderer>().enabled = false;
        stoveFire.GetComponent<Animator>().enabled = false;
    }

    // Spawn cat if there are still cats to judge and current pot is empty
    private void spawnCat()
    {
        isSpawnable = false;
        InvokeRepeating("decrTemp", coolingBuffer, 1);
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
