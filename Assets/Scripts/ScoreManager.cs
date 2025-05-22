using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreManager : MonoBehaviour
{
    public static int maxScore;

    public void SetMaxScore(int score)
    {
        maxScore = score;
        Debug.Log("Max Score Set: " + maxScore);
    }
}
