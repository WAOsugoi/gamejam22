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
        GoodSins.Add("Caught rat for owner");
        GoodSins.Add("Scratched cat pole");
        GoodSins.Add("Slept in the cat tower");
        GoodSins.Add("Warmed laps");
        GoodSins.Add("Purred when pet");
        GoodSins.Add("Did not refuse a bath!");
        GoodSins.Add("Patiently waited for food");
        GoodSins.Add("Did owner's homework");
        GoodSins.Add("Provided for owner with youtube career.");
        GoodSins.Add("Saved the galaxy.");


        BadSins.Add("Ate too much catnip");
        BadSins.Add("Catnip addiction");
        BadSins.Add("Broke 10 vases");
        BadSins.Add("Scratched owner's face at night");
        BadSins.Add("Tore up owner's homework");
        BadSins.Add("Ate bird room mate");
        BadSins.Add("Refused to catch the roach.");
        BadSins.Add("Did not pay rent.");
        BadSins.Add("Stole neighbour's underwear");
        BadSins.Add("Brought fleas into the house");
        BadSins.Add("Acted in FELINES: the bad movie");
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
        // for (int i = 0; i < GeneratedSins.Count; i++)
        // {
        //     //Debug.Log(GeneratedSins[i]);
        // }
    }




}
