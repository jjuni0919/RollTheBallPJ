using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainCharacterSelection : MonoBehaviour
{
    public static GameObject playerCharacterPrefab; // ���õ� ĳ���� ������

    public GameObject firstch;
    public Vector3 spawnPosition;

    private void Start()
    {
        
        
        if (playerCharacterPrefab != null)
        {
            // ���õ� ĳ���� �������� �����ϰ� �÷��̾�� ����
            GameObject playerCharacter = Instantiate(playerCharacterPrefab, spawnPosition, Quaternion.identity);
            // �߰����� �ʱ�ȭ �۾��� �ʿ��ϴٸ� ���⿡ �ۼ�
        }
        else
        {
            playerCharacterPrefab = firstch;
            GameObject playerCharacter = Instantiate(playerCharacterPrefab, spawnPosition, Quaternion.identity);

        }
    }

}
