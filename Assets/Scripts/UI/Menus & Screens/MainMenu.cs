using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.Rendering;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class MainMenu : MonoBehaviour
{
    public Slider sensitivitySlider;
    public Slider volumeSlider;               // Assign in Inspector


    private void Start()
    {
        sensitivitySlider.value = GameResources.Instance.sensitivity;
        sensitivitySlider.onValueChanged.AddListener(OnSliderChanged);

        volumeSlider.value = GameResources.Instance.volume;
        volumeSlider.onValueChanged.AddListener(OnVolumeChanged);
    }

    private void OnSliderChanged(float value)
    {
        GameResources.Instance.sensitivity = value;
    }
    public void playGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 2);
        GameResources.Instance.Health = 100;
        GameResources.Instance.LifeCount = 3;
        GameResources.Instance.JewelCount = 0;
    }

    public void quitGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);

    }
    private void OnVolumeChanged(float value)
    {
        GameResources.Instance.volume = value;
    }
}


