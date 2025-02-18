using UnityEngine;
using UnityEngine.UI;

public class GameScore : MonoBehaviour
{
    int score;
    public static GameScore instance;

    public Text scoreText;

    public PlayerMovement playerMovement;
    public void IncrementScore()
    {
        score++;
        scoreText.text = "SCORE: " + score;
        playerMovement.speed += playerMovement.speedIncreasePerPoint;
    }

    private void Awake()
    {
        instance = this;
    }

}
