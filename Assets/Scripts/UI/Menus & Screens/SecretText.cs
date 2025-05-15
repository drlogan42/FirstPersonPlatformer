using TMPro;
using UnityEngine;

public class SecretText : MonoBehaviour
{
    public PlayerDetectionZone detectZone; // Drag this in Inspector
    [SerializeField] private TextMeshProUGUI messageText; // Drag from Canvas

    void Start()
    {        //textMeshProGameObject.SetActive(true); // Make the text active

        messageText.gameObject.SetActive(true);
    }

    void Update()
    {
        messageText.gameObject.SetActive(detectZone.secretObtained);
    }
}
