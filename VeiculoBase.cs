

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
                estado = "NÃO FOI POSSÍVEL DESLIGAR O VEICULO! ELE JÁ ESTÁ DESLIGADO!";
            }

            estado = $"VEICULO DESLIGADO ";
            veiculoLigado = false;
        }

        public void LigarSom()
        {
            somLigado = true;
            estado = $"{estado}\n * SOM LIGADO: True"; 
        }

        public void DesligarSom()
        {
            somLigado = false;
            estado = $"{estado}\n * SOM LIGADO: False";
        }

        public void FecharPorta()
        {
            portaAberta = false;
            estado = $"{estado}\n *PORTA ABERTA: False";

        }

        public void AbrirPorta()
        {
            portaAberta = true;
            estado = $"{estado}\n * PORTA ABERTA: True";

        }
        public void Acelerar(int velocidade)
        {            
            this.velocidade += velocidade;
            estado = $"{estado}\n * VELOCIDADE: {this.velocidade}";

            if (this.velocidade > 50) multa = true; 
        }

        public void Freiar()
        {
            velocidade = 0;
            estado = $"{estado}\n * VELOCIDADE: {velocidade}";
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
