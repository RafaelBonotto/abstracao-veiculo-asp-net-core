namespace Veiculo
{
    public class Som
    {
        public Som(bool original)
        {
            this.Original = original;
            if (!Original) _caixaSelada = true;
        }

        public bool Original { get; set; }
        private bool _caixaSelada { get; set; }
        public bool CaixaSelada { get { return _caixaSelada; } set {}}      


    }
}