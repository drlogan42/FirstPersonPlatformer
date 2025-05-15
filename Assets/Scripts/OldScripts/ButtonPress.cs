using UnityEngine;
using UnityEngine.Serialization;

public class ButtonPress : MonoBehaviour
{
    [SerializeField] string playerTag = "Player";
    [SerializeField] Transform Button;
    public bool ButtonPressDown = false;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == playerTag)
        {
            Button.transform.localPosition = new Vector3(0, -0.075f, 0);
            ButtonPressDown = true;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == playerTag)
        {
            Button.transform.localPosition = new Vector3(0, 0, 0);

        }
    }
}


