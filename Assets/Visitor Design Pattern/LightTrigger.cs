using UnityEngine;

public class LightTrigger : MonoBehaviour
{
    public PowerUp powerUp;

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("PowerUp.Visit(HealthComponent)");
        var hero = other.GetComponent<Hero>();
        if (hero != null)
        {
            hero.Accept(powerUp);
            Debug.Log("Hero entered the light and received a power-up!");
        }
        
    }

    private void OnTriggerExit(Collider other)
    {   Debug.Log("PowerUp.Visit(HealthComponent)");
        var hero = other.GetComponent<Hero>();
        if (hero != null)
        {
            Debug.Log("Hero exited the light!");
        }
    }
}