using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameLogicManager : MonoBehaviour
{

    public int numberOfCatsToBeJudged = 10; // default to 10
    public int numberOfChance = 3; // default to 3
    public GameObject currentCanvas;
    public GameObject winScreenPrefab;
    public GameObject loseScreenPrefab;
    public GameObject catCounterPrefab;

    private int numWrongJudgement = 0;
    private int numCorrectJudgement = 0;
    private int currentNumberOfCatsToBeJudged;
    private CatCounter currCatCounter;

    private bool endConMet = false;

    // Start is called before the first frame update
    void Start()
    {
        currentNumberOfCatsToBeJudged = numberOfCatsToBeJudged;
        CreateCounter();
        endConMet = false;
        //Debug.Log(SceneManager.GetActiveScene().buildIndex);
        //LoseEvent();
    }

    // Update is called once per frame
    void Update()
    {
        if (numWrongJudgement >= numberOfChance)
        {
            // lose 
            LoseEvent();
        }
        else if(currentNumberOfCatsToBeJudged <= 0 && numCorrectJudgement + numWrongJudgement == numberOfCatsToBeJudged)
        {
            // win 
            WinEvent();
            if (numCorrectJudgement == numberOfCatsToBeJudged)
            {
                // perfect win?
            }
        }

        //winScreen.GetComponent<RectTransform>().localPosition = new Vector3(0, 0, 0);
        if(currCatCounter != null)
        {
            //debug
            currCatCounter.UpdateChancesLeftCount(numberOfChance - numWrongJudgement, numberOfChance);
            currCatCounter.UpdateTotalCatsLeftCount(currentNumberOfCatsToBeJudged, numberOfCatsToBeJudged);
            //actual counter
        }
    }

    private void WinEvent()
    {
        if(!endConMet)
        {
            GameObject winScreen = Instantiate(winScreenPrefab) as GameObject;
            winScreen.transform.SetParent(currentCanvas.transform, false);
            endConMet = true;
        }
        
    }

    private void LoseEvent()
    {
        if (!endConMet)
        {
            GameObject loseScreen = Instantiate(loseScreenPrefab) as GameObject;
            loseScreen.transform.SetParent(currentCanvas.transform, false);
            endConMet = true;
        }
    }

    private void CreateCounter()
    {
        if (!endConMet)
        {
            GameObject counter = Instantiate(catCounterPrefab) as GameObject;
            counter.transform.SetParent(currentCanvas.transform, false);
            currCatCounter = counter.GetComponent<CatCounter>();
            endConMet = true;
        }
    }

    //Check if there are still cats left to be judged, if have decrease the cat count and return true to spawn cat.
    public bool AllowedToSpawn()
    {
        if (currentNumberOfCatsToBeJudged > 0)
        {
            //currentNumberOfCatsToBeJudged -= 1;
            return true;
        }
        else
        {
            return false;
        }
    }

    public bool SpawnCatIfAllowed()
    {
        if (currentNumberOfCatsToBeJudged > 0)
        {
            currentNumberOfCatsToBeJudged -= 1;
            return true;
        }
        else
        {
            return false;
        }
    }

    public int GetMistakesMade()
    {
        return numWrongJudgement;
    }

    public int GetCorrectMade()
    {
        return numCorrectJudgement;
    }

    public void UpdateNumWrongJudgement()
    {
        numWrongJudgement += 1;
    }

    public void UpdateNumCorrectJudgement()
    {
        numCorrectJudgement += 1;
    }




}
