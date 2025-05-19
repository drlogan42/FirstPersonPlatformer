using UnityEngine;
public class Button : Interactable
{
    public override void Enter()
    {
        GameManager.Instance.buttonPressed = true;
        this.transform.localPosition = new Vector3(0, -0.075f, 0);
    }
    public override void Exit()
    {
        this.transform.localPosition = new Vector3(0, 0, 0);
    }
}
