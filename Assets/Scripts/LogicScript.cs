using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LogicScript : MonoBehaviour
{
    public int playerScore;
    public TextMeshProUGUI scoreText;
    public GameObject gameOverScreen;

    public GameObject bird;
    public BirdScript birdScript;

    void Start()
    {
        birdScript = bird.GetComponent<BirdScript>();
    }

    [ContextMenu("Score + 1")]
    public void addScore(int scoreToAdd)
    {
       if(birdScript.birdIsAlive)
       {
        playerScore += scoreToAdd;
        scoreText.text = playerScore.ToString();
       }
    }

    public void restartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void gameOver()
    {
        gameOverScreen.SetActive(true);
    }
}
