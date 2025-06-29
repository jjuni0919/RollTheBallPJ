using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class stagecharacterload : MonoBehaviour
{
    public Vector3 spawnPosition;
    // Start is called before the first frame update
    void Awake()
    {

        GameObject playerCharacter = Instantiate(MainCharacterSelection.playerCharacterPrefab, spawnPosition, Quaternion.identity);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
