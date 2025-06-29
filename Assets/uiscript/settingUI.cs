using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class settingUI : MonoBehaviour
{
    public Button setting,exit;
    public GameObject newUI;
    // Start is called before the first frame update
    void Start()
    {
        
        setting.onClick.AddListener(SettingButton);
        exit.onClick.AddListener(ExitSettingButton);
    }
    void SettingButton()
    {
        newUI.SetActive(true);
        setting.interactable = false;
    }
    void ExitSettingButton()
    {
        newUI.SetActive(false);
        setting.interactable=true;
    }

    
}
