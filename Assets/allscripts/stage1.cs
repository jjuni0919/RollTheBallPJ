using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class stage1 : MonoBehaviour
{
    private void Start()
    {
        // ���� ���������� �̸��� StageManager�� ����
        string currentStageName = "stage1";
        stagemanage.SetCurrentStageName(currentStageName);
    }
}
