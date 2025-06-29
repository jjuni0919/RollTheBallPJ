using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class characterselectbutton : MonoBehaviour
{
    private CharacterSelection characterSelection;
    public Button[] butto;
    public GameObject[] selecteffect;
    public GameObject[] image;
    private int count = 6;
        
    
    // Start is called before the first frame update
    void Start()
    {
        
        characterSelection = GetComponent<CharacterSelection>();
        butto[0].onClick.AddListener(click1);
        butto[1].onClick.AddListener(click2);
        butto[2].onClick.AddListener(click3);
        butto[3].onClick.AddListener(click4);
        butto[4].onClick.AddListener(click5);
        butto[5].onClick.AddListener(click6);
        /*butto[6].onClick.AddListener(click7);
        butto[7].onClick.AddListener(click8);
        butto[8].onClick.AddListener(click9);*/
    }

    // Update is called once per frame
    void click1()
    {
        Debug.Log("1s");
        characterSelection.SelectCharacter(0);
        for(int i = 0; i < count; i++)
        {
            image[i].SetActive(false);
        }
        image[0].SetActive(true);
        for(int i = 0; i < count; i++)
        {
            selecteffect[i].SetActive(false);
        }
        selecteffect[0].SetActive(true);
    }
    void click2()
    {
        characterSelection.SelectCharacter(1);
        
        for (int i = 0; i < count; i++)
        {
            image[i].SetActive(false);
        }
        image[1].SetActive(true);
        for (int i = 0; i < count; i++)
        {
            selecteffect[i].SetActive(false);
        }
        selecteffect[1].SetActive(true);
    }
    void click3()
    {
        characterSelection.SelectCharacter(2);
        
        for (int i = 0; i < count; i++)
        {
            image[i].SetActive(false);
        }
        image[2].SetActive(true);
        for (int i = 0; i < count; i++)
        {
            selecteffect[i].SetActive(false);
        }
        selecteffect[2].SetActive(true);
    }
    void click4()
    {
        characterSelection.SelectCharacter(3);
        
        for (int i = 0; i < count; i++)
        {
            image[i].SetActive(false);
        }
        image[3].SetActive(true);
        for (int i = 0; i < count; i++)
        {
            selecteffect[i].SetActive(false);
        }
        selecteffect[3].SetActive(true);
    }
    void click5()
    {
        characterSelection.SelectCharacter(4);
        if (CharacterSelection.characterUnlocked[4])
        {

            for (int i = 0; i < count; i++)
            {
                image[i].SetActive(false);
            }
            image[4].SetActive(true);
            for (int i = 0; i < count; i++)
            {
                selecteffect[i].SetActive(false);
            }
            selecteffect[4].SetActive(true);
        }
    }
    void click6()
    {
        characterSelection.SelectCharacter(5);
        if (CharacterSelection.characterUnlocked[5])
        {

            for (int i = 0; i < count; i++)
            {
                image[i].SetActive(false);
            }
            image[5].SetActive(true);
            for (int i = 0; i < count; i++)
            {
                selecteffect[i].SetActive(false);
            }
            selecteffect[5].SetActive(true);
        }
    }
    /*void click7()
    {
        characterSelection.SelectCharacter(6);
        image[6].SetActive(true);
        for (int i = 0; i < count; i++)
        {
            image[i].SetActive(false);
        }
        image[6].SetActive(true);
        for (int i = 0; i < count; i++)
        {
            selecteffect[i].SetActive(false);
        }
        selecteffect[6].SetActive(true);
    }
    void click8()
    {
        characterSelection.SelectCharacter(7);
        
        for (int i = 0; i < count; i++)
        {
            image[i].SetActive(false);
        }
        image[7].SetActive(true);
        for (int i = 0; i < count; i++)
        {
            selecteffect[i].SetActive(false);
        }
        selecteffect[7].SetActive(true);
    }
    void click9()
    {
        
        characterSelection.SelectCharacter(8);
        if (CharacterSelection.characterUnlocked[8])
        {
            
            for (int i = 0; i < count; i++)
            {
                image[i].SetActive(false);
            }
            image[8].SetActive(true);
            for (int i = 0; i < count; i++)
            {
                selecteffect[i].SetActive(false);
            }
            selecteffect[8].SetActive(true);
        }
    }*/
}
