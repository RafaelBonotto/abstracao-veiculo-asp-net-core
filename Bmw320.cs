namespace Veiculo
{
    public class Bmw320 : CarroBMW
    {
        public Bmw320(Roda roda, Porta porta) : base(roda, porta)
        {
            this.roda = roda;
            this.porta = porta;
        }
        
    }
}