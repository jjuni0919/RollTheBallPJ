using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movingobstacle : MonoBehaviour
{
    public Transform startPoint;  // 시작 지점의 Transform
    public Transform endPoint;    // 끝 지점의 Transform
    public float speed = 5.0f;    // 이동 속도
    public float waitTime = 2.0f; // 지점 도착 후 대기 시간

    private bool movingToEnd = true; // 현재 이동 방향

    private void Start()
    {
        StartCoroutine(MoveBetweenWaypoints());
    }

    private IEnumerator MoveBetweenWaypoints()
    {
        while (true)
        {
            Transform target = movingToEnd ? endPoint : startPoint;
            Vector3 startPosition = transform.position;
            Vector3 endPosition = target.position;
            float journeyLength = Vector3.Distance(startPosition, endPosition);
            float startTime = Time.time;

            while (transform.position != endPosition)
            {
                float distanceCovered = (Time.time - startTime) * speed;
                float fractionOfJourney = distanceCovered / journeyLength;
                transform.position = Vector3.Lerp(startPosition, endPosition, fractionOfJourney);
                yield return null;
            }

            yield return new WaitForSeconds(waitTime);
            movingToEnd = !movingToEnd;
        }
    }
}