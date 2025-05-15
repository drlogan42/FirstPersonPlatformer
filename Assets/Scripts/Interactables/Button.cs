using UnityEngine;
public class Button : Interactable
{
    public override void Press()
    {
        GameManager.Instance.buttonPressed = true;
        this.transform.localPosition = new Vector3(0, -0.075f, 0);
    }
    public override void Release()
    {
        this.transform.localPosition = new Vector3(0, 0, 0);
    }
}
