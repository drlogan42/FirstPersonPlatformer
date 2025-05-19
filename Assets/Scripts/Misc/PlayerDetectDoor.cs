using System;
using UnityEngine;
using UnityEngine.Serialization;
using UnityEngine.SceneManagement;

public class PlayerDetectDoor : Interactable
{
    [SerializeField] Transform DetectionZone;

    private void Start()
    {
        GameManager.Instance.hasEnteredZone = false;
        GameManager.Instance.secretObtained = false;
    }
    public override void Enter()
    {
        GameManager.Instance.hasEnteredZone = true;
        SceneManager.LoadScene(4);
    }
}