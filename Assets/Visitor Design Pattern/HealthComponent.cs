// Health component implementing IVisitable
using UnityEngine;

// Health component implementing IVisitable
public class HealthComponent : MonoBehaviour, IVisitable
{
    [SerializeField]
    private int health = 100;

    public int Health => health;

    public void Accept(IVisitor visitor)
    {
        visitor.Visit(this);
        Debug.Log("HealthComponent.Accept");
    }

    public void AddHealth(int amount)
    {
        health += amount;
    }
}