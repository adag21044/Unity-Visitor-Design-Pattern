﻿using UnityEngine;

[CreateAssetMenu(fileName = "PowerUp", menuName = "PowerUp")]
public class PowerUp : ScriptableObject, IVisitor
{
    public int HealthBonus = 10;
    public int ManaBonus = 10;

    public void Visit(HealthComponent healthComponent)
    {
        healthComponent.health += HealthBonus;
        Debug.Log("PowerUp.Visit(HealthComponent)");
    }

    public void Visit(ManaComponent manaComponent)
    {
        manaComponent.Mana += ManaBonus;
        Debug.Log("PowerUp.Visit(ManaComponent)");
    }
}