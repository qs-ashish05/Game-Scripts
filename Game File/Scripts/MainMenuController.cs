using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuController : MonoBehaviour
{
    public void Btnfunctions(){
/*
        // to know which button has pressed
        string clickObj = UnityEngine.EventSystems.EventSystem.current.currentSelectedGameObject.name;
        Debug.Log("Button pressed : " + clickObj);

        if(clickObj == "Playbtn"){
            SceneManager.LoadScene("Modes");  
        }
        else if(clickObj == "Exitbtn"){
            Application.Quit();
        }
        else if(clickObj == "Rulesbtn"){
            SceneManager.LoadScene("Rules");

        }
        else if(clickObj == "Credits"){
            SceneManager.LoadScene("Credits");

        }
        else if(clickObj == "Backbtn"){
            SceneManager.LoadScene("MainMenu");

        }
        */
    }
    public void Playbtn(){
        //Debug.Log("Play");
        SceneManager.LoadScene("Modes");
    }
    public void Exitbtn(){
        //Debug.Log("Exit");
        Application.Quit();
    }
    public void Rulesbtn(){
        SceneManager.LoadScene("Rules");
    }
    public void Credits(){
         //Debug.Log("Credits");
        SceneManager.LoadScene("Credits");
    }
    public void Backbtn(){
        SceneManager.LoadScene("MainMenu");
    }
    public void levelmode(){
        SceneManager.LoadScene("level01");

        // here change the logic of loadig last level
    }
    public void infinitemode(){
        SceneManager.LoadScene("infinitemode");
    }
}
