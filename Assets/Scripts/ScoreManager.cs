using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ScoreManager : MonoBehaviour
{
    public static int maxScore;

    public void SetMaxScore(int score)
    {
        maxScore = score;
    }

    public void StartGame()
    {
        SceneManager.LoadScene("Game");
    }
}
