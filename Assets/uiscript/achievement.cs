using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class achievement : MonoBehaviour
{
    public TMP_Text valueText; // UI Text 요소
    public string text;
    public int num;
    public GameObject ui1;
    public Button bt1;
    public int reward,listnum;
    private void Awake()
    {
        
        if (stagemanage.currentstagenum >= num+1&& rewardlist.reward[listnum-1])
        {
            ui1.SetActive(true);
            bt1.onClick.AddListener(CoinUp);
            valueText.text = "";
        }
        else if (rewardlist.reward[listnum-1] == false)
        {
            valueText.text = "Clear!";
        }
        else
        {
            UpdateValueText();
        }
    }

    // 값을 변경하고 UI 업데이트
    

    // UI 텍스트 업데이트
    void UpdateValueText()
    {
        int a = stagemanage.currentstagenum - 1;
        valueText.text = a.ToString() + text;
    }
    void CoinUp()
    {
        CharacterSelection.playerCurrency += reward;
        ui1.SetActive(false);
        valueText.text = "Clear!";
        rewardlist.reward[listnum - 1] = false;
    }
}
