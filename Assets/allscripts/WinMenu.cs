using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class WinMenu : MonoBehaviour
{
    public GameObject winMenuUI;
    public string mainMenuSceneName;
    public string nextLevelSceneName;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            // 플레이어가 결승선을 통과하면 UI를 활성화하여 버튼을 표시합니다.
            winMenuUI.SetActive(true);
        }
    }

    public void MainMenuButton()
    {
        // 메인 메뉴로 가는 버튼을 누르면 메인 메뉴 Scene으로 이동합니다.
        SceneManager.LoadScene(mainMenuSceneName);
    }

    public void NextLevelButton()
    {
        // 다음 레벨로 가는 버튼을 누르면 다음 레벨 Scene으로 이동합니다.
        SceneManager.LoadScene(nextLevelSceneName);
    }

    public void RestartButton()
    {
        // 재시작 버튼을 누르면 현재 Scene을 다시 로드합니다.
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
