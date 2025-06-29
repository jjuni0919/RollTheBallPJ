using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gamestart : MonoBehaviour
{
    public GameObject mainCamera; // 카메라를 연결하기 위한 변수
    
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(ZoomInAndStartGame());
    }

    IEnumerator ZoomInAndStartGame()
    {
        float targetSize = 5f; // 원하는 줌인 크기
        float zoomSpeed = 20f; // 줌인 속도

        while (mainCamera.GetComponent<Camera>().orthographicSize > targetSize)
        {
            mainCamera.GetComponent<Camera>().orthographicSize -= Time.deltaTime * zoomSpeed;
            yield return null;
        }

        // 카메라 줌인이 끝나면 게임을 시작합니다.
         // 게임 시작 UI 비활성화
        



        // 이후에 게임 시작과 관련된 초기화 코드를 추가합니다.
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
