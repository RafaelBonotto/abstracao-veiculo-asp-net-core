

namespace Veiculo
{
    public abstract class VeiculoBase
    {
        public VeiculoBase(string modelo, string motor, Roda roda, Som som, Pintura pintura, Porta porta, Banco banco)
        {            
            this.modelo = modelo;
            this.motor = motor;
            this.veiculoLigado = false;
            this.somLigado = false;
            this.portaAberta = true;
            this.velocidade = 0;
            this.multa = false;
            this.roda = roda;
            this.som = som;
            this.pintura = pintura;
            this.porta = porta;
            this.banco = banco;
            this.estado = "Não foi registrado nenhum estado para esse veiculo!";
        }

        private string motor { get; set; }
        private string modelo { get; set; }
        public string estado { get; set; }
        public bool veiculoLigado { get; set; }
        public bool somLigado { get; set; }
        public bool portaAberta { get; set; }
        public bool multa { get; set; }
        public int velocidade { get; set; }
        public Roda roda { get; set; }
        public Som som { get; set; }
        public Pintura pintura { get; set; }
        public Porta porta { get; set; }
        public Banco banco { get; set; }


        public void LigarVeiculo()
        {
            if (veiculoLigado || portaAberta)
            {
                estado = "NÃO FOI POSSIVEL LIGAR O VEICULO! VERIFIQUE SE ELE JÁ ESTA LIGADO OU SE A PORTA ESTÁ ABERTA!";
                return;
            }
            if (multa)
            {
                estado = "PARA LIGAR O VEICULO É NECESSÁRIO O PAGAMENTO DA MULTA";
                return;
            }
            estado = $"VEICULO LIGADO ";
            veiculoLigado = true;
        }

        public void DesligarVeiculo()
        {
            if (!veiculoLigado)
            {
                estado = $" {estado} \n * NÃO FOI POSSÍVEL DESLIGAR O VEICULO! ELE JÁ ESTÁ DESLIGADO! ";
                return;
            }
            if (velocidade > 0)
            {
                estado = $" {estado} \n * NÃO FOI POSSÍVEL DESLIGAR O VEICULO! É NECESSARIO FREIAR ANTES! ";
                return;
            }

            estado = $"{estado} \n * VEICULO DESLIGADO ";
            veiculoLigado = false;
        }

        public void LigarSom()
        {
            if (somLigado)
            {
                estado = $"{estado}\n * NÃO FOI POSSIVEL LIGAR O SOM! VERIFIQUE SE ELE JÁ ESTÁ LIGADO!";
                return;
            }
            somLigado = true;
            estado = $"{estado}\n * SOM LIGADO: True"; 
        }

        public void DesligarSom()
        {
            if (!somLigado)
            {
                estado = $"{estado}\n * NÃO FOI POSSIVEL DESLIGAR O SOM! VERIFIQUE SE ELE JÁ ESTÁ DESLIGADO!";
                return;
            }
            somLigado = false;
            estado = $"{estado}\n * SOM LIGADO: False";
        }

        public void FecharPorta()
        {
            if (!portaAberta)
            {
                estado = $"{estado}\n * NÃO FOI POSSIVEL FECHAR A PORTA! VERIFIQUE SE ELA JÁ ESTÁ FECHADA!";
                return;
            }
            portaAberta = false;
            estado = $"{estado}\n * PORTA ABERTA: False";

        }

        public void AbrirPorta()
        {
            if (portaAberta)
            {
                estado = $"{estado}\n * NÃO FOI POSSIVEL ABRIR A PORTA! VERIFIQUE SE ELA JÁ ESTÁ ABERTA!";
                return;
            }
            if(velocidade > 0)
            {
                estado = $"{estado}\n * NÃO É POSSIVEL ABRIR A PORTA COM VEICULO EM MOVIMENTO! PARE O CARRO PRIMEIRO!!";
                return;
            }
            portaAberta = true;
            estado = $"{estado}\n * PORTA ABERTA: True";

        }
        public void Acelerar(int velocidade)
        {
            if (!veiculoLigado)
            {
                estado = $"{estado}\n * NÃO É POSSIVEL ACELERAR O VEICULO DESLIGADO!";
                return;
            }
            this.velocidade += velocidade;
            estado = $"{estado}\n * VELOCIDADE: {this.velocidade}";

            if (this.velocidade > 50) multa = true; 
        }

        public virtual void Freiar()
        {
            if (velocidade <= 0)
            {
                estado = $"{estado}\n * NÃO É POSSIVEL FREIAR O VEICULO ELE JÁ ESTÁ PARADO!";
                return;
            }
            velocidade = 0;
            estado = $"{estado}\n * VELOCIDADE: {velocidade}\n * VEICULO PARADO!";
        }

        public void PagarMulta()
        {
            multa = false;
        }

        public override string ToString()
        {
            return $"NOVO VEICULO: - MODELO: {modelo} - {motor}\n" +
                $" * RODA ARO:{roda.Aro}, PNEU: {roda.pneu.Marca} - PERFIL: {roda.pneu.Perfil} \n" +
                $" * 4 PORTAS: {porta._4portas} \n" +
                $" * PINTURA COR: {pintura.Cor}, METALICO: {pintura.Metalico}, FOSCO: {pintura.Fosco}\n" +
                $" * BANCO: {banco.Modelo}\n" +
                $" * SOM ORIGINAL: {som.Original} - CAIXA SELADA: {som.CaixaSelada}\n" +
                $" * MULTA: {multa}\n" +
                $" * ESTADO : {estado}\n" +
                "===================================================================================================================";

        }

    }
}
