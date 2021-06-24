using System;
using System.Collections.Generic;
using System.Text;

namespace Veiculo
{
    public interface IVeiculo
    {
        string LigarCarro();
        string DesligarCarro();
        string Acelerar();
        string Freiar();
        string VirarParaDireita();
        string VirarParaEsquerda();
        string DaSetaPraDireita();
        string DaSetaPraEsquerda();
        string CavaloDePau();
        string AbrirPorta();
        string FecharPorta();

    }
}
