using TMPro;
using TMPro.EditorUtilities;
using UnityEngine;
using UnityEngine.UI;

public class UIMananger : MonoBehaviour
{
    public static UIMananger Instance;    //public static instance of GameResources for Singleton

    public TextMeshProUGUI jewelcountertext;
    public TextMeshProUGUI lifecountertext;
    public Slider healthSlider;
    public Transform SpawnPoint; //Need to Configure with Checkpoint Still
    private void Awake()
    {
        Instance = this;
    }
    private void Update()
    {
        SetHealth(GameResources.Instance.Health);
        jewelcountertext.text = GameResources.Instance.JewelCount.ToString();
        lifecountertext.text = GameResources.Instance.LifeCount.ToString();
    }

    
    public void SetHealth(int Health)
    {
       healthSlider.value = Health;
    }
}
