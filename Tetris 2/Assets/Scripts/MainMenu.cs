using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MainMenu : MonoBehaviour
{
    public Button startButton;
    public Button scoreboardButton;
    public Button SettingsButton;

    private void Start()
    {

        startButton.onClick.AddListener(StartGame);
        scoreboardButton.onClick.AddListener(ShowScoreboard);
        SettingsButton.onClick.AddListener(ShowSettings);
    }

    private void StartGame()
    {

        SceneManager.LoadScene("Tetris");
    }

    private void ShowScoreboard()
    {

        SceneManager.LoadScene("Scoreboard");
    }

    private void ShowSettings()
    {

        SceneManager.LoadScene("Settings");
    }
}