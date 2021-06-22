using System;
using System.Collections.Generic;
using System.Text;

namespace Veiculo
{
    public interface IVeiculo
    {
        string Acelerar();
        string Freiar();
        string VirarParaDireita();
        string VirarParaEsquerda();
    }
}
