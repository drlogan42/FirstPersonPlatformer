using System;
using UnityEngine;
using UnityEngine.Serialization;
using UnityEngine.SceneManagement;

public class SecretDetect : Interactable
{
    [SerializeField] Transform detectionSecret;
   public override void Enter()
    {
        GameManager.Instance.secretObtained = true;
    }
}