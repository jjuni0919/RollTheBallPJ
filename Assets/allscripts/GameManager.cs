using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartButton : MonoBehaviour
{
    public void OnStartButtonClicked()
    {
        if (Time.timeScale == 0f)
        {
            // 시작 버튼을 클릭하여 게임을 다시 시작합니다.
            Time.timeScale = 1f;
        }
        else
        {
            // 시작 버튼을 클릭하여 게임을 정지시킵니다.
            Time.timeScale = 0f;
        }
    }
}