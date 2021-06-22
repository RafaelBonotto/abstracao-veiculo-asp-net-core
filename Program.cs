using System;

namespace Veiculo
{
    class Program
    {
        static void Main(string[] args)
        {
            CarroChevrolet novoCarro = new Opala("V6");

            var teste1 = novoCarro.ToString();
            var teste2 = novoCarro.Acelerar();
            var teste3 = novoCarro.Freiar();

            Console.WriteLine(teste1);
            Console.WriteLine(teste2);
            Console.WriteLine(teste3);
        }
    }
}
