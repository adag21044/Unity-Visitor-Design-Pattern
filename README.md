# Unity Visitor Pattern 

This repository demonstrates the implementation of the Visitor design pattern in Unity. The Visitor pattern allows you to add further operations to objects without modifying them. In this example, we have a hero character that can receive power-ups by entering a light trigger or picking up items.

## Project Structure

1. **ComponentExtensions.cs**: Provides an extension method for adding or getting components.
2. **HealthComponent.cs**: Represents the health component of the hero.
3. **Hero.cs**: Represents the hero character with visitable components.
4. **IVisitable.cs**: Interface for visitable components.
5. **IVisitor.cs**: Interface for visitors.
6. **LightTrigger.cs**: Handles the hero entering and exiting the light.
7. **ManaComponent.cs**: Represents the mana component of the hero.
8. **PickUp.cs**: Handles the triggering of power-ups.
9. **PowerUp.cs**: ScriptableObject that defines the power-up behavior.
