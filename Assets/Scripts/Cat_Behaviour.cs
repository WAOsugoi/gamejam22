using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//CatSinGenerator catsingen = GetComponent<CatSinGenerator>();


public class Cat_Behaviour : MonoBehaviour
{

    enum temp_state {frozen, cold, neutral, hot, boiling}

    public bool isBad = false;

    public double temperature;
    temp_state temperature_state_flag;

    CatSinGenerator catsingen;


    public GameObject logicmanager_obj;
    GameLogicManager logicmanager;



    void Awake()
    {
        catsingen = GetComponent<CatSinGenerator>();
        logicmanager_obj = GameObject.Find("GameLogicManager");
        logicmanager = logicmanager_obj.GetComponent<GameLogicManager>();

    }

    // Start is called before the first frame update
    void Start()
    {
        
        temperature = (double)Random.Range(30, 70);
        RefreshTemperature();
    
        //checks if cat is good or bad internally        
        if (catsingen.goodDisposition < catsingen.badDisposition)
        {
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
        if (temperature == 0.0) {temperature_state_flag = temp_state.frozen;}
        if ((temperature > 0.0) && (temperature <= 33.3)) {temperature_state_flag = temp_state.cold;}
        if ((temperature > 33.3) && (temperature <= 66.6)) {temperature_state_flag = temp_state.neutral;}
        if ((temperature > 66.6) && (temperature <= 99.9)) {temperature_state_flag = temp_state.hot;}
        else {temperature_state_flag = temp_state.boiling;}

        if ((temperature_state_flag == temp_state.boiling) || (temperature_state_flag == temp_state.frozen))
        {
           if ((temperature_state_flag == temp_state.boiling) && (isBad == true)) {logicmanager.UpdateNumWrongJudgement();}
           else if ((temperature_state_flag == temp_state.frozen) && (isBad == false)) {logicmanager.UpdateNumWrongJudgement();}
           else {logicmanager.UpdateNumCorrectJudgement();}
        }
    }



}
