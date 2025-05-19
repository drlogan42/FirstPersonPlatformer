using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerManager : Interactable
{    
    //Interactions
    private Interactable currentItem;

    // =-=-=-=-=-= Start =-=-=-=-=-=
    private void OnEnable()
    {
        //Defaut Spawn GameResources.Instance.SpawnPoint = transform.position.
    }

    // =-=-=-=-=-= Update =-=-=-=-=-=
    private void Update()
    {
        if (this.transform.position.y <= 0 || GameResources.Instance.Health <= 0)
        {
            OnLoseLife();
        }
    }

    // =-=-=-=-=-= Functions =-=-=-=-=-=
    private void OnLoseLife()
    {
        GameResources.Instance.LifeCount -= 1;
        GameResources.Instance.Health = 100;
        this.transform.position = UIMananger.Instance.SpawnPoint.position;

        if (GameResources.Instance.LifeCount <= 0)
        {
            SceneManager.LoadScene(3);
        }
    }

    // =-=-=-=-=-= Interactions =-=-=-=-=-=
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
}
