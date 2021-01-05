using FactoryMethodExample.ConcreteProduct;
using FactoryMethodExample.Creator;
using FactoryMethodExample.Product;


namespace FactoryMethodExample.ConcreteCreator
{
    public class TitaniumFactory : CardFactory
    {
        private double _creditLimit;
        private double _cardAnnuity;

        public TitaniumFactory(double creditLimit, double cardAnnuity)
        {
            _creditLimit = creditLimit;
            _cardAnnuity = cardAnnuity;
        }
        public override CreditCard SearchCreditCard()
        {
            return new TitaniumCard(_creditLimit, _cardAnnuity);
        }
    }
}

