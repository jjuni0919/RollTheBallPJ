using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gravityreverse : MonoBehaviour
{
     // �߷� ���� ����

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player")) // ���� �÷��̾ Ʈ���ſ� ��Ҵٸ�
        {
            player.isGravityReversed = !player.isGravityReversed; // �߷� ���� ���¸� ���
            UpdateGravity(collision.GetComponent<Rigidbody2D>());
        }
    }

    private void UpdateGravity(Rigidbody2D rb)
    {
        if (player.isGravityReversed)
        {
            rb.gravityScale = -1f; // �߷� ����
        }
        else
        {
            rb.gravityScale = 1f; // �⺻ �߷�
        }
    }
}
