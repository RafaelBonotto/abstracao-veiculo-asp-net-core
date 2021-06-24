using System;

namespace Veiculo
{
    class Program
    {
        static void Main(string[] args)
        {
            Roda novaRoda = new Roda(20, "TSW", true, new Pneu(40, "PIRELLI"));

            Porta novaPorta = new Porta(true);

            Pintura novaPintura = new Pintura(true, "VERMELHO", false, true);

            Banco novoBanco = new Banco(true, "RECARO");

            Som novoSom = new Som(false);

            CarroChevrolet novoCarro = new Opala("V6", novaRoda, novaPorta, novoSom, novoBanco, novaPintura);

            CarroBMW novoCarro2 = new Bmw320 (novaRoda, novaPorta);

            var teste1 = novoCarro.ToString();

            var teste = novoCarro2.ToString();

            var teste2 = novoCarro.Acelerar();
            var teste3 = novoCarro.Freiar();

            Console.WriteLine(teste1);
            Console.WriteLine(teste2);
            Console.WriteLine(teste3);
            Console.WriteLine("TOSTRING() BMW: " + teste);
        }
    }
}
