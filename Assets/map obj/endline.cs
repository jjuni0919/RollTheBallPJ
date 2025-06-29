using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class endline : MonoBehaviour
{
    public Camera mainCamera; // ī�޶� Inspector���� �Ҵ����ּ���.

    private bool cameraFixed = false;

    
    public GameObject nextui;
    public GameObject pauseui;

    void OnTriggerEnter2D(Collider2D other)
    {
        // �÷��̾ ��¼��� �浹�� ���
        if (other.CompareTag("Player") && !cameraFixed)
        {

            stagemanage.currentstagenum++;
            // ī�޶� �̵��� ����ϴ�.
            other.GetComponent<Collider2D>().enabled = false;

            StartCoroutine(ExecuteAfterDelay(0.2f));
            
            StartCoroutine(ExecuteAfterDelay1(1f));
        }
    }
    IEnumerator ExecuteAfterDelay(float delayTime)
    {
        // delayTime ��ŭ ����մϴ�.
        yield return new WaitForSeconds(delayTime);

        // ������ ���Ŀ� ����� �ڵ带 ���⿡ �ۼ��մϴ�.
        mainCamera.GetComponent<camera>().enabled = false;

        cameraFixed = true;
    }

    IEnumerator ExecuteAfterDelay1(float delayTime)
    {
        // delayTime ��ŭ ����մϴ�.
        yield return new WaitForSeconds(delayTime);

        // ������ ���Ŀ� ����� �ڵ带 ���⿡ �ۼ��մϴ�.
        nextui.SetActive(true);
        pauseui.SetActive(false);
    }

    
}

