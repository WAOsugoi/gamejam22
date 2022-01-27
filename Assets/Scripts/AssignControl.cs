using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AssignControl : MonoBehaviour
{
    private GameObject stove1;
    private GameObject stove2;
    private GameObject stove3;
    private GameObject stove4;


    // Start is called before the first frame update
    void Start()
    {
        stove1 = GameObject.FindWithTag("Stove 1");
        stove2 = GameObject.FindWithTag("Stove 2");
        stove3 = GameObject.FindWithTag("Stove 3");
        stove4 = GameObject.FindWithTag("Stove 4");
    }

    // Update is called once per frame
    void Update()
    {
        if (stove1)
        {
            if (Input.GetKeyDown("q"))
            {
                stove1.GetComponent<StoveController>().switchOn();
            }
            if (Input.GetKeyDown("w"))
            {
                stove1.GetComponent<StoveController>().switchOff();
            }
        }

        if (stove2)
        {
            if (Input.GetKeyDown("e"))
            {
                stove2.GetComponent<StoveController>().switchOn();
            }
            if (Input.GetKeyDown("r"))
            {
                stove2.GetComponent<StoveController>().switchOff();
            }
        }

        if (stove3)
        {
            if (Input.GetKeyDown("a"))
            {
                stove3.GetComponent<StoveController>().switchOn();
            }
            if (Input.GetKeyDown("s"))
            {
                stove3.GetComponent<StoveController>().switchOff();
            }
        }

        if (stove4)
        {
            if (Input.GetKeyDown("d"))
            {
                stove4.GetComponent<StoveController>().switchOn();
            }
            if (Input.GetKeyDown("f"))
            {
                stove4.GetComponent<StoveController>().switchOff();
            }
        }

    }
}
