namespace Patterns.FactoryMethod;

public interface IDeliveryUnit : IIdentifiable
{
    virtual void Deliver(){}
    virtual void Recall(){}
}