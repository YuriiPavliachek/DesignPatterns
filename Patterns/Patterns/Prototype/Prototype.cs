namespace Patterns.Prototype
{
    public interface IPrototype<T>
    {
        T Clone();
    }
}
