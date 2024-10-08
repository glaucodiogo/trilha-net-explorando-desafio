namespace DesafioProjetoHospedagem.Models
{
    public class Suite
    {
        public Suite() { }

        public Suite(ETipoSuite tipoSuite, int capacidade, decimal valorDiaria)
        {
            TipoSuite = tipoSuite;
            Capacidade = capacidade;
            ValorDiaria = valorDiaria;
        }

        public ETipoSuite TipoSuite { get; set; }
        public int Capacidade { get; set; } = 0;
        public decimal ValorDiaria { get; set; } = 0;
    }
}