using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class scoreUI : MonoBehaviour
{
    public TMP_Text score;
    // Start is called before the first frame update
    private void Awake()
    {
        UpdateValueText();
    }

    // Update is called once per frame
    
    private void UpdateValueText()
    {
        score.text = "Score : "+ mainUI.totalscore.ToString();
    }
}
