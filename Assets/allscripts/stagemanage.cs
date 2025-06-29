using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class stagemanage : MonoBehaviour
{
    public static string[] stagelist = new string[11] { "stage1", "stage2", "stage3", "stage4", "stage5","stage6", "stage7", "stage8", "stage9", "stage10", "stage11" };
    public static int currentstagenum = 1;
    public static string currentStageName;

    // �� ��ũ��Ʈ���� �������� �̸��� ������ �Լ�
    private void Awake()
    {
        currentStageName = stagelist[currentstagenum-1];
    }
    
    public static void SetCurrentStageName(string stageName)
    {
        currentStageName = stageName;
    }
}
