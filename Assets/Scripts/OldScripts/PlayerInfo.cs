using UnityEditor.Build;
using UnityEngine;

[CreateAssetMenu(fileName = "PlayerInformation", menuName = "Player / Player Info")]
public class PlayerInformation : ScriptableObject
{
    public int health = 100;
    public int lives = 3;
    public int jewels = 0;
    public bool hasCheckpoint = false;

    //If main menu then reset checkpoint, lives and health
    
}


