using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gamestart : MonoBehaviour
{
    public GameObject mainCamera; // ī�޶� �����ϱ� ���� ����
    
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(ZoomInAndStartGame());
    }

    IEnumerator ZoomInAndStartGame()
    {
        float targetSize = 5f; // ���ϴ� ���� ũ��
        float zoomSpeed = 20f; // ���� �ӵ�

        while (mainCamera.GetComponent<Camera>().orthographicSize > targetSize)
        {
            mainCamera.GetComponent<Camera>().orthographicSize -= Time.deltaTime * zoomSpeed;
            yield return null;
        }

        // ī�޶� ������ ������ ������ �����մϴ�.
         // ���� ���� UI ��Ȱ��ȭ
        



        // ���Ŀ� ���� ���۰� ���õ� �ʱ�ȭ �ڵ带 �߰��մϴ�.
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
