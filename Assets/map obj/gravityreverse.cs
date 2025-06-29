using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gravityreverse : MonoBehaviour
{
     // 중력 반전 여부

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player")) // 만약 플레이어가 트리거에 닿았다면
        {
            player.isGravityReversed = !player.isGravityReversed; // 중력 반전 상태를 토글
            UpdateGravity(collision.GetComponent<Rigidbody2D>());
        }
    }

    private void UpdateGravity(Rigidbody2D rb)
    {
        if (player.isGravityReversed)
        {
            rb.gravityScale = -1f; // 중력 반전
        }
        else
        {
            rb.gravityScale = 1f; // 기본 중력
        }
    }
}
