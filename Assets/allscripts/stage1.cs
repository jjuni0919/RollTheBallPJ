using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class stage1 : MonoBehaviour
{
    private void Start()
    {
        // 현재 스테이지의 이름을 StageManager에 저장
        string currentStageName = "stage1";
        stagemanage.SetCurrentStageName(currentStageName);
    }
}
