using FactoryMethod.ConcreteCreator;
using FactoryMethod.Creator;
using FactoryMethod.Product;
using System;

namespace FactoryMethod
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CartaoFactory cartaoFactory = null;
            Console.WriteLine("Digite o Tipo de Cartão que Gostaria de obter:");
            string console = Console.ReadLine();

            switch (console.ToLower())
            {
                case "black":
                    cartaoFactory = new BlackFactory(50000, 0);
                    break;
                case "titanium":
                    cartaoFactory = new TitaniumFactory(100000, 500);
                    break;
                case "platinum":
                    cartaoFactory = new PlatinumFactory(500000, 1000);
                    break;
            }

            CartaoCredito cartaoCredito =  cartaoFactory.BuscarCartaoCredito();
            Console.WriteLine("\nOs detalhes do seu cartão estão abaixo: \n");
            Console.WriteLine("Tipo do Cartao: {0} \nCredito limite: {1}\nCobrança Anual: {2}",
                cartaoCredito.TipoCartao, cartaoCredito.LimiteCredito, cartaoCredito.CobrancaAnual);
            Console.ReadKey();
        }
    }
}
