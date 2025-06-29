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
            // 마우스 클릭 위치를 화면 좌표로 변환
            Vector3 clickPosition = Camera.main.ScreenToViewportPoint(Input.mousePosition);
            
            // 화면 너비의 절반을 기준으로 왼쪽과 오른쪽을 구분
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

            // 화면 너비의 절반을 기준으로 왼쪽과 오른쪽을 구분
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
        // 속도 벡터의 크기가 최대 속도를 넘지 않도록 제한합니다.
        if (rb2d.velocity.magnitude > maxSpeed)
        {
            rb2d.velocity = rb2d.velocity.normalized * maxSpeed;
        }
    }
    private void OnCollisionStay2D(Collision2D collision)
    {
        // "Ground" 태그를 가진 오브젝트와 충돌했을 때 isGrounded를 true로 설정
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
        // "Ground" 태그를 가진 오브젝트와의 충돌이 끝났을 때 isGrounded를 false로 설정
        if (collision.gameObject.CompareTag("Ground"))
        {
            isGrounded = false;
        }
        
    }
    


}

