using FactoryMethodExample.ConcreteProduct;
using FactoryMethodExample.Creator;
using FactoryMethodExample.Product;

namespace FactoryMethodExample.ConcreteCreator
{
    public class BlackFactory : CardFactory
    {
        private double _creditLimit;
        private double _cardAnnuity;

        public BlackFactory(double creditLimit, double cardAnnuity)
        {
            _creditLimit = creditLimit;
            _cardAnnuity = cardAnnuity;
        }
        public override CreditCard SearchCreditCard()
        {
            return new BlackCard(_creditLimit, _cardAnnuity);
        }
    }
}
