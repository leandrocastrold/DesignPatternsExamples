using FactoryMethodExample.Product;

namespace FactoryMethodExample.ConcreteProduct
{
    public class PlatinumCard : CreditCard
    {
        private readonly string _cardType;
        private double _creditLimite;
        private double _cardAnnuity;
        public PlatinumCard(double creditLimite, double cardAnnuity)
        {
            _cardType = "PLATINUM";
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
