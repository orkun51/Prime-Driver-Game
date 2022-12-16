using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public GameObject HpScene;
            
    public void Start() 
    {
        Screen.orientation = ScreenOrientation.LandscapeLeft;

    }
   
    
    public void Quit()
    {
        Application.Quit();
    }

    public void MainMenu()
    {
        SceneManager.LoadScene(0);
    }

    public void Settings()
    {
        SceneManager.LoadScene(1);
        
    }
    public void Plays()
    {
        SceneManager.LoadScene(2);
        
    }

    public void howToplay()
    {
        HpScene.SetActive(true);
    }

    public void hpExit()
    {
        HpScene.SetActive(false);
    }
     public void RestartGame()
    {
        SceneManager.LoadScene(3);  
        
        
    }
    public void RandomScene0()
    {
        SceneManager.LoadScene(4);
    }
    public void RandomScene1()
    {
        SceneManager.LoadScene(5);
    }
    public void RandomScene2()
    {
        SceneManager.LoadScene(6);
    }
    public void RandomScene3()
    {
        SceneManager.LoadScene(7);
    }
    public void RandomSceneFinal()
    {
        SceneManager.LoadScene(8);
    }
    public void Reset()
    {
       
        PlayerPrefs.DeleteAll();
        GetComponent<getPrimme>().highscore.text = "0";

        //GetComponent<Settings>().reseted.SetActive(true);
   
    }

    public void CloseSound()
    {
        AudioListener.volume = 0; 
    }
    public void OpenSound()
    {
       AudioListener.volume = 1; 
    }
    
   
}
