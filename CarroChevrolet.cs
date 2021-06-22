using System;
using System.Collections.Generic;
using System.Text;

namespace Veiculo
{
    public class CarroChevrolet : IVeiculo
    {
        public CarroChevrolet(string motor)
        {
            this.Motor = motor;
        }

        public string Motor;

        //private string _motor { get; set; }
        //private string Motor { get { return _motor; } 
        //    set {
        //        _motor = value + " Meu exemplo";
        //     } }

        public bool manutencaoLoja(string Motor)
        {
            this.Motor = Motor;
            return true;
        }

        public string Acelerar()
        {
            return "Veiculo Acelerando!";
        }

        public string Freiar()
        {
            return "Veiculo Freiando!"; 
        }

        public string VirarParaDireita()
        {
            return "Veiculo virando para direira!"; 
        }

        public string VirarParaEsquerda()
        {
            return "Veiculo virando para esquerda!";
        }

    }
}
