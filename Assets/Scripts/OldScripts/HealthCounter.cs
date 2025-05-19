using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class HealthCounter : MonoBehaviour
{
    public TextMeshProUGUI text;   
    void Update()
    {
        text.text = GameResources.Instance.LifeCount.ToString();
    }
}
