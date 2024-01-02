using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System.Diagnostics;
using System;

public class LogicScripts : MonoBehaviour
{
    public Text scoreText;
    public int playerScore;
    public GameObject gameOverScreen;

    public void addScore(int scoreToAdd ){
        playerScore = playerScore + 1;
        scoreText.text = playerScore.ToString();
    }

     public void RestartGame(){
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void gameOver(){
        gameOverScreen.SetActive(true);
    }
}
