using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;    //public static instance of GameManager for Singleton

    public bool buttonPressed;
    public bool hasEnteredZone;
    public bool secretObtained;
    private void Awake()    //Singleton of Instance for scripts to reference GameManager anywhere
    {
        Instance = this;
    }
}
