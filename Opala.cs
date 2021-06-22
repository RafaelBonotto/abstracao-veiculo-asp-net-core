using System;
using System.Collections.Generic;
using System.Text;

namespace Veiculo
{
    public class Opala : CarroChevrolet
    {
        public Opala(string motor) : base(motor)
        {
            this.Motor = motor;
        }

        public override string ToString()
        {
            return $"Opala motor: {Motor}";
        }
    }
}
