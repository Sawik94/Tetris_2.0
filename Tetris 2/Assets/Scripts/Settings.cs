using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;

public class Settings : MonoBehaviour
{
    [SerializeField] public Slider slider;
    [SerializeField] private TMP_Text scoretext;
    public static int frequency = 3;
    public Button BackButton;

    public void UpdateMyValue(int newValue)
    {
        frequency = newValue;
    }

 

    //public void AdjustFrequency(float newfrequency)
    //{
    //    int intnewfrequency = (int)newfrequency;
    //    PlayerPrefs.SetInt("Frequency", intnewfrequency);
    //    frequency = PlayerPrefs.GetInt("Frequency");
    //}

    private void Back()
    {

        SceneManager.LoadScene("mainmenu");
    }


    public void LoadValues()
    {
        float freqValue = (float)PlayerPrefs.GetInt("Frequency");
        slider.value = freqValue;
        frequency = (int)freqValue;

    }

    public void SaveFreqSlider()
    {
        float freqValue = slider.value;
        int intfreqValue = (int)freqValue;
        PlayerPrefs.SetInt("Frequency", intfreqValue);
        LoadValues();
    }

    void Start()
    {
        //slider.value = PlayerPrefs.GetInt("Frequency", 4);
        //frequency = PlayerPrefs.GetInt("Frequency");
        slider.value = 3;
        frequency = 3;
        BackButton.onClick.AddListener(Back);
        scoretext.text = "Random Block Falling Frequency: " + frequency.ToString();
        LoadValues();
    }

    void Update()
    {
        scoretext.text = "Random Block Falling Frequency: " + slider.value.ToString();
    }
}