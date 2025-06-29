using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
public class coinUI : MonoBehaviour
{
    public TMP_Text valueText; // UI Text ���
    
    

    private void Awake()
    {
        UpdateValueText();
    }

    // ���� �����ϰ� UI ������Ʈ
    

    // UI �ؽ�Ʈ ������Ʈ
    void UpdateValueText()
    {
        valueText.text = ": "+CharacterSelection.playerCurrency.ToString();
    }
}
