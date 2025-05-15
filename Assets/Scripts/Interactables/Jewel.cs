using UnityEngine;
public class Jewel : Interactable
{
    public override void Pickup()
    {
        //Destroy
        Destroy(this.gameObject);
        //Up Counter
        GameResources.Instance.JewelCount += 1;
    }
}
