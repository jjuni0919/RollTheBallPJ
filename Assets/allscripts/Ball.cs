using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    public float bounceForce;  // 일정한 튀기는 힘 (조절 가능)

    private bool hasBounced = false; // 이미 튕긴 상태인지 여부를 나타내는 변수

    private Rigidbody2D rb;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        // 이미 튕긴 상태가 아니고, 속도가 0에 가까운 경우에만 튕기기 가능하도록 설정
        if (!hasBounced && rb.velocity.magnitude < 0.1f)
        {
            rb.AddForce(Vector2.up * bounceForce, ForceMode2D.Impulse);
            hasBounced = true;
        }
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        // 바닥에 닿았을 때 hasBounced를 false로 설정하여 다시 튀기 가능하게 함
        if (collision.gameObject.CompareTag("Ground"))
        {
            hasBounced = false;
        }
    }
}



