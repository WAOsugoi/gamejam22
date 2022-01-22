using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//CatSinGenerator catsingen = GetComponent<CatSinGenerator>();


public class Cat_Behaviour : MonoBehaviour
{

    enum temp_state {frozen, cold, neutral, hot, boiling}

    public bool isBad = false;
    public bool isPoofed = false;

    public double temperature;
    temp_state temperature_state_flag;

    CatSinGenerator catsingen;
    SpriteRenderer sprite;

    public GameObject logicmanager_obj;
    GameLogicManager logicmanager;

    //placeholder
    Color frozen_col = new Color (0.0f,0.25f,0.75f,1.0f); 
    Color cold_col = new Color  (0.0f,0.75f,0.75f,1.0f);
    Color neutral_col = new Color (0.0f, 0.85f, 0.25f,1.0f);
    Color hot_col = new Color(0.5f, 0.5f,0.0f,1.0f);
    Color boil_col = new Color(0.75f, 0.75f,0.0f,1.0f);

    void Awake()
    {
        catsingen = GetComponent<CatSinGenerator>();
        sprite = GetComponent<SpriteRenderer>();

        logicmanager_obj = GameObject.Find("GameLogicManager");
        logicmanager = logicmanager_obj.GetComponent<GameLogicManager>();


    }

    // Start is called before the first frame update
    void Start()
    {
        //generates a random temperature
        temperature = (double)Random.Range(30, 70);
    
        //delays
        Invoke("checkDisposition", 0.5f);
 
 
    }

    void checkDisposition()
    {
        if (catsingen.goodDisposition < catsingen.badDisposition)
        {
            Debug.Log("called");
            isBad = true;
        }
    }


    // Update is called once per frame
    void Update()
    {
        RefreshTemperature();
    }

    void RefreshTemperature()
    {
        //checks for cat current temperature
        if (temperature < 0.0) 
        {
            temperature_state_flag = temp_state.frozen;
            sprite.color = frozen_col;
            isPoofed = true;
        }

        if ((temperature > 0.0) && (temperature <= 33.3)) 
        {
            temperature_state_flag = temp_state.cold;
            sprite.color = cold_col;
        }

        if ((temperature > 33.3) && (temperature <= 66.6)) 
        {
            temperature_state_flag = temp_state.neutral;
            sprite.color = neutral_col;
        }

        if ((temperature > 66.6) && (temperature <= 99.9))
        {
             temperature_state_flag = temp_state.hot;
             sprite.color = hot_col;
        }

        if (temperature > 100.0) 
        {
            temperature_state_flag = temp_state.boiling;
            sprite.color = boil_col;
            isPoofed = true;
        }

        
        if ((temperature_state_flag == temp_state.boiling) || (temperature_state_flag == temp_state.frozen))
        {
           if ((temperature_state_flag == temp_state.boiling) && (isBad == true)) {logicmanager.UpdateNumWrongJudgement();}
           else if ((temperature_state_flag == temp_state.frozen) && (isBad == false)) {logicmanager.UpdateNumWrongJudgement();}
           else {logicmanager.UpdateNumCorrectJudgement();}
        }
    }



}
