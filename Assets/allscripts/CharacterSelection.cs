using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.TextCore.Text;
using UnityEngine.UI;

public class CharacterSelection : MonoBehaviour
{
    public GameObject[] characterIcons; // 캐릭터 아이콘들을 저장할 배열
    public static GameObject selectedCharacter;
    
    public GameObject purchaseUI;
    public static bool[] characterUnlocked;
    private int[] unlockCosts;
    private int currentindex;
   
    public Button purchasebut;
    public Button nobut;
    public static int playerCurrency = 0;
    public TMP_Text valueText;


    private void Awake()
    {
        
        purchasebut.onClick.AddListener(Purchase);
        nobut.onClick.AddListener(Exit);
        characterUnlocked = new bool[characterIcons.Length];
        unlockCosts = new int[characterIcons.Length];
        if (selectedCharacter == null)
        {
            selectedCharacter = characterIcons[0];
        }
        for(int i =0; i<4;i++)
        {
            characterUnlocked[i] = true;
        }
        for (int i = 4; i < 12; i++)
        {
            unlockCosts[i] = 500;
        }
        for (int i = 12; i < 16; i++)
        {
            unlockCosts[i] = 1000;
        }
        for (int i = 16; i < 21; i++)
        {
            unlockCosts[i] = 1500;
        }
        Debug.Log(playerCurrency);
        UpdateValueText();
    }
   
    
    public void SelectCharacter(int characterIndex)
    {
        currentindex = characterIndex;
        if (characterUnlocked[characterIndex])
        {
            // 캐릭터 선택 로직
            selectedCharacter = characterIcons[characterIndex];
        }
        else
        {
            if (playerCurrency >= unlockCosts[characterIndex])
            {
                purchaseUI.SetActive(true);
                
                // 잠금 해제 가능한 재화가 충분할 경우
                
                
            }
            else
            {
                // 재화 부족 시 처리
            }
        }
    }
    private void Purchase()
    {
        playerCurrency -= unlockCosts[currentindex];
        characterUnlocked[currentindex] = true;
        UpdateValueText();
        purchaseUI.SetActive(false);
    }
    private void Exit()
    {
        purchaseUI.SetActive(false);
    }
    private void UpdateValueText()
    {
        valueText.text = ": " + playerCurrency.ToString();
    }
}