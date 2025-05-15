using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;    //public static instance of GameManager for Singleton

    public bool buttonPressed;

    private void Awake()    //Singleton of Instance for scripts to reference GameManager anywhere
    {
        Instance = this;
       // buttonPressed = false;
}

 

}
