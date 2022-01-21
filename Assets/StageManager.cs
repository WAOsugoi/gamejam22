using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StageManager : MonoBehaviour
{
    public Scene stage1;
    public Scene stage2;
    public Scene stage3;
    public Scene stage4;
    public Scene stage5;

    public bool[] unlockedStage;

    private static StageManager _instance;

    public static StageManager Instance { get { return _instance; } }


    private void Awake()
    {
        if (_instance != null && _instance != this)
        {
            Destroy(this.gameObject);
        }
        else
        {
            _instance = this;
        }
    }

    public void GoToStage1()
    {
        if(unlockedStage[1])
        {
            SceneManager.LoadScene(1);
        }
    }

    public void GoToStage2()
    {
        if (unlockedStage[2])
        {
            SceneManager.LoadScene(2);
        }
    }

    public void GoToStage3()
    {
        if (unlockedStage[3])
        {
            SceneManager.LoadScene(3);
        }
    }

    public void GoToStage4()
    {
        if (unlockedStage[4])
        {
            SceneManager.LoadScene(4);
        }
    }

    public void GoToStage5()
    {
        if (unlockedStage[5])
        {
            SceneManager.LoadScene(5);
        }
    }
}
