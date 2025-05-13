using UnityEngine;
using UnityEngine.SceneManagement;

public class WinScreen : MonoBehaviour
{
    private void Update()
    {
        Time.timeScale = 1f;
        Cursor.lockState = CursorLockMode.None;
    }

    public void Back()
    {
        //Reset Life, Position, Checkpoints, Music
        SceneManager.LoadScene(0);
    }
}
