using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class HelloPlayers : MonoBehaviour
{
    public Text Player1Name, Player1CharacterName, Player1Nick, Player2Name, Player2CharacterName, Player2Nick;
    public GameObject readyImage , game , pauseMenu;
    public Button restartButton, menuButton , pauseButton , quitButton;

    void Start()
    {
        Player1Name.text = "Merhaba: " + ButtonManager.player1Name;
        Player1CharacterName.text = ButtonManager.player1CharacterName;
        Player1Nick.text = ButtonManager.player1Nick;
        Player2Name.text = "Merhaba: " + ButtonManager.player2Name;
        Player2CharacterName.text = ButtonManager.player2CharacterName;
        Player2Nick.text = ButtonManager.player2Nick;

        Time.timeScale = 1.0f;

        readyImage.SetActive(true);
        game.SetActive(false);
        pauseMenu.SetActive(false);
    }
    public void Ready()
    {
        readyImage.SetActive(false);
        game.SetActive(true);
    }

    public void RestartButton()
    {
        SceneManager.LoadScene(1);
    }
    public void MenuButton()
    {
        SceneManager.LoadScene(0);
    }

    public void PauseButton()
    {
        if (Time.timeScale == 0f)
        {
            Time.timeScale = 1.0f;
            pauseMenu.SetActive(false);
        }
        else if (Time.timeScale == 1f)
        {
            Time.timeScale = 0f;
            pauseMenu.SetActive(true);
        }
    }

    public void QuitButton()
    {
        Application.Quit();
    }
}