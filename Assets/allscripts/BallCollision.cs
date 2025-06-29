using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BallCollision : MonoBehaviour
{
    

    private Collider2D selfCollider;

    private bool cameraFixed = false;
    private Rigidbody2D rb;
    public GameObject shatteredPiecePrefab; // 조각 프리팹을 여기에 할당합니다.
    
    void Start()
    {
        selfCollider = GetComponent<Collider2D>();
        rb = GetComponent<Rigidbody2D>();

    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Obstacle"))
        {
            // 부딪힌 지점에서 부서진 조각들을 생성합니다.
            for (int i = 0; i < 10; i++)
            {
                GameObject piece = Instantiate(shatteredPiecePrefab, transform.position, Quaternion.identity);
                Rigidbody2D pieceRigidbody = piece.GetComponent<Rigidbody2D>();

                // 랜덤한 힘과 회전력을 조각에 적용합니다.
                pieceRigidbody.AddForce(new Vector2(Random.Range(-0.5f,0.5f), Random.Range(0f, 2f)), ForceMode2D.Impulse);
                pieceRigidbody.AddTorque(Random.Range(-5f, 5f), ForceMode2D.Impulse);
            }

            // 충돌한 공을 제거합니다.
            Renderer renderer = GetComponent<Renderer>();
            Camera.main.GetComponent<camera>().enabled = false;
            selfCollider.enabled = false;
            
            cameraFixed = true;

            if (renderer != null)
                renderer.enabled = false;
            
            StartCoroutine(DelayedAction(2.5f));
        }
    }
    public void RestartScene()
    {
        // 현재 Scene을 다시 로드하여 게임을 다시 시작합니다.
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        
    }
    IEnumerator DelayedAction(float delayTime)
    {

        // delayTime 만큼 기다립니다.
        
        yield return new WaitForSeconds(delayTime);
        
        RestartScene();
    }
}
