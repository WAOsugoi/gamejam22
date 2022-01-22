using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class stickynotespawner : MonoBehaviour
{

    public GameObject logicmanager_obj;
    GameLogicManager logicmanager;
    [SerializeField] GameObject stickynote;
    
    private int catCount = 0;

    Vector3 offset = new Vector3(30,30,30);

    // Start is called before the first frame update
    void Start()
    {
        logicmanager_obj = GameObject.Find("GameLogicManager");
        logicmanager = logicmanager_obj.GetComponent<GameLogicManager>();
        catCount = logicmanager.currentNumberOfCatsToBeJudged;


        Invoke("spawnNotes", 1.0f);


    }


    // Update is called once per frame
    void Update()
    {
        
    }

    void spawnNotes()
    {
        for (int i = 0; i < catCount; i++)
        {
            if (i < 3)
            {
                Debug.Log("Spawned");
                offset *= i;
                stickynote = Instantiate(stickynote, offset, Quaternion.Euler(-90, 0, 0)) as GameObject;
                stickynote.transform.localScale = new Vector3(1, 1, 1);
            }
        }
    }
}
