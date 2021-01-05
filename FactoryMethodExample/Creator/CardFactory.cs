using FactoryMethodExample.Product;

namespace FactoryMethodExample.Creator
{
    public abstract class CardFactory
    {
        public abstract CreditCard SearchCreditCard();
    }
}
