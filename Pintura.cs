namespace Veiculo
{
    public class Pintura
    {
        public Pintura(string cor, bool fosco)
        {
            this.Cor = cor;
            this.Fosco = fosco;
            if (Fosco) { this.Metalico = false; }
            else { this.Metalico = true; }
        }
        public string Cor { get; set; }
        public bool Fosco{ get; set; }
        public bool Metalico{ get; set; }
    }
}