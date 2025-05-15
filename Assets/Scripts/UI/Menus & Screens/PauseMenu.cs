using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.SceneManagement;
using UnityEngine.Audio;
using UnityEngine.UI;


public class PauseMenu : MonoBehaviour
{
    public InputSystem_Actions UIControls;
    public InputActionProperty Pause;
    public GameObject pauseMenuUI;
    //public AudioMixer audioMixer;

    public GameSettings settings; // Drag the shared asset in the Inspector
    public Slider sensitivitySlider;
    public Slider volumeSlider;               // Assign in Inspector


    private void OnEnable()
    {
        UIControls.Enable();    //Necessary for player input system
    }

    private void OnDisable()
    {
        UIControls.Disable();    //Necessary for player input system
    }
    private void Awake()
    {
        UIControls = new InputSystem_Actions();     //On load set player controls (part of player movement) to the InputSystem_Actions
    }

    private void Start()
    {
        // Initialize the slider's value from the ScriptableObject
        sensitivitySlider.value = settings.sensitivity;

        // Add listener so changing the slider updates the shared value
        sensitivitySlider.onValueChanged.AddListener(OnSliderChanged);

        volumeSlider.value = settings.volume;
        volumeSlider.onValueChanged.AddListener(OnVolumeChanged);
    }
    private void OnSliderChanged(float value)
    {
        settings.sensitivity = value;
    }

    private void OnVolumeChanged(float value)
    {
        settings.volume = value;
    }

    public static bool isPaused = false;
    void Update()
    {
        if (Pause.action.WasPressedThisFrame())
            {
                if (isPaused)
                {
                    ResumeGame();
                } else
                {
                    PauseGame();
                }
             }   
    }

    public void ResumeGame()
    {
        Cursor.lockState = CursorLockMode.Locked;
        pauseMenuUI.SetActive(false);
        Time.timeScale = 1f;
        isPaused = false;
    }

    void PauseGame()
    {
        Cursor.lockState = CursorLockMode.None;
        pauseMenuUI.SetActive(true);
        Time.timeScale = 0f;
        isPaused = true;
    }

    public void LoadMenu()
    {
        Cursor.lockState = CursorLockMode.None;
        pauseMenuUI.SetActive(false);
        Time.timeScale = 1f;
        isPaused = false;
        SceneManager.LoadScene(0);

    }
    public void QuitGame()
    {
        #if UNITY_EDITOR
               UnityEditor.EditorApplication.isPlaying = false;
        #else
                    Application.Quit();        
        #endif
    }

    public void SetVolume (float volume)
    {
       //Debug.Log(volume);
    }
    public void SetSens(float Sens)
    {
        //Debug.Log(Sens);
    }

}
