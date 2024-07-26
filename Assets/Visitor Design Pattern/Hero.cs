using System.Collections.Generic;
using UnityEngine;

public class Hero : MonoBehaviour, IVisitable
{
    List<IVisitable> visitableComponents = new List<IVisitable>();

    void Start()
    {
        visitableComponents.Add(gameObject.GetOrAddComponent<HealthComponent>());
        visitableComponents.Add(gameObject.GetOrAddComponent<ManaComponent>());
    }

    public void Accept(IVisitor visitor)
    {
        foreach (var component in visitableComponents)
        {
            component.Accept(visitor);
        }
    }
}