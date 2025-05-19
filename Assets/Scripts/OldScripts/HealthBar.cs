using UnityEngine;
using UnityEngine.UI;
public class HealthBar : MonoBehaviour
{
    public Slider healthSlider;
    private void Update()
    {
        SetHealth(GameResources.Instance.Health);
    }
    public void SetHealth(int Health)
    {
        healthSlider.value = Health;
    }
}
