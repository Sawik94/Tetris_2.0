using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MainMenu : MonoBehaviour
{
    public Button startButton;
    public Button scoreboardButton;

    private void Start()
    {

        startButton.onClick.AddListener(StartGame);
        scoreboardButton.onClick.AddListener(StartGame);
    }

    private void StartGame()
    {

        SceneManager.LoadScene("Tetris");
    }

    private void ShowScoreboard()
    {

        SceneManager.LoadScene("Tetris");
    }
}