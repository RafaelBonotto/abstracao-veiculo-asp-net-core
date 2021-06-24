namespace Veiculo
{
    public class Roda
    {
        public Roda(int aroParmetro, string modelo, bool pneu, Pneu _pneu)
        {
            this.Aro = aroParmetro;
            this.Modelo = modelo;
            this.Pneu = pneu;
            this._Pneu = _pneu;
        }
        public int Aro { get; set; }
        public string Modelo { get; set; }
        public bool Pneu { get; set; }
        public Pneu _Pneu { get; set; }
    }
}