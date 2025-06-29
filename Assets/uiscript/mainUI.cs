using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class mainUI : MonoBehaviour
{
    public Button gamestart;
    public GameObject gameStartUI; // 게임 시작 UI를 연결하기 위한 변수
    public static int totalscore = 0;

    private bool isGameStarted = false;
    // Start is called before the first frame update
    private void Awake()
    {
        Time.timeScale = 0f;
        
    }
    private void Start()
    {
        gamestart.onClick.AddListener(GameStartButton);
    }

    // Update is called once per frame
    void GameStartButton()
    {
        if (Time.timeScale == 0f && !isGameStarted)
        {
            // 시작 버튼을 클릭하여 게임을 다시 시작합니다.
            Time.timeScale = 1f;
            isGameStarted = true;
            gameStartUI.SetActive(false);
            SceneManager.LoadScene(stagemanage.currentStageName);
        }
    }
    
}
