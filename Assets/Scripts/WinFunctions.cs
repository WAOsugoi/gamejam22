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
            SceneManager.LoadScene(nextSceneIndex);
        }
    }
}
