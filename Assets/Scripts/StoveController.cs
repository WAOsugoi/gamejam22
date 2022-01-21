using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StoveController : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

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

    void switchOn()
    {
        Debug.Log("key q is pressed");
        GetComponent<Transform>().eulerAngles = new Vector3(0, 0, 135);
    }

    void switchOff()
    {
        Debug.Log("key w is pressed");
        GetComponent<Transform>().eulerAngles = new Vector3(0, 0, 45);
    }


}
