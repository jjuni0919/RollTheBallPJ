using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainCharacterSelection : MonoBehaviour
{
    public static GameObject playerCharacterPrefab; // 선택된 캐릭터 프리팹

    public GameObject firstch;
    public Vector3 spawnPosition;

    private void Start()
    {
        
        
        if (playerCharacterPrefab != null)
        {
            // 선택된 캐릭터 프리팹을 생성하고 플레이어로 설정
            GameObject playerCharacter = Instantiate(playerCharacterPrefab, spawnPosition, Quaternion.identity);
            // 추가적인 초기화 작업이 필요하다면 여기에 작성
        }
        else
        {
            playerCharacterPrefab = firstch;
            GameObject playerCharacter = Instantiate(playerCharacterPrefab, spawnPosition, Quaternion.identity);

        }
    }

}
