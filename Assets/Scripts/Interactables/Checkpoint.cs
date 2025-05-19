using UnityEngine;
public class Checkpoint : Interactable
{
    public override void Pickup()
    {
        UIMananger.Instance.SpawnPoint.position = this.gameObject.transform.position + new Vector3(0, 3, 0);
        Debug.Log("Spawn point is now: " + UIMananger.Instance.SpawnPoint.position);
    }
}
