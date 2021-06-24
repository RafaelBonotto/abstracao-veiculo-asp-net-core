namespace Veiculo
{
    public class Pneu
    {
        public Pneu(int perfil, string marca)
        {
            this.Perfil = perfil;
            this.Marca = marca;
        }
        public int Perfil { get; set; }
        public string Marca { get; set; }
    }
}