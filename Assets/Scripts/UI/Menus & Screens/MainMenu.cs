using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.Rendering;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class MainMenu : MonoBehaviour
{
    public GameSettings settings;
    public Slider sensitivitySlider;
    public Slider volumeSlider;               // Assign in Inspector


    private void Start()
    {
        sensitivitySlider.value = settings.sensitivity;
        sensitivitySlider.onValueChanged.AddListener(OnSliderChanged);

        volumeSlider.value = settings.volume;
        volumeSlider.onValueChanged.AddListener(OnVolumeChanged);
    }

    private void OnSliderChanged(float value)
    {
        settings.sensitivity = value;
    }
    public void playGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 2);
    }

    public void quitGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);

    }
    private void OnVolumeChanged(float value)
    {
        settings.volume = value;
    }
}


