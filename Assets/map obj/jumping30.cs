using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class jumping30 : MonoBehaviour
{
    public float jumpForce = 10f; // 플레이어에게 가해질 점프 힘
    public float jumpAngle = 30f; // 점프의 각도 (0도가 수직)

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            Rigidbody2D playerRigidbody = other.GetComponent<Rigidbody2D>();
            if (playerRigidbody != null)
            {
                // 각도를 라디안으로 변환
                float radians = Mathf.Deg2Rad * jumpAngle;

                // 수평 및 수직 방향으로 힘을 계산하여 적용
                Vector2 jumpDirection = new Vector2(Mathf.Cos(radians), Mathf.Sin(radians));
                playerRigidbody.velocity = jumpDirection * jumpForce;
            }
        }
    }
}