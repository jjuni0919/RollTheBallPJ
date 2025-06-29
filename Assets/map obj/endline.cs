using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class endline : MonoBehaviour
{
    public Camera mainCamera; // 카메라를 Inspector에서 할당해주세요.

    private bool cameraFixed = false;

    
    public GameObject nextui;
    public GameObject pauseui;

    void OnTriggerEnter2D(Collider2D other)
    {
        // 플레이어가 결승선과 충돌한 경우
        if (other.CompareTag("Player") && !cameraFixed)
        {

            stagemanage.currentstagenum++;
            // 카메라 이동을 멈춥니다.
            other.GetComponent<Collider2D>().enabled = false;

            StartCoroutine(ExecuteAfterDelay(0.2f));
            
            StartCoroutine(ExecuteAfterDelay1(1f));
        }
    }
    IEnumerator ExecuteAfterDelay(float delayTime)
    {
        // delayTime 만큼 대기합니다.
        yield return new WaitForSeconds(delayTime);

        // 딜레이 이후에 실행될 코드를 여기에 작성합니다.
        mainCamera.GetComponent<camera>().enabled = false;

        cameraFixed = true;
    }

    IEnumerator ExecuteAfterDelay1(float delayTime)
    {
        // delayTime 만큼 대기합니다.
        yield return new WaitForSeconds(delayTime);

        // 딜레이 이후에 실행될 코드를 여기에 작성합니다.
        nextui.SetActive(true);
        pauseui.SetActive(false);
    }

    
}

