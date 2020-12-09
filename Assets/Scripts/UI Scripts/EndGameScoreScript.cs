using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EndGameScoreScript : MonoBehaviour
{

    public Text scoreText;

    // Update is called once per frame
    void Update()
    {

        SaveScore();
        //scoreText.text = player.position.z.ToString("0");
    }

    public void SaveScore()
    {
        //int HighestScore = PlayerPrefs.GetInt("HighScore");
        scoreText.text = PlayerPrefs.GetInt("HighScore").ToString();
    } 
   
}
