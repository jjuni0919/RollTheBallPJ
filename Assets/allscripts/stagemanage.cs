using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class stagemanage : MonoBehaviour
{
    public static string[] stagelist = new string[11] { "stage1", "stage2", "stage3", "stage4", "stage5","stage6", "stage7", "stage8", "stage9", "stage10", "stage11" };
    public static int currentstagenum = 1;
    public static string currentStageName;

    // 이 스크립트에서 스테이지 이름을 설정할 함수
    private void Awake()
    {
        currentStageName = stagelist[currentstagenum-1];
    }
    
    public static void SetCurrentStageName(string stageName)
    {
        currentStageName = stageName;
    }
}
