using FactoryMethodExample.ConcreteProduct;
using FactoryMethodExample.Creator;
using FactoryMethodExample.Product;

namespace FactoryMethodExample.ConcreteCreator
{
    public class PlatinumFactory : CardFactory
    {
        private double _creditLimit;
        private double _cardAnnuity;

        public PlatinumFactory(double creditLimit, double cardAnnuity)
        {
            _creditLimit = creditLimit;
            _cardAnnuity = cardAnnuity;
        }
        public override CreditCard SearchCreditCard()
        {
            return new PlatinumCard(_creditLimit, _cardAnnuity);
        }
    }
}

