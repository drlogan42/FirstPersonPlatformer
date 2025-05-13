using UnityEngine;
using UnityEngine.Serialization;
using UnityEngine.SceneManagement;
public class PlatformCollisionCode : MonoBehaviour
{
    [SerializeField] string playerTag = "Player";
    [SerializeField] Transform platformA;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == playerTag)
        {
            other.gameObject.transform.parent = platformA;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == playerTag)
        {
            other.gameObject.transform.parent = null;
        }
    }

}


