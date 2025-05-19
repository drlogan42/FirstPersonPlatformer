using System.Collections;
using UnityEngine;
using UnityEngine.Serialization;

public class MovetheSpike : Interactable
{
    [SerializeField] GameObject pointA;
    [SerializeField] GameObject pointB;
    public float speed = 10.0f;
    public float delay = 1.0f;
    [SerializeField] GameObject SpikeLog;
    private Vector3 targetPositionA;
    public Vector3 velocity = Vector3.zero;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        SpikeLog.transform.position = pointA.transform.position;
        targetPositionA = pointB.transform.position;
        StartCoroutine(MoveSpike());
    }

    IEnumerator MoveSpike()
    {
        while (true)
        {
            while ((targetPositionA - SpikeLog.transform.position).sqrMagnitude > 0.01f)
            {
                SpikeLog.transform.position = Vector3.SmoothDamp(SpikeLog.transform.position, targetPositionA, ref velocity, speed * Time.deltaTime);
                yield return null;
            }

            targetPositionA = targetPositionA == pointA.transform.position ? pointB.transform.position : pointA.transform.position;
            yield return new WaitForSeconds(delay);
        }
    }
    public override void Enter()
    {
        GameResources.Instance.Health -= 50;
    }
}
