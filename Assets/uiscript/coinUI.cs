using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
public class coinUI : MonoBehaviour
{
    public TMP_Text valueText; // UI Text 요소
    
    

    private void Awake()
    {
        UpdateValueText();
    }

    // 값을 변경하고 UI 업데이트
    

    // UI 텍스트 업데이트
    void UpdateValueText()
    {
        valueText.text = ": "+CharacterSelection.playerCurrency.ToString();
    }
}
