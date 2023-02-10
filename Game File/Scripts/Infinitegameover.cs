using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine;

public class Infinitegameover : MonoBehaviour
{
    public GameManager gm;
    public GameObject gameover;
    public InfiniteScoreController scorecontroller; 
    

    public float score;
    public float hiscore;
    public Text currentscore;
    public Text highscore;

    public string temp;

   void Start(){
      highscore.text = PlayerPrefs.GetFloat("Highscore",0f).ToString();
   }

    void OnCollisionEnter(Collision Collision){
      temp = Collision.gameObject.name;

      if (temp == "Level"){
         gameover.SetActive(true);
        } 
     }

     public void Restart(){
        SceneManager.LoadScene("infinitemode");
     }
     public void mainMenu(){
        SceneManager.LoadScene("MainMenu");
     }
}
