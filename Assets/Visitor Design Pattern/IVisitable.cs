// Interface for visitable components
public interface IVisitable
{
    void Accept(IVisitor visitor);
}