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

        BadSins.Add("bit the owner's ass");
        BadSins.Add("toppled mug");
        BadSins.Add("blew up the eiffel tower");
        BadSins.Add("broke the brroklyn bridge");
        BadSins.Add("crashed digipen servers");
    }

    //generatesins adds randomised strings from the good and bad sins onto a list.
    void GenerateSins()
    {
        int numberOfSins = Random.Range(3, 6);

        for (int i = 0; i < numberOfSins; i++)
        {
            int rng_value = Random.Range (0,100);

            if (rng_value%2 == 1)
            {
                int listIndex = Random.Range(0, GoodSins.Count);
                GeneratedSins.Add(GoodSins[listIndex]);
                goodDisposition++;
            }

            else
            {
                int listIndex = Random.Range(0, BadSins.Count);
                GeneratedSins.Add(BadSins[listIndex]);
                badDisposition++;
            }
        }
    }




}
