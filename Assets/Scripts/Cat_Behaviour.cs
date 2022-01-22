using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Cat_Behaviour : MonoBehaviour
{

    public enum temp_state {frozen, cold, neutral, hot, boiling}

    //disable later
    private bool referredByList = true;

    public double temperature;
    public GameObject logicmanager_obj;
    public GameObject sinlist_obj;
    public temp_state temperature_state_flag;
    public GameObject catbuttonprefab;

    public bool isBad = false;
    public bool isPoofed = false;

    TMP_Text tmpro;
    GameLogicManager logicmanager;
    CatSinGenerator catsingen;
    SpriteRenderer sprite;
    GameObject canvas;

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
        tmpro = sinlist_obj.GetComponent<TMP_Text>();

        rectTransform = transform.GetComponent<RectTransform>();  
        sinlistui = sinlist_obj.GetComponent<SinList_UI>();

        canvas = GameObject.Find("Canvas");


        generated_sins = catsingen.GeneratedSins;
    }

    // Start is called before the first frame update
    void Start()
    {
        
        temperature = (double)Random.Range(30, 70);

    
        //delays
        Invoke("checkDisposition", 0.5f);

        Invoke("DrawListText", 0.5f);

        //INSTANTIALIZES CATBUTTON
        GameObject catbutton = Instantiate(catbuttonprefab);
        catbutton.transform.SetParent(canvas.transform, false);
        catbutton.GetComponent<RectTransform>().localPosition = this.GetComponent<Transform>().position;
        //catbutton.transform.localScale = new Vector3(1, 1, 1);
    }

    void checkDisposition()
    {
        if (catsingen.goodDisposition < catsingen.badDisposition)
        {
            //Debug.Log("called");
            isBad = true;
        }
    }

    //highlight the cat that the list is referring to.


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
           if ((temperature_state_flag == temp_state.boiling) && (isBad == true)) {logicmanager.UpdateNumWrongJudgement();}
           else if ((temperature_state_flag == temp_state.frozen) && (isBad == false)) {logicmanager.UpdateNumWrongJudgement();}
           else {logicmanager.UpdateNumCorrectJudgement();}
        }
    }

    void DrawListText()
    {
        if (referredByList == true)
        {   
            foreach (string item in generated_sins)
            {
                tmpro.text += ("-" + item + "\n");
            }
        }
    }

    public void SwapList(GameObject selected)
    {
        DrawListText();
    }






}
