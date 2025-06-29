using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    public float bounceForce;  // ������ Ƣ��� �� (���� ����)

    private bool hasBounced = false; // �̹� ƨ�� �������� ���θ� ��Ÿ���� ����

    private Rigidbody2D rb;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        // �̹� ƨ�� ���°� �ƴϰ�, �ӵ��� 0�� ����� ��쿡�� ƨ��� �����ϵ��� ����
        if (!hasBounced && rb.velocity.magnitude < 0.1f)
        {
            rb.AddForce(Vector2.up * bounceForce, ForceMode2D.Impulse);
            hasBounced = true;
        }
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        // �ٴڿ� ����� �� hasBounced�� false�� �����Ͽ� �ٽ� Ƣ�� �����ϰ� ��
        if (collision.gameObject.CompareTag("Ground"))
        {
            hasBounced = false;
        }
    }
}



