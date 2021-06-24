namespace Veiculo
{
    public class Banco
    {
        public Banco(bool personalizado, string modelo)
        {
            this.Original = personalizado;
            this._modelo = modelo;
        }
        public bool Original { get; set; }
        private string _modelo { get; set; }
        public string Modelo { get { return _modelo ; } set { if (Original) _modelo = "ORIGINAL"; } }
    }
}