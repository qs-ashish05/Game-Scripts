using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOver : MonoBehaviour
{
    public GameManager gm;
    public GameObject gameover;
    public GameObject gamecompleted;

    // highs obj score obj, score var, hs var
    public string temp;
    public int level = 1;


    void OnCollisionEnter(Collision Collision){
      temp = Collision.gameObject.name;

      if (temp == "Level"){
         //Debug.Log("game over");
         gameover.SetActive(true);


      }
      else {
         //Debug.Log("next level");
         gamecompleted.SetActive(true);
      }
         
      
     }

     public void Restart(){
       // Debug.Log("restart pressed"+ gm.levels[level + 1]);

        // gm.levels[level + 1]

        //SceneManager.LoadScene(gm.levels[level + 1]);
        SceneManager.LoadScene("level01");

        // load current level here


     }
     public void mainMenu(){
        //Debug.Log("Main menu pressed");
        SceneManager.LoadScene("MainMenu");
     }
     // for level mode
     public void nextLevel(){
        Debug.Log("Next level loded");
        //SceneManager.LoadScene("Next level loded");
     }


     // for infinite mode 
     public void infiniteresart(){
        SceneManager.LoadScene("infinitemode");
     }

}
