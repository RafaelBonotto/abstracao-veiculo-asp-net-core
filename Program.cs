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

            //=====================================================================================================================

            var Opala = new CarroChevrolet("Opala", "6 CILINDRO", novaRoda, novoSom, novaPintura, novaPorta, new Banco(false, "RECARO"));

            Opala.FecharPorta();           
            Opala.LigarVeiculo();
            //Opala.Acelerar(50);
            //Opala.LigarSom();
            //Opala.Freiar();
            //Opala.DesligarVeiculo();
            //Opala.DesligarSom();
            

            Console.WriteLine(Opala.ToString());

            //=====================================================================================================================

            var BMW = new CarroBMW("BMW 320i", "2.0", novaRoda, novoSom, new Pintura("PRETO", true), novaPorta, new Banco(true,null));

            BMW.FecharPorta();
            BMW.LigarVeiculo();
            BMW.LigarSom();
            BMW.Acelerar(100);
            BMW.Freiar();
            BMW.DesligarVeiculo();
            BMW.PagarMulta();
            BMW.LigarVeiculo();
            BMW.Acelerar(30);
            BMW.Freiar();
            BMW.AbrirPorta();
            //BMW.LigarSom();
            BMW.DesligarSom();

            Console.WriteLine(BMW.ToString());

            //======================================================================================================================

            var Volks = new CarroVolkswagen("Golf GTI", "2.0-Turbo", novaRoda, novoSom, novaPintura, novaPorta, novoBanco);

            Volks.FecharPorta();
            Volks.LigarVeiculo();
            Console.WriteLine(Volks.ToString());













        }
    }
}


