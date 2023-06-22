using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;

public class GameLogicScript : MonoBehaviour

{

    public int playerScore;
    public TextMeshProUGUI scoreText;

    [ContextMenu("Manually Increase Score")]
    public void addScore()
    {
        playerScore = playerScore + 1;
        scoreText.text = playerScore.ToString();
    }

    public void restartGame()
    {
    SceneManager.LoadScene("MainMenu");
}
}
