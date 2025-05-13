using System;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Serialization;

public class PlayerDetectDoor : MonoBehaviour
{
    private Animator animator;
    [SerializeField] string playerTag = "Player";
    [SerializeField] Transform DetectionZone;

    void Start()
    {
        animator = GetComponent<Animator>();
    }

    private void OnTriggerEnter(Collider DetectionZone)
    {
        if (DetectionZone.gameObject.tag == playerTag)
        {
            Debug.Log("DETECTED");
           //animator.Play("open");
            SceneManager.LoadScene(4);

        }
    }
}
