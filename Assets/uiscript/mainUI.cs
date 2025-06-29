using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class mainUI : MonoBehaviour
{
    public Button gamestart;
    public GameObject gameStartUI; // ���� ���� UI�� �����ϱ� ���� ����
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
            // ���� ��ư�� Ŭ���Ͽ� ������ �ٽ� �����մϴ�.
            Time.timeScale = 1f;
            isGameStarted = true;
            gameStartUI.SetActive(false);
            SceneManager.LoadScene(stagemanage.currentStageName);
        }
    }
    
}
