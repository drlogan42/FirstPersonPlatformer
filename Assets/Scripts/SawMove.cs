using System.Collections;
using System.Threading;
using UnityEngine;
using UnityEngine.Serialization;

public class SawMove : MonoBehaviour
{
    [SerializeField] GameObject pointA;
    [SerializeField] GameObject pointB;
    public float speed = 10.0f;
    public float rotSpeed = 360.0f;
    public float delay = 1.0f;
    [SerializeField] GameObject Saw;
    private Vector3 targetPosition;
    public Vector3 velocity = Vector3.zero;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Saw.transform.position = pointA.transform.position;
        targetPosition = pointB.transform.position;
        StartCoroutine(MoveSpike());
    }

    IEnumerator MoveSpike()
    {
        while (true)
        {
            while ((targetPosition - Saw.transform.position).sqrMagnitude > 0.01f)
            {
                Saw.transform.position = Vector3.SmoothDamp(Saw.transform.position, targetPosition, ref velocity, speed * Time.deltaTime);
                yield return null;
            }

            targetPosition = targetPosition == pointA.transform.position ? pointB.transform.position : pointA.transform.position;
            yield return new WaitForSeconds(delay);
        }
    }

    void Update()
    {
            Saw.transform.Rotate(0f, 0f, rotSpeed * Time.deltaTime);
    }
}
