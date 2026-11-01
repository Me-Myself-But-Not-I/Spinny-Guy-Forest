using System;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuController : MonoBehaviour
{
    private int levelToLoad = 1;

    public void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            levelToLoad = 1;
        }
        else if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            levelToLoad = 2;
        }
        else if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            levelToLoad = 3;
        }
        else if (Input.GetKeyDown(KeyCode.Alpha4))
        {
            levelToLoad = 4;
        }
        else if (Input.GetKeyDown(KeyCode.Alpha5))
        {
            levelToLoad = 5;
        }
        else if (Input.GetKeyDown(KeyCode.Alpha6))
        {
            levelToLoad = 6;
        }
        else if (Input.GetKeyDown(KeyCode.Alpha7))
        {
            levelToLoad = 7;
        }
        else if (Input.GetKeyDown(KeyCode.Alpha8))
        {
            levelToLoad = 8;
        }
        else if (Input.GetKeyDown(KeyCode.Alpha9))
        {
            levelToLoad = 9;
        }
        else if (Input.GetKeyDown(KeyCode.Alpha0))
        {
            levelToLoad = 10;
        }
    }

    public void OnPlayButton()
    {
        SceneManager.LoadScene(levelToLoad);
    }
    
    public void OnCreditsButton()
    {
        SceneManager.LoadScene("credits");
    }
    
    public void OnControlsButton()
    {
        SceneManager.LoadScene("Controls");
    }
    
    public void OnBackButton()
    {
        SceneManager.LoadScene(0);
    }
    
    public void OnQuitButton()
    {
        Application.Quit();
    }
}