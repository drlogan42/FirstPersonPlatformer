using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class JewelCounter : MonoBehaviour
{
    public PlayerInformation playerInfo; // Assign in Inspector
    public TextMeshProUGUI text;
    private void Awake()
    {
        // text = GetComponent<Text>();
    }
    void Update()
    {
        text.text = playerInfo.jewels.ToString();
    }
}
