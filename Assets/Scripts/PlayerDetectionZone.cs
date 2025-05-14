using UnityEngine;
using UnityEditor.Build;

[CreateAssetMenu(fileName = "PlayerDetectionZone", menuName = "Player / PlayerDetectionZone")]
public class PlayerDetectionZone : ScriptableObject
{
    public bool hasEnteredZone = false;
    public bool secretObtained = false;
}
