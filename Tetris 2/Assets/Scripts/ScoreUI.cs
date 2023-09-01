using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class ScoreUI : MonoBehaviour
{
    public RowUi rowUi;
    public ScoreManager scoreManager;
    public Button BackButton;

    private void Back()
    {

        SceneManager.LoadScene("mainmenu");
    }

    void Start()
    {
        BackButton.onClick.AddListener(Back);
        scoreManager.AddScore(new Score("jan", 5));
        scoreManager.AddScore(new Score("marcin", 20));
        scoreManager.AddScore(new Score("agata", 1));
        scoreManager.AddScore(new Score("kuba", 300));


        var scores = scoreManager.GetHighScores().ToArray();
        for (int i = 0; i < scores.Length; i++)
        {
            var row = Instantiate(rowUi, transform).GetComponent<RowUi>();
            row.rank.text = (i + 1).ToString();
            row._name.text = scores[i].name;
            row.score.text = scores[i].score.ToString();
        }
    }


}
