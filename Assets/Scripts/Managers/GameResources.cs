using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class GameResources : MonoBehaviour
{
    public static GameResources Instance;    //public static instance of GameResources for Singleton
    public TextMeshProUGUI text;

    //GameResources Below:
    public int JewelCount;
    public int Health;
    public int LifeCount;
    public Transform SpawnPoint; //Need to Configure with Checkpoint Still

    private void Awake()    //Singleton of Instance for scripts to reference GameResources anywhere
    {
        Instance = this;
    }

    private void Update()
    {
        text.text = JewelCount.ToString();
    }

}
