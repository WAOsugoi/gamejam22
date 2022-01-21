using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameLogicManager : MonoBehaviour
{

    public int numberOfCatsToBeJudged = 10; // default to 10
    public GameObject currentCanvas;
    public GameObject winScreenPrefab;
    public GameObject loseScreenPrefab;

    private int numWrongJudgement = 0;
    private int numCorrectJudgement = 0;
    private int currentNumberOfCatsToBeJudged;

    // Start is called before the first frame update
    void Start()
    {
        currentNumberOfCatsToBeJudged = numberOfCatsToBeJudged;
        //Debug.Log(SceneManager.GetActiveScene().buildIndex);
        //LoseEvent();
    }

    // Update is called once per frame
    void Update()
    {
        if (numWrongJudgement >= 3)
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
    }

    private void WinEvent()
    {
        GameObject winScreen = Instantiate(winScreenPrefab) as GameObject;
        winScreen.transform.SetParent(currentCanvas.transform, false);
    }

    private void LoseEvent()
    {
        GameObject loseScreen = Instantiate(loseScreenPrefab) as GameObject;
        loseScreen.transform.SetParent(currentCanvas.transform, false);
    }

    //Check if there are still cats left to be judged, if have decrease the cat count and return true to spawn cat.
    public bool AllowedToSpawn()
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
