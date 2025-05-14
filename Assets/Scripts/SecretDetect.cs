using System;
using UnityEngine;
using UnityEngine.Serialization;
using UnityEngine.SceneManagement;

public class SecretDetect : MonoBehaviour
{
    public PlayerDetectionZone detectZone; // Assign in Inspector
    [SerializeField] string playerTag = "Player";
    [SerializeField] Transform detectionSecret;


    private void Awake()
    {
        detectZone.secretObtained = false;

    }

    private void OnTriggerEnter(Collider DetectionSecret)
    {
        if (DetectionSecret.gameObject.tag == playerTag)
        {
            detectZone.secretObtained = true;

        }
    }
}