using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class UI : MonoBehaviour
{
    [SerializeField] private int playerscore;
    [SerializeField] private TMP_Text scoretext;

    public static int NumberOfRows = 0;


    public void updatescore(int n)
    {
        switch (n)
        {
            case 1:
                playerscore += 40;
                break;
            case 2:
                playerscore += 100;
                break;
            case 3:
                playerscore += 300;
                break;
            case 4:
                playerscore += 1200;
                break;
        }
        scoretext.text = "Score: " + playerscore.ToString();
    }
    void Start()
    {
        playerscore = 0;
        scoretext.text = "Score: " + playerscore.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        NumberOfRows = 0;
    }
}
