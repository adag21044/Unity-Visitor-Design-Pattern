using UnityEngine;

// Light trigger class to handle hero entering and exiting the light
public class LightTrigger : MonoBehaviour
{
    public PowerUp PowerUp;

    private void OnTriggerEnter(Collider other)
    {
        var hero = other.GetComponent<Hero>();
        if (hero != null)
        {
            hero.Accept(PowerUp);
            Debug.Log("Hero entered the light and received a power-up!");
        }
    }

    private void OnTriggerExit(Collider other)
    {
        var hero = other.GetComponent<Hero>();
        if (hero != null)
        {
            Debug.Log("Hero exited the light!");
        }
    }
}