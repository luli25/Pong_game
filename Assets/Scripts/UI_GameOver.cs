using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class UI_GameOver : MonoBehaviour
{
    [SerializeField]
    private GameObject gameOverScreen;

    [SerializeField]
    private GameObject scorePanel;

    [SerializeField]
    private TMP_Text winnerPlayerName;

    public static UI_GameOver Instance;

    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
        }
        else
        {
            Destroy(gameObject);
        }
    }


    private void Start()
    {
        gameOverScreen.SetActive(false);
    }

    public void ShowGameOverScreen(string winnerName)
    {
        scorePanel.SetActive(false);
        gameOverScreen.SetActive(true);
        winnerPlayerName.text = winnerName;
    }
}
