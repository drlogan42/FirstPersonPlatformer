using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class HealthCounter : MonoBehaviour
{
    public PlayerInformation playerInfo; // Assign in Inspector
    public TextMeshProUGUI text;
    private void Awake()
    {
       // text = GetComponent<Text>();
    }
    void Update()
    {
        text.text = playerInfo.lives.ToString();
    }
}
