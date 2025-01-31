using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameStarter : MonoBehaviour
{
    [SerializeField] Button startGameButton;
    [SerializeField] List<Button> buttonsToActivateAtBeginning;
    [SerializeField] GameObject lobbyCanvas;

    void Start()
    {
        startGameButton.onClick.AddListener(StartGame);
    }
    private void StartGame()
    {
        foreach(var button in buttonsToActivateAtBeginning)
        {
            button.interactable = true;
        }
        lobbyCanvas.SetActive(false);
    }
}
