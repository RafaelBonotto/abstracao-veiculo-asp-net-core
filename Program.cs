using System;

namespace Veiculo
{
    class Program
    {
        static void Main(string[] args)
        {
            Roda novaRoda = new Roda(20, "TSW",  new Pneu(40, "PIRELLI"));

            Porta novaPorta = new Porta(true);

            Pintura novaPintura = new Pintura("VERMELHO", false);

            Banco novoBanco = new Banco(true, "RECARO");

            Som novoSom = new Som(false);

            var Opala = new CarroChevrolet("Opala", "6 CILINDRO", novaRoda, novoSom, novaPintura, novaPorta, novoBanco);

            Opala.FecharPorta();           
            Opala.LigarVeiculo();
            Opala.Acelerar(80);
            //Opala.PagarMulta();
            Opala.DesligarVeiculo();
            //Opala.PagarMulta();
            Opala.LigarVeiculo();
            Opala.LigarSom();

            //Opala.AbrirPorta();

            Console.WriteLine(Opala.ToString());

            var BMW = new CarroBMW("BMW 320i", "2.0", novaRoda, novoSom, novaPintura, novaPorta, novoBanco);

            //BMW.FecharPorta();
            BMW.LigarVeiculo();
            BMW.LigarSom();
            BMW.Acelerar(100);
            //BMW.Acelerar(50);
            //BMW.AbrirPorta();

            Console.WriteLine(BMW.ToString());


        }
    }
}


