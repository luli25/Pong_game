using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class UI_GameOver : MonoBehaviour
{
    [SerializeField]
    private GameObject gameOverScreen;

    [SerializeField]
    private GameObject scorePanel;

    [SerializeField]
    private TMP_Text winnerPlayerName;

    /*
    [SerializeField]
    private Button restartButton;

    [SerializeField]
    private Button mainMenubutton;
    */

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

    public void ShowGameOverScreen(string winnerName)
    {
        scorePanel.SetActive(false);
        gameOverScreen.SetActive(true);
        winnerPlayerName.text = winnerName;
    }

    public void RestartGame()
    {
        gameOverScreen.SetActive(false);
        scorePanel.SetActive(true);
        GameManager.Instance.RestartGameAfterGameOver();
    }

    public void MainMenu()
    {
        Debug.Log("Go to Main Menu Screen");
    }


    private void Start()
    {
        gameOverScreen.SetActive(false);
    }

}
