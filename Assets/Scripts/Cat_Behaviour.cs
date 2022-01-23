using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Cat_Behaviour : MonoBehaviour
{

    public enum temp_state { frozen, cold, neutral, hot, boiling }

    public double temperature;
    public GameObject logicmanager_obj;
    public GameObject sinlist_obj;
    public temp_state temperature_state_flag;
    public GameObject catbuttonprefab;
    private bool writing = false;

    private AudioManager am;

    public bool isBad = false;
    public bool isPoofed = false;

    TextMeshProUGUI tmpro;
    GameLogicManager logicmanager;
    CatSinGenerator catsingen;
    SpriteRenderer sprite;
    GameObject canvas;
    ParticleSystem particles;

    SinList_UI sinlistui;


    RectTransform rectTransform;

    List<string> generated_sins;

    //placeholder


    void Awake()
    {
        catsingen = GetComponent<CatSinGenerator>();
        sprite = GetComponent<SpriteRenderer>();


        logicmanager_obj = GameObject.Find("GameLogicManager");
        logicmanager = logicmanager_obj.GetComponent<GameLogicManager>();

        sinlist_obj = GameObject.FindWithTag("SinList");
        tmpro = sinlist_obj.GetComponent<TextMeshProUGUI>();

        rectTransform = transform.GetComponent<RectTransform>();
        sinlistui = sinlist_obj.GetComponent<SinList_UI>();

        canvas = GameObject.Find("Canvas");


        generated_sins = catsingen.GeneratedSins;

        am = FindObjectOfType<AudioManager>();
    }

    // Start is called before the first frame update
    void Start()
    {

        temperature = (double)Random.Range(50, 55);


        //delays
        Invoke("checkDisposition", 0.5f);

        //Invoke("DrawListText", 0.1f);
    }

    void checkDisposition()
    {
        if (catsingen.goodDisposition < catsingen.badDisposition)
        {
            isBad = true;
        }
    }

    // Update is called once per frame
    void Update()
    {
        RefreshTemperature();
        kettleWhistle();
        catEndState();

    }

    void RefreshTemperature()
    {
        //checks for cat current temperature
        if (temperature < 0.0)
        {
            temperature_state_flag = temp_state.frozen;
            isPoofed = true;
        }

        if ((temperature > 0.0) && (temperature <= 33.3))
        {
            temperature_state_flag = temp_state.cold;
        }

        if ((temperature > 33.3) && (temperature <= 66.6))
        {
            temperature_state_flag = temp_state.neutral;
        }

        if ((temperature > 66.6) && (temperature <= 99.9))
        {
            temperature_state_flag = temp_state.hot;
        }

        if (temperature > 100.0)
        {
            temperature_state_flag = temp_state.boiling;
            isPoofed = true;
        }


        if ((temperature_state_flag == temp_state.boiling) || (temperature_state_flag == temp_state.frozen))
        {
            if ((temperature_state_flag == temp_state.boiling) && (isBad == true)) { logicmanager.UpdateNumWrongJudgement(); }
            else if ((temperature_state_flag == temp_state.frozen) && (isBad == false)) { logicmanager.UpdateNumWrongJudgement(); }
            else { logicmanager.UpdateNumCorrectJudgement(); }
        }
    }



    private void kettleWhistle()
    {

        if (temperature > 66.6)
        {
            am.Play("KettleWhistle");
        }
        if (isPoofed || temperature < 66.6)
        {
            am.Stop("KettleWhistle");
        }
        float vol = (float)((temperature - 66.6) / 33.4);
        am.Volume("KettleWhistle", vol);
    }

    private void catEndState()
    {
        if (temperature_state_flag == temp_state.frozen)
        {
            am.Play("CatFreeze");
            am.PlayNya();
        }
        else if (temperature_state_flag == temp_state.boiling)
        {
            am.Play("CatPop");
            am.PlayNya();
        }
    }

    private void DrawListText()
    {
        tmpro.text = string.Empty;  //clear the string once when called
        string NewSinList = string.Empty;
        for (int i = 0; i < generated_sins.Count; i++)
        {
            NewSinList += ("-" + generated_sins[i] + "\n");
        }
        tmpro.text = NewSinList;
    }


}
