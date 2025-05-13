using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerInfo : MonoBehaviour
{
    //Health and Gems and death
    public int Health = 100;

    [SerializeField] string playerTag = "Player";

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Obstacle"))
        {
            Health -= 20;
            Debug.Log("Damage from obstacle trigger.");
        }
    }



    // Update is called once per frame
    void Update()
    {
        Debug.Log(Health);

        if (Health <= 0)
        {
            Debug.Log("Game Over");
            OnGameOver();
        }
    }

    private void OnGameOver()
    {
        SceneManager.LoadScene(3);
    }


}
