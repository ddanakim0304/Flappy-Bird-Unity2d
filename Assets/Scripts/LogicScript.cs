using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class LogicScript : MonoBehaviour
{
    public int playerScore;
    public TextMeshProUGUI scoreText;

    [ContextMenu("Score + 1")]
    public void addScore()
    {
       playerScore += 1;
       scoreText.text = playerScore.ToString();
    }
}
