using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class WinFunctions : MonoBehaviour
{
    public Button nextStageButton;
    // Start is called before the first frame update
    void Start()
    {
        nextStageButton.onClick.AddListener(NextGoNextScene);
    }

    public void NextGoNextScene()
    {
        int nextSceneIndex = SceneManager.GetActiveScene().buildIndex + 1;

        if (SceneManager.sceneCount > nextSceneIndex)
        {
            if(PlayerPrefs.GetInt("NumStageUnlocked") < nextSceneIndex)
                PlayerPrefs.SetInt("NumStageUnlocked", nextSceneIndex);
            SceneManager.LoadScene(nextSceneIndex);
        }
        else
        {
            SceneManager.LoadScene(0);
        }
    }

    public void BackToMain()
    {
        SceneManager.LoadScene(0);
    }
}
