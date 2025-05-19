using UnityEngine;
using UnityEngine.Audio;

[CreateAssetMenu(fileName = "GameSettings", menuName = "Settings/Game Settings")]
public class GameSettings : ScriptableObject
{
    public AudioMixer audioMixer;

    [Range(10.0f, 100.0f)]
    public float sensitivity = 75.0f;

    [Range(-80.0f, 0.0f)]
    public float volume = 0.0f;


    private void OnEnable()
    {
        audioMixer.SetFloat("volume", volume);
    }
}


