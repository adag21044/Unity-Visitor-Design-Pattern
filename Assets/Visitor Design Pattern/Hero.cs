using System.Collections.Generic;
using UnityEngine;

public class Hero : MonoBehaviour, IVisitable
{
    private List<IVisitable> visitableComponents;

    private void Start()
    {
        visitableComponents = new List<IVisitable>
        {
            gameObject.GetOrAddComponent<HealthComponent>(),
            gameObject.GetOrAddComponent<ManaComponent>()
        };
    }

    public void Accept(IVisitor visitor)
    {
        foreach (var component in visitableComponents)
        {
            component.Accept(visitor);
        }
    }
}