using UnityEngine;

public class Checkpoint : MonoBehaviour
{
    public PlayerInformation playerInfo; // Assign in Inspector

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            playerInfo.hasCheckpoint = true;
        }


    }
}
