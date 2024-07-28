using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LogicScript : MonoBehaviour
{
    public int playerScore;
    public float increasingVelocity = 0.1F;
    public Pipes pipes;
    public Text scoreText;
    public GameObject GameOver;

    void Start()
    {
    }

    [ContextMenu("Increase Score")]
    public void addScore()
    {
        playerScore++;
        scoreText.text = playerScore.ToString();  
    }
    public void increasePipeVelocity()
    {
        increasingVelocity += 0.1F;
        pipes.moveSpeed += increasingVelocity;
    }
    public void gameOver()
    {
        GameOver.SetActive(true);
    }
    public void restartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
