using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CatSinGenerator : MonoBehaviour
{
        //COMPONENTS
        Cat_Behaviour catBehaviour; 

        //GOOD AND BAD SIN LISTS
        List<string> GoodSins = new List<string>();
        List<string> BadSins = new List<string>();

        //LIST TO GENERATE TO
        public List<string> GeneratedSins = new List<string>();

        //VARIABLES FOR CALCULATING GOOD AND BAD SINS
        public int goodDisposition = 0;
        public int badDisposition = 0;

    void Awake()
    {

        catBehaviour =  GetComponent<Cat_Behaviour>();
        InitializeSins();
    }

    // Start is called before the first frame update
    void Start()
    {
        GenerateSins();
    }

    //loads sins from a txt file onto a list.
    void InitializeSins()
    {
        //load up the GoodSins
        GoodSins.Add("Cuddled their depressed owner");
        GoodSins.Add("Caught a hamster for lonely owner");
        GoodSins.Add("starred in a viral tiktok video");
        GoodSins.Add("immortalized in an internet meme");
        GoodSins.Add("did a good mlem");
        GoodSins.Add("Did not eat the christmas turkey");
        GoodSins.Add("Did not throw up a hairball today");

        BadSins.Add("bit the owner's ass");
        BadSins.Add("toppled mug");
        BadSins.Add("blew up the eiffel tower");
        BadSins.Add("broke the brroklyn bridge");
        BadSins.Add("crashed digipen servers");
        BadSins.Add("Started an underground catnip ring");
        BadSins.Add("TOOK THE NEIGHBOURS FISH");
    }

    //generatesins adds randomised strings from the good and bad sins onto a list.
    void GenerateSins()
    {
        int numberOfSins = Random.Range(3, 7);
        if (numberOfSins%2 == 0) {numberOfSins++;}        //ensures that odd number is generated
        
        //testcode
        Debug.Log(numberOfSins);

        for (int i = 0; i < numberOfSins; i++)
        {
            int rng_value = Random.Range (0,100);       //generates a number from 0-100
            

            if (rng_value%2 == 1)
            {
                int listIndex = Random.Range(0, GoodSins.Count);
                GeneratedSins.Add(GoodSins[listIndex]);
                GoodSins.RemoveAt(listIndex);
                goodDisposition++;

            }

            else
            {
                int listIndex = Random.Range(0, BadSins.Count);
                GeneratedSins.Add(BadSins[listIndex]);
                BadSins.RemoveAt(listIndex);
                badDisposition++;
            }

        }

        //debug code
        for (int i = 0; i < GeneratedSins.Count; i++)
        {
            Debug.Log(GeneratedSins[i]);
        }
    }




}
