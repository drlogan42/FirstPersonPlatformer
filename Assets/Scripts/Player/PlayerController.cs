using UnityEngine.SceneManagement;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public PlayerInformation playerInfo; // Assign in Inspector
    public GameObject playerPosition;
    void OnEnable()
    {
        playerInfo.jewels = 0;
        playerInfo.health = 100;
        playerInfo.lives = 3;
        playerInfo.hasCheckpoint = false;
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Obstacle"))
        {
            playerInfo.health -= 50;
        }

        if (other.CompareTag("Checkpoint"))
        {
            //playerInfo.hasCheckpoint = true;
        }
    }
    void Update()
    {
        if (playerPosition.transform.position.y <= 0)
        {
            OnLoseLife();
        }



        if (playerInfo.health <= 0)
        {
            OnLoseLife();
        }
    }


    private void OnLoseLife()
    {
        playerInfo.lives -= 1;
        playerInfo.health = 100;
        if (playerInfo.hasCheckpoint == true)
        {
           // playerPosition.transform.position = new Vector3(94, 47, 100);
        }
        else
        {
           // playerPosition.transform.position = new Vector3(0, 3, 0);

        }

        if (playerInfo.lives <= 0)
        {
            OnGameOver();
        }
    }

    private void OnGameOver()
    {
        SceneManager.LoadScene(3);
    }
}