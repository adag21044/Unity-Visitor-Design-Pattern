// Interface for visitors
public interface IVisitor
{
    void Visit(HealthComponent healthComponent);
    void Visit(ManaComponent manaComponent);
}