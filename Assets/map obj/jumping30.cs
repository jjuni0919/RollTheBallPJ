using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class jumping30 : MonoBehaviour
{
    public float jumpForce = 10f; // �÷��̾�� ������ ���� ��
    public float jumpAngle = 30f; // ������ ���� (0���� ����)

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            Rigidbody2D playerRigidbody = other.GetComponent<Rigidbody2D>();
            if (playerRigidbody != null)
            {
                // ������ �������� ��ȯ
                float radians = Mathf.Deg2Rad * jumpAngle;

                // ���� �� ���� �������� ���� ����Ͽ� ����
                Vector2 jumpDirection = new Vector2(Mathf.Cos(radians), Mathf.Sin(radians));
                playerRigidbody.velocity = jumpDirection * jumpForce;
            }
        }
    }
}