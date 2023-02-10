using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InfiniteScoreController : MonoBehaviour
{
    public Transform player;
    public float initX;
    public float finalX;
    public float score;
    public float highscore = 0f; 
    public Text scoreText;
    public Text finalscoreText; 
    public Text HighScore;      

    public static int hs=0;

    void Start(){
        initX = player.position.z;
        hs = PlayerPrefs.GetInt("Highscore");
    }

    void Update(){
        finalX = player.position.z;
        score = finalX - initX;
        score = (int)score / 6;

        scoreText.text = score.ToString();
        finalscoreText.text = "Score: " + score.ToString() ;

        if (hs < (int)score ){
            hs = (int)score;
            PlayerPrefs.SetInt("Highscore", hs);
        }

        HighScore.text =  "HighScore: " + hs.ToString();


    }
}
