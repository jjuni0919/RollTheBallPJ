using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class camera : MonoBehaviour
{
    private Transform ballTransform;
    public string playerTag = "Player";

    private float cameraHeightOffset = 1f; // �� ���� ī�޶� ���� ������
    private float cameraSmoothSpeed = 33330f; // ī�޶� �̵� �ӵ�

    private Vector3 targetPosition; // ī�޶� �̵��� ��ǥ ��ġ

    
    private void LateUpdate()
    {
        GameObject player = GameObject.FindGameObjectWithTag(playerTag);
        if (player == null)
        {
            return;
        }

        // ���� ���� ��ġ�� �����ɴϴ�.
        Vector3 ballPosition = player.transform.position;

        // ī�޶��� ��ǥ ��ġ�� ���� ���� ��ġ�� ���� �������� ���� ������ �����մϴ�.
        targetPosition = new Vector3(ballPosition.x, ballPosition.y + cameraHeightOffset, transform.position.z);

        // ī�޶� �ε巴�� �̵���ŵ�ϴ�.
        transform.position = Vector3.Lerp(transform.position, targetPosition, cameraSmoothSpeed * Time.deltaTime);
    }
}
