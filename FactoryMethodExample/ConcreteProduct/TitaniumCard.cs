using FactoryMethodExample.Product;

namespace FactoryMethodExample.ConcreteProduct
{
    public class TitaniumCard : CreditCard
    {
        private readonly string _cardType;
        private double _creditLimite;
        private double _cardAnnuity;
        public TitaniumCard(double creditLimite, double cardAnnuity)
        {
            _cardType = "TITANIUM";
            _creditLimite = creditLimite;
            _cardAnnuity = cardAnnuity;
        }

        public override string CardType
        {
            get { return _cardType; }
        }
        public override double CreditLimit
        {
            get { return _creditLimite; }
            set { _creditLimite = value; }
        }
        public override double CardAnnuity
        {
            get { return _cardAnnuity; }
            set { _cardAnnuity = value; }
        }
    }
}
