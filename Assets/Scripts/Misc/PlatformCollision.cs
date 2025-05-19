using UnityEngine;
using UnityEngine.Serialization;

public class PlatformCollision : Interactable
{
    [SerializeField] Transform platform;
    [SerializeField] GameObject player;

    public override void Enter()
    {
        player.gameObject.transform.parent = platform;
    }
    public override void Exit()
    {
        player.gameObject.transform.parent = null;
    }
}
