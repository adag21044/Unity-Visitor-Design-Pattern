using UnityEngine;

// Mana component implementing IVisitable

public class ManaComponent : MonoBehaviour, IVisitable
{
    [SerializeField]
    private int mana = 100;

    public int Mana => mana;

    public void Accept(IVisitor visitor)
    {
        visitor.Visit(this);
        Debug.Log("ManaComponent.Accept");
    }

    public void AddMana(int amount)
    {
        mana += amount;
    }
}