using UnityEngine;
using UnityEngine.SceneManagement;

public class QuitMenu : MonoBehaviour
{
    public void BackStart()
    {
        SceneManager.LoadScene(0);
    }


    public void quitGame()
    {
        #if UNITY_EDITOR
                UnityEditor.EditorApplication.isPlaying = false;
        #else
            Application.Quit();        
        #endif
    }
}
