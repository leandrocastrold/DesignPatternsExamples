namespace FactoryMethodExample.Product
{
    public abstract class CreditCard
    {
        public abstract string CardType { get; }
        public abstract double CreditLimit { get; set; }
        public abstract double CardAnnuity { get; set; }
    }
}
