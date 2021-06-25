namespace Veiculo
{
    public class Roda
    {
        public Roda(int aroParmetro, string modelo, Pneu pneu)
        {
            this.Aro = aroParmetro;
            this.Modelo = modelo;
            this.pneu = pneu;
        }
        public int Aro { get; set; }
        public string Modelo { get; set; }
        public Pneu pneu { get; set; }
    }
}