namespace Veiculo
{
    public class Pintura
    {
        public Pintura(bool personalizada, string cor, bool fosco, bool metalico)
        {
            this.Personalizada = personalizada;
            this.Cor = cor;
            this.Fosco = fosco;
            this.Metalico = metalico;
        }
        public bool Personalizada { get; set; }
        public string Cor { get; set; }
        public bool Fosco{ get; set; }
        public bool Metalico{ get; set; }
    }
}