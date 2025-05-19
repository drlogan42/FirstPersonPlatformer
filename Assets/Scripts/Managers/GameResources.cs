using TMPro;
using UnityEngine;
using UnityEngine.Audio;

public class GameResources : MonoBehaviour
{
    public static GameResources Instance;    //public static instance of GameResources for Singleton

    //public AudioMixer audioMixer;

    //GameResources Below:
    public int JewelCount;
    public int Health;
    public int LifeCount;

    [Range(10.0f, 100.0f)]
    public float sensitivity = 75.0f;

    [Range(-80.0f, 0.0f)]
    public float volume = 0.0f;

    private void Awake()    //Singleton of Instance for scripts to reference GameResources anywhere
    {
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);
            JewelCount = 0;
            Health = 100;
            LifeCount = 3;
        }
        else if (Instance != this)
        {
            Destroy(gameObject);  // Destroy duplicate
        }
    }   


}