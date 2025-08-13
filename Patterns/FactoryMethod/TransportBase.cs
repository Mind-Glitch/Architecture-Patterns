namespace Patterns.FactoryMethod;

public abstract class TransportBase : Identifiable, IDeliveryUnit
{
    public virtual void Deliver()
    {
    }

    public virtual void Recall()
    {
    }
}