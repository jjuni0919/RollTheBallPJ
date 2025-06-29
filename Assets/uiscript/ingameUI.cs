using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class ingameUI : MonoBehaviour
{

    public GameObject ingameUi; //인게임 UI 연결

    public Button pause;
    public Button resume;
    public Button restart;
    public Button exit;

    void Start()
    {
        pause.onClick.AddListener(PauseButton);
        resume.onClick.AddListener(ResumeButton);
        exit.onClick.AddListener(ExitButton);
        restart.onClick.AddListener(RestartButton);
    }



    void PauseButton()
    {
        Time.timeScale = 0f;
        ingameUi.SetActive(true);
        pause.interactable = false;
    }
    void ResumeButton()
    {
        Time.timeScale = 1f;
        ingameUi.SetActive(false);
        pause.interactable = true;
    }
    void ExitButton()
    {
        SceneManager.LoadScene("main");
    }
    void RestartButton()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene(stagemanage.currentStageName);
    }

}
