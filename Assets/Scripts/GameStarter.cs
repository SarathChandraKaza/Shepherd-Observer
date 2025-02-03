using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


/// <summary>
/// This script links the starting instructions UI and the game. It enables the interactivity of the
/// Jump, Move Right, Move Left buttons after the "Start" button is clicked.
/// </summary>
public class GameStarter : MonoBehaviour
{
    [SerializeField] Button startGameButton;
    [SerializeField] List<Button> controlButtons;
    [SerializeField] GameObject lobbyCanvas;

    void Start()
    {
        startGameButton.onClick.AddListener(StartGame);
    }
    private void StartGame()
    {
        foreach (var button in controlButtons)
        {
            button.interactable = true;
        }

        lobbyCanvas.SetActive(false);
    }
}
