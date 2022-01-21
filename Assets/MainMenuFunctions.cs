using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainMenuFunctions : MonoBehaviour
{
    public GameObject mainMainMenu;
    public GameObject levelSelectMenu;
    public GameObject optionsMenu;
    public GameObject startOption;
    
    

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void MainToLevelSelect()
    {
        levelSelectMenu.SetActive(true);
        mainMainMenu.SetActive(false);
    }

    public void LevelSelectToMain()
    { 
        levelSelectMenu.SetActive(false);
        mainMainMenu.SetActive(true);
    }

    public void MainToOptions()
    {
        optionsMenu.SetActive(true);
        mainMainMenu.SetActive(false);
    }

    public void OptionsToMain()
    {
        optionsMenu.SetActive(false);
        mainMainMenu.SetActive(true);
    }

    public void QuitGame()
    {
        Application.Quit();
    }
}
