using FactoryMethodExample.ConcreteCreator;
using FactoryMethodExample.Creator;
using FactoryMethodExample.Product;
using System;

namespace FactoryMethodExample
{
    class Program
    {
        static void Main(string[] args)
        {
            CardFactory cardFactory = null;
            Console.WriteLine("Selecione o tipo de cartão desejado:\n\n1 - BLACK \n2 - PLATINUM\n3 - TITANIUM\n ");
            int userOption = int.Parse(Console.ReadLine());
            switch (userOption)
            {
                case 1:
                    cardFactory = new BlackFactory(5000, 100);
                    break;
                case 2:
                    cardFactory = new PlatinumFactory(10000, 300);
                    break;
                case 3:
                    cardFactory = new TitaniumFactory(50000, 1000);
                    break;
                default:
                    Console.WriteLine("Opção inválida. Operação cancelada");
                    break;
            }

            CreditCard creditCard = cardFactory.SearchCreditCard();
            Console.WriteLine($"Dados do seu novo cartão:\n" +
                $"\nTipo: {creditCard.CardType}\nLimite de Crédito: {creditCard.CreditLimit}\nValor da Anuidade: {creditCard.CardAnnuity}");
        }
    }
}
