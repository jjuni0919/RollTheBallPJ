using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class characterdecision : MonoBehaviour
{
    public Button select;
    // Start is called before the first frame update
    void Start()
    {
        select.onClick.AddListener(Click);
    }

    // Update is called once per frame

    public void Click()
    {
        MainCharacterSelection.playerCharacterPrefab = CharacterSelection.selectedCharacter;
    }
}
