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
            i.Enter();
        }
    }
    void OnTriggerExit(Collider other)
    {
        {
            Interactable i = other.gameObject.GetComponent<Interactable>();
            if (i != null)
            {
                currentItem = i;
                i.Exit();
            }
        }
    }

    private void Start()
    {
        Debug.Log("Spawn point is now: " + UIMananger.Instance.SpawnPoint.position);
    }

}
