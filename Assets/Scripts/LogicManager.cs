using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;
using System;

public class LogicManager : MonoBehaviour
{
    public int playerScore;
    public TextMeshProUGUI scoreText;   
    public GameObject gameOverScreen;

    [ContextMenu("Increase Score")]

    void Start()
    {
        gameOverScreen.SetActive(false);
        playerScore = 0;
        scoreText.text = playerScore.ToString();
    }
    public void AddScore(int scoreToAdd)
    {
        playerScore = playerScore + scoreToAdd;
        scoreText.text = playerScore.ToString();
    }

    public void RestartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void QuitGame()
    {
        Application.Quit();
    }

    public void GameOver()
    {
        gameOverScreen.SetActive(true);
        Debug.Log("Game Over");
    }
}
