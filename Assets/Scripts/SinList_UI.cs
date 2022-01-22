using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SinList_UI : MonoBehaviour
{

     RectTransform transform;
     [SerializeField] float ListPullLength = 0.0f;
     [SerializeField] float slidespeed = 150.0f;

     bool isOut = false;

    private int catsThisFrame;
    private int catsLastFrame;

    public GameObject logicmanager_obj;
    GameLogicManager logicmanager;

    private Vector3 buttonVelocity = Vector3.zero;

        Vector3 original_pos;
        Vector3 newPos;

    void Awake()
    {
        transform = GetComponent<RectTransform>();
        
        logicmanager_obj = GameObject.Find("GameLogicManager");
        logicmanager = logicmanager_obj.GetComponent<GameLogicManager>();
    }

    // Start is called before the first frame update
    void Start()
    { 
         original_pos = transform.localPosition;
         newPos = Vector3.right * ListPullLength;
    }

    // Update is called once per frame
    void Update()
    {
        //Debug.Log(catsThisFrame);

        if ((isOut) && (transform.localPosition.x !< -693))
        {
            transform.localPosition += Vector3.right * Time.deltaTime *slidespeed;
        }

        if ((!isOut) && (transform.localPosition.x !> -1070))
        {
            transform.localPosition += Vector3.left * Time.deltaTime * slidespeed;
        }


    }

    public void pullOutList()
    {
        isOut = (!isOut);
    }

    void CheckForMoreCats()
    {

    }


    

}
