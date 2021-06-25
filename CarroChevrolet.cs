using System;
using System.Collections.Generic;
using System.Text;

namespace Veiculo
{
    public class CarroChevrolet : VeiculoBase   
    {
        public CarroChevrolet(string modelo, string motor, Roda roda, Som som, Pintura pintura, Porta porta, Banco banco) : 
            base(modelo, motor, roda, som, pintura, porta, banco)
        {
            this.roda = roda;
            this.som = som;
            this.pintura = pintura;
            this.porta = porta;
            this.banco = banco;
        }
        
    }
}

