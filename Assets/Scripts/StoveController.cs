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
    private AudioManager am;

    private bool switchIsOn = false;

    [SerializeField]
    private double heatRate = 10; //default
    [SerializeField]
    private double coolRate = 8; //default

    [SerializeField]
    private GameObject stoveFire;

    public GameObject finishAnimation;


    private void Awake()
    {
        sr = GetComponent<SpriteRenderer>();
        logic = GameObject.Find("GameLogicManager");
        am = FindObjectOfType<AudioManager>();
        stoveFire.GetComponent<Renderer>().enabled = false;
        stoveFire.GetComponent<Animator>().enabled = false;
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

            if (cat.GetComponent<Cat_Behaviour>().isPoofed)
            {

                GameObject animation = Instantiate(finishAnimation) as GameObject;
                //animation.transform.position = cat.transform.position;
                animation.transform.position = new Vector3(cat.transform.position.x, cat.transform.position.y, -5);
                if (cat.GetComponent<Cat_Behaviour>().temperature_state_flag == Cat_Behaviour.temp_state.boiling)
                    animation.GetComponent<AscendOrDescend>().PlayAnimation(true);
                else
                    animation.GetComponent<AscendOrDescend>().PlayAnimation(false);
                Destroy(cat);
                if (logic.GetComponent<GameLogicManager>().AllowedToSpawn())
                {
                    isSpawnable = true;
                }
            }

            if (switchIsOn)
                incrTemp();
            else
                decrTemp();
        }
    }

    // Turn on fire and flip switch to ON position
    public void switchOn()
    {
        if (switchIsOn)
        {
            am.Play("SwitchFail");
        }
        else
        {
            am.Play("SwitchFire");
            am.Play("FireLoop");
        }

        switchIsOn = true;
        sr.flipX = false;

        stoveFire.GetComponent<Renderer>().enabled = true;
        stoveFire.GetComponent<Animator>().enabled = true;

    }

    // Turn off fire and flip switch to OFF position
    public void switchOff()
    {
        if (!switchIsOn)
        {
            am.Play("SwitchFail");
        }
        else
        {
            am.Play("SwitchFire");
            am.Stop("FireLoop");
        }

        switchIsOn = false;
        sr.flipX = true;

        stoveFire.GetComponent<Renderer>().enabled = false;
        stoveFire.GetComponent<Animator>().enabled = false;
    }

    // Spawn cat if there are still cats to judge and current pot is empty
    private void spawnCat()
    {
        isSpawnable = false;
        switchIsOn = false;

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