using UnityEngine;

public class JewelDestroy : MonoBehaviour
{
    public PlayerInformation playerInfo; // Assign in Inspector
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            playerInfo.jewels += 1;
            Destroy(gameObject);
        }

        
    }
}
