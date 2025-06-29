using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BallCollision : MonoBehaviour
{
    

    private Collider2D selfCollider;

    private bool cameraFixed = false;
    private Rigidbody2D rb;
    public GameObject shatteredPiecePrefab; // ���� �������� ���⿡ �Ҵ��մϴ�.
    
    void Start()
    {
        selfCollider = GetComponent<Collider2D>();
        rb = GetComponent<Rigidbody2D>();

    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Obstacle"))
        {
            // �ε��� �������� �μ��� �������� �����մϴ�.
            for (int i = 0; i < 10; i++)
            {
                GameObject piece = Instantiate(shatteredPiecePrefab, transform.position, Quaternion.identity);
                Rigidbody2D pieceRigidbody = piece.GetComponent<Rigidbody2D>();

                // ������ ���� ȸ������ ������ �����մϴ�.
                pieceRigidbody.AddForce(new Vector2(Random.Range(-0.5f,0.5f), Random.Range(0f, 2f)), ForceMode2D.Impulse);
                pieceRigidbody.AddTorque(Random.Range(-5f, 5f), ForceMode2D.Impulse);
            }

            // �浹�� ���� �����մϴ�.
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
        // ���� Scene�� �ٽ� �ε��Ͽ� ������ �ٽ� �����մϴ�.
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        
    }
    IEnumerator DelayedAction(float delayTime)
    {

        // delayTime ��ŭ ��ٸ��ϴ�.
        
        yield return new WaitForSeconds(delayTime);
        
        RestartScene();
    }
}
