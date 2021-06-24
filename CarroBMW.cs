namespace Veiculo
{
    public class CarroBMW : IVeiculo
    {
        
        public CarroBMW(Roda roda, Porta porta)
        {
            this.roda = roda;
            this.porta = porta;
        }

        private string Motor;

        public string _modelo;
        public Roda roda { get; set; }
        public Porta porta { get; set; }
        public Pintura pintura { get; set; }
        public Banco banco { get; set; }
        public Som som { get; set; }
        public string Acelerar()
        {
            
            return "  ";
        }

        public string Freiar()
        {
            throw new System.NotImplementedException();
        }

        public string VirarParaDireita()
        {
            throw new System.NotImplementedException();
        }

        public string VirarParaEsquerda()
        {
            throw new System.NotImplementedException();
        }

        public string DaSetaPraDireita()
        {
            return "";
        }

        public override string ToString()
        {
            return $"RODA ARO: {this.roda.Aro}, RODTEM PNUE: {roda.Pneu} PORTA: {this.porta._4portas}";
        }
    }
}