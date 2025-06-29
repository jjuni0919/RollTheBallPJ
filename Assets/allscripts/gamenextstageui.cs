using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class gamenextstageui : MonoBehaviour
{
    public Button next;
    public Button mainmenu;
    public int mapcoin;
    public int mapscore;
    // Start is called before the first frame update
    void Start()
    {
        next.onClick.AddListener(NextStageButton);
        mainmenu.onClick.AddListener(MainMenuButton);
    }

    // Update is called once per frame
    void NextStageButton()
    {
        CharacterSelection.playerCurrency += ingamecoin.ingameco;
        CharacterSelection.playerCurrency += mapcoin;
        mainUI.totalscore+= mapscore;
        stagemanage.currentStageName = stagemanage.stagelist[stagemanage.currentstagenum - 1];
        SceneManager.LoadScene(stagemanage.currentStageName);
        
    }

    void MainMenuButton()
    {
        CharacterSelection.playerCurrency += ingamecoin.ingameco;
        CharacterSelection.playerCurrency += mapcoin;
        mainUI.totalscore += mapscore;
        SceneManager.LoadScene("main");
    }

}
