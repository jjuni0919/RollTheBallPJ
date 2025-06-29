using Newtonsoft.Json.Bson;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class audioscript : MonoBehaviour
{
    public static bool bgmaudio=true;
    public AudioSource audioSource;
    public static bool soundeffect = true;
    public Button ButtonbgmButton1;
    public Button ButtonbgmButton2;
    public GameObject gameui1;
    public GameObject gameui2;

    public Button ButtonsoundButton1;
    public Button ButtonsoundButton2;
    public GameObject gameui3;
    public GameObject gameui4;
    private void Start()
    {
        
        if (bgmaudio)
        {
            audioSource.Play();
            gameui1.SetActive(true);
            gameui2.SetActive(false);
        }
        else
        {
            audioSource.Pause();
            gameui1.SetActive(false);
            gameui2.SetActive(true);
            
        }
        if (soundeffect)
        {
            gameui3.SetActive(true);
            gameui4.SetActive(false);
        }
        else
        {
            gameui3.SetActive(false);
            gameui4.SetActive(true);
        }
        ButtonbgmButton1.onClick.AddListener(ToggleBGM);
        ButtonbgmButton2.onClick.AddListener(ToggleBGM);
        ButtonsoundButton1.onClick.AddListener(ToggleBut);
        ButtonsoundButton2.onClick.AddListener(ToggleBut);
        
        
    }
    


    public void ToggleBGM()
    {
        if (bgmaudio)
        {
            // 배경 음악을 일시 정지
            bgmaudio = false;
            audioSource.Pause();
            gameui1.SetActive(false);
            gameui2.SetActive(true);
        }
        else
        {
            // 배경 음악을 재생
            bgmaudio = true;
            audioSource.Play();
            gameui1.SetActive(true);
            gameui2.SetActive(false);
        }
    }

    public void ToggleBut()
    {
        if (soundeffect)
        {
            soundeffect = false;
            gameui3.SetActive(false);
            gameui4.SetActive(true);
        }
        else
        {
            soundeffect = true;
            gameui3.SetActive(true);
            gameui4.SetActive(false);
        }
    }
}
