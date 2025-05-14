using UnityEngine;
using UnityEngine.UI;
public class HealthBar : MonoBehaviour
{
    public Slider healthSlider;
    public PlayerInformation playerInfo; // Assign in Inspector

    private void Update()
    {
        SetHealth(playerInfo.health);
    }
    public void SetHealth(int health)
    {
        healthSlider.value = health;
    }
}
