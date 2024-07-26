using UnityEngine;

public class LightTrigger : MonoBehaviour
{
    public PowerUp powerUp;

    private void OnTriggerEnter(Collider other)
    {
        var visitable = other.GetComponent<Hero>();
        if (visitable != null)
        {
            visitable.Accept(powerUp);
            Debug.Log("Hero entered the light and received a power-up!");
        }
    }

    private void OnTriggerExit(Collider other)
    {
        var visitable = other.GetComponent<Hero>();
        if (visitable != null)
        {
            Debug.Log("Hero exited the light!");
        }
    }
}