using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LoseFunctions : MonoBehaviour
{
    public Button retryButton; 
    
    // Start is called before the first frame update
    void Start()
    {
        retryButton.onClick.AddListener(RetryCurrentScene);
    }

    public void RetryCurrentScene()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
