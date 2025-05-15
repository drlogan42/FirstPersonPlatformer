using UnityEngine;
public class Checkpoint : Interactable
{
    public override void Pickup()
    {
        GameResources.Instance.SpawnPoint.position = this.gameObject.transform.position;
        Debug.Log("Spawn point is now: " + GameResources.Instance.SpawnPoint.position);
    }
}
