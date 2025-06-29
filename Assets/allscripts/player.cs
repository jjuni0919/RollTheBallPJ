using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player : MonoBehaviour
{
    public static bool isGravityReversed = false;
    private Rigidbody2D rb2d;
    public float rollForce = 10f;
    public float maxSpeed = 5f;
    public AudioSource audioSource;
    private bool isGrounded = false;
    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
        audioSource.Pause();
    }

    void Update()
    {
        
        if (Input.GetMouseButton(0) && isGrounded)
        {
            // ���콺 Ŭ�� ��ġ�� ȭ�� ��ǥ�� ��ȯ
            Vector3 clickPosition = Camera.main.ScreenToViewportPoint(Input.mousePosition);
            
            // ȭ�� �ʺ��� ������ �������� ���ʰ� �������� ����
            if(clickPosition.y < 0.9f)
            {
                if (clickPosition.x < 0.5f)
                {
                    rb2d.AddForce(Vector2.left * rollForce, ForceMode2D.Impulse);
                }
                else
                {
                    rb2d.AddForce(Vector2.right * rollForce, ForceMode2D.Impulse);
                }
            }
            
        }
        else if (Input.GetMouseButton(0) && !isGrounded)
        {
            Vector3 clickPosition = Camera.main.ScreenToViewportPoint(Input.mousePosition);

            // ȭ�� �ʺ��� ������ �������� ���ʰ� �������� ����
            if (clickPosition.y < 0.9f)
            {
                if (clickPosition.x < 0.5f)
                {
                    rb2d.AddForce(Vector2.left * 0.3f * rollForce, ForceMode2D.Impulse);
                }
                else
                {
                    rb2d.AddForce(Vector2.right * 0.3f * rollForce, ForceMode2D.Impulse);
                }
            }
        }
    }
    private void FixedUpdate()
    {
        // �ӵ� ������ ũ�Ⱑ �ִ� �ӵ��� ���� �ʵ��� �����մϴ�.
        if (rb2d.velocity.magnitude > maxSpeed)
        {
            rb2d.velocity = rb2d.velocity.normalized * maxSpeed;
        }
    }
    private void OnCollisionStay2D(Collision2D collision)
    {
        // "Ground" �±׸� ���� ������Ʈ�� �浹���� �� isGrounded�� true�� ����
        if (collision.gameObject.CompareTag("Ground"))
        {
            isGrounded = true;
        }
        
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Wall") && audioscript.soundeffect)
        {
            audioSource.Play();
        }
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        // "Ground" �±׸� ���� ������Ʈ���� �浹�� ������ �� isGrounded�� false�� ����
        if (collision.gameObject.CompareTag("Ground"))
        {
            isGrounded = false;
        }
        
    }
    


}

