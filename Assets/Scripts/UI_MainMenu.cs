using System;
using System.Runtime.CompilerServices;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class UI_MainMenu : MonoBehaviour
{ 
    [SerializeField]
    private GameObject mainMenuPanel;

    [SerializeField]
    private GameObject maxScorePanel;

    [SerializeField]
    private Button newGameButton;

    [SerializeField]
    private Button exitButton;

    private void Start()
    {
        // Initialize the main menu
        mainMenuPanel.SetActive(true);
        maxScorePanel.SetActive(false);
        newGameButton.onClick.AddListener(OnNewGameButtonClicked);
        exitButton.onClick.AddListener(ExitGame);
    }

    private void OnNewGameButtonClicked()
    {
        mainMenuPanel.SetActive(false);
        maxScorePanel.SetActive(true);
    }

    private void ExitGame()
    {
        Debug.Log("Exiting game...");
        Application.Quit();
    }
}
