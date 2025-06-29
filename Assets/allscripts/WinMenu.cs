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
            // �÷��̾ ��¼��� ����ϸ� UI�� Ȱ��ȭ�Ͽ� ��ư�� ǥ���մϴ�.
            winMenuUI.SetActive(true);
        }
    }

    public void MainMenuButton()
    {
        // ���� �޴��� ���� ��ư�� ������ ���� �޴� Scene���� �̵��մϴ�.
        SceneManager.LoadScene(mainMenuSceneName);
    }

    public void NextLevelButton()
    {
        // ���� ������ ���� ��ư�� ������ ���� ���� Scene���� �̵��մϴ�.
        SceneManager.LoadScene(nextLevelSceneName);
    }

    public void RestartButton()
    {
        // ����� ��ư�� ������ ���� Scene�� �ٽ� �ε��մϴ�.
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
