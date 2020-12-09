using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreScript : MonoBehaviour
{
    public Transform player;
    public Text scoreText;
    public static float score ;

    // Update is called once per frame
    void Update()
    {
        score = player.position.z;
        scoreText.text = score.ToString("0");
        PlayerPrefs.SetInt("HighScore", (int)score);
    }
}
