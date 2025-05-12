using System.Collections;
using UnityEngine;
using UnityEngine.Serialization;

public class MovingPlatformA : MonoBehaviour
{
    [SerializeField] GameObject pointA;
    [SerializeField] GameObject pointB;
    public float speed = 10.0f;
    public float delay = 1.0f;
    [SerializeField] GameObject platform;
    private Vector3 targetPositionA;
    [SerializeField] private ButtonPress buttonScript;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        platform.transform.position = pointA.transform.position;
        targetPositionA = pointB.transform.position;
        StartCoroutine(MovePlatform());

    }

    IEnumerator MovePlatform()
    {
        yield return new WaitUntil(() => buttonScript != null && buttonScript.ButtonPressDown);

        while (true)
        {
            while ((targetPositionA - platform.transform.position).sqrMagnitude > 0.01f)
            {
                platform.transform.position = Vector3.MoveTowards(platform.transform.position, targetPositionA, speed * Time.deltaTime);
                yield return null;
            }

            targetPositionA = targetPositionA == pointA.transform.position ? pointB.transform.position : pointA.transform.position;
            yield return new WaitForSeconds(delay);        
        }
    }
}
