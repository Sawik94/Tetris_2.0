using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ReturnToMenu : MonoBehaviour
{

    public Button gameoverbutton;
    static public GameObject canvasObject;
    public Button savescorebutton;
   


    void Start()
    {
   
        gameoverbutton.onClick.AddListener(ReturnToMainMenu);
        savescorebutton.onClick.AddListener(savescore);
    }


    public void savescore()
    {
        //ScoreManager.AddScore(new Score("jan", UI.playerscore));
        savescorebutton.interactable = false;
    }



    public void showgameover()
    {
        canvasObject.SetActive(true);
    }
    public void ReturnToMainMenu()
    {
        SceneManager.LoadScene("mainmenu");
    }

    void Update()
    {
      
            
        
    }
}
