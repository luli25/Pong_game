using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour
{
    [SerializeField]
    private TMP_Text paddle1ScoreText;

    [SerializeField]
    private TMP_Text paddle2ScoreText;

    [SerializeField]
    private Transform paddle1Transform;

    [SerializeField]
    private Transform paddle2Transform;

    [SerializeField]
    private Transform ballTransform;

    private int paddle1Score;
    private int paddle2Score;

    private static GameManager instance;

    public static GameManager Instance
    {
        get
        {
            if (instance == null)
            {
                instance = FindAnyObjectByType<GameManager>();
            }
            return instance;
        }
    }

    public void Paddle1Score()
    {
        paddle1Score++;
        paddle1ScoreText.text = paddle1Score.ToString();
        CheckWinner();
    }

    public void Paddle2Score()
    {
        paddle2Score++;
        paddle2ScoreText.text = paddle2Score.ToString();
        CheckWinner();
    }

    public void Restart()
    {
        paddle1Transform.position = new Vector2(paddle1Transform.position.x, 0);
        paddle2Transform.position = new Vector2(paddle2Transform.position.x, 0);
        ballTransform.position = Vector2.zero;
    }

    public void CheckWinner()
    {
        if (paddle1Score == 5)
        {
            UI_GameOver.Instance.ShowGameOverScreen("Player 1");
            Time.timeScale = 0;
        }
        else if (paddle2Score == 5)
        {
            UI_GameOver.Instance.ShowGameOverScreen("Player 2");
            Time.timeScale = 0;
        }

    }

    public void RestartGameAfterGameOver()
    {
        paddle1Score = 0;
        paddle2Score = 0;
        paddle1ScoreText.text = paddle1Score.ToString();
        paddle2ScoreText.text = paddle2Score.ToString();
        paddle1Transform.position = new Vector2(paddle1Transform.position.x, 0);
        paddle2Transform.position = new Vector2(paddle2Transform.position.x, 0);
        ballTransform.position = Vector2.zero;
        Time.timeScale = 1;
    }

}
