using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//CatSinGenerator catsingen = GetComponent<CatSinGenerator>();

public class Cat_Behaviour : MonoBehaviour
{
    double temperature;
    enum temp_state {frozen, cold, neutral, hot, boiling};

    
    //I'm using a coroutine to be sure the list in Script1 is created before I print the items in the list.
     IEnumerator WaitForSinList()
     {
         //catsingen = GetComponent<CatSinGenerator>();
         yield return new WaitForEndOfFrame();


         //foreach(string s in s1.testList)
     }  



    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
