using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CatSinGenerator : MonoBehaviour
{
        List<string> GoodSins = new List<string>();
        List<string> BadSins = new List<string>();
        List<string> GeneratedSins = new List<string>();

    // Start is called before the first frame update
    void Start()
    {
        InitializeSins();
        GenerateSins();

        //TODO: getcomponentt of the cat.

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
        //TODO: create a random number generator, based on difficulty iteration number will change. 
        //if number generated is even, load a BAD SIN onto. increment the bad sin counter;
        //if number generated is odd, load a good sin onto the cat. increment the good sin counter.
        //calculate the temperature disposition based on good sins. if good sins > %ge will be higher.
        Debug.Log("WAKE UP LOSERS IT'S TIME TO SIN");

    }




}
