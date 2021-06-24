using System;
using System.Collections.Generic;
using System.Text;

namespace Veiculo
{
    public abstract class CarroChevrolet : IVeiculo
    {
        public CarroChevrolet(string motor, Roda _roda, Porta porta, Som som, Banco banco, Pintura pintura)
        {
            this.Motor = motor;
            this.roda = _roda;
            this.porta = porta;
            this.som = som;
            this.banco = banco;
            this.pintura = pintura;
        }

        private string Motor;

        public string _modelo;
        public Roda roda { get; set; }
        public Porta porta { get; set; }
        public Pintura pintura { get; set; }
        public Banco banco { get; set; }
        public Som som { get; set; }        

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

        public string DaSetaPraDireita()
        {
            return "";
        }

        public override string ToString()
        {
            return $"CARRO CHEVROLET - MODELO: {_modelo}\n"+
                $" * RODA ARO:{roda.Aro}, PNEU: {roda._Pneu.Marca} - PERFIL: {roda._Pneu.Perfil} \n" +
                $" * 4 PORTAS: {porta._4portas} \n" +
                $" * PINTURA PERSONALIZADA : {pintura.Personalizada} , COR: {pintura.Cor}, METALICO: {pintura.Metalico}, FOSCO: {pintura.Fosco}\n" +
                $" * BANCO: {banco.Modelo}\n" +
                $" * SOM ORIGINAL: {som.Original} - CAIXA SELADA: {som.CaixaSelada}";
        }

    }
}

//private string _motor { get; set; }

//private string Motor { get { return _motor; } 
//    set {
//        _motor = value + " Meu exemplo";
//     } }
