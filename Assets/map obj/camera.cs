using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class camera : MonoBehaviour
{
    private Transform ballTransform;
    public string playerTag = "Player";

    private float cameraHeightOffset = 1f; // 공 위의 카메라 높이 오프셋
    private float cameraSmoothSpeed = 33330f; // 카메라 이동 속도

    private Vector3 targetPosition; // 카메라가 이동할 목표 위치

    
    private void LateUpdate()
    {
        GameObject player = GameObject.FindGameObjectWithTag(playerTag);
        if (player == null)
        {
            return;
        }

        // 공의 현재 위치를 가져옵니다.
        Vector3 ballPosition = player.transform.position;

        // 카메라의 목표 위치를 공의 현재 위치에 높이 오프셋을 더한 값으로 설정합니다.
        targetPosition = new Vector3(ballPosition.x, ballPosition.y + cameraHeightOffset, transform.position.z);

        // 카메라를 부드럽게 이동시킵니다.
        transform.position = Vector3.Lerp(transform.position, targetPosition, cameraSmoothSpeed * Time.deltaTime);
    }
}
