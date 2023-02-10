using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class scoreController : MonoBehaviour
{
    /*
    public float score = 0; 
    public Text scoreText; 

    void Update() {

       score+= (1 *Time.timeScale/600);
       //score = (int)score;
       Debug.Log((int)(score/3));


    }
    */

   public Transform player;
    public float initX;
    public float finalX;
    public float score;
    public Text scoreText;
    public Text finalscoreText;    // time of game over
    public Text finalscoreText2;   // time of level complete 
    void Start(){
        initX = player.position.z;
        //Debug.Log(initX);
    }

    void Update(){
        finalX = player.position.z;
        score = finalX - initX;
        Debug.Log((int)score);
        score = (int)score / 6;
        scoreText.text = score.ToString();
        finalscoreText.text = score.ToString() + " Points";
        finalscoreText2.text = score.ToString() + " Points";
    }

}
