namespace Veiculo
{
    public class Banco
    {
        public Banco(bool original, string modelo)
        {
            this.Original = original;
            if (!Original) { _modelo = modelo; }
            else _modelo = "ORIGINAL";
            //this._modelo = modelo;
        }
        public bool Original { get; set; }
        private string _modelo { get; set; }
        public string Modelo { get { return _modelo; } }//set { if (Original) _modelo = "ORIGINAL"; else { _modelo = _modelo; } } }
    }
}