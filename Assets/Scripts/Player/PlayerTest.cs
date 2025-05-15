using UnityEngine;
public class PlayerTest : MonoBehaviour
{
    private Interactable currentItem;
    void OnTriggerEnter(Collider other)
    {   
        Interactable i = other.gameObject.GetComponent<Interactable>();

        if (i != null)
        {
            currentItem = i;
            i.Pickup();
            i.Press();
        }
    }
    void OnTriggerExit(Collider other)
    {
        {
            Interactable i = other.gameObject.GetComponent<Interactable>();
            if (i != null)
            {
                currentItem = i;
                i.Release();
            }
        }
    }

    private void Start()
    {
        Debug.Log("Spawn point is now: " + GameResources.Instance.SpawnPoint.position);
    }

}
