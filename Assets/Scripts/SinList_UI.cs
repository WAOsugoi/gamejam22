using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SinList_UI : MonoBehaviour
{

     RectTransform transform;
     [SerializeField] float ListPullLength = 0.0f;
     [SerializeField] float slidespeed = 2.0f;

     bool isOut = false;

    void Awake()
    {
        transform = GetComponent<RectTransform>();
    }

    // Start is called before the first frame update
    void Start()
    { 
    }

    // // Update is called once per frame
    // void Update()
    // {
        
    // }

    public void pullOutList()
    {
        if (!isOut) 
        {
            Vector3 destination = transform.localPosition + (Vector3.right * ListPullLength);
            while(transform.localPosition != destination)
            {
            transform.localPosition += Vector3.right * slidespeed * Time.deltaTime;
            }
 
            isOut = (!isOut);
        }

        else
        {
            transform.localPosition += Vector3.left * ListPullLength;
            isOut = (!isOut);
        }

    }

}
