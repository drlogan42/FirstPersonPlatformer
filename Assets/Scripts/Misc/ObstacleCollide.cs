using UnityEngine;

public class ObstacleCollide : Interactable
{
    public override void Enter()
    {
        GameResources.Instance.Health -= 50;
    }
}
