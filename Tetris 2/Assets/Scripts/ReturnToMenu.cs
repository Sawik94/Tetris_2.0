using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ReturnToMenu : MonoBehaviour
{

    public Button gameoverbutton;
    static public GameObject canvasObject;
    

    void Start()
    {
        //canvasObject.SetActive(false);
        gameoverbutton.onClick.AddListener(ReturnToMainMenu);
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
