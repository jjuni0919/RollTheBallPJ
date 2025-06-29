using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartButton : MonoBehaviour
{
    public void OnStartButtonClicked()
    {
        if (Time.timeScale == 0f)
        {
            // ���� ��ư�� Ŭ���Ͽ� ������ �ٽ� �����մϴ�.
            Time.timeScale = 1f;
        }
        else
        {
            // ���� ��ư�� Ŭ���Ͽ� ������ ������ŵ�ϴ�.
            Time.timeScale = 0f;
        }
    }
}