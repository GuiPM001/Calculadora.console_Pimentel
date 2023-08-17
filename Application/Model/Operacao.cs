namespace Application.Model
{
    public class Operacao
    {
        public Operacao(string nomeOperacao, double resultado, DateTime dataOperacao)
        {
            NomeOperacao = nomeOperacao;
            Resultado = resultado;
            DataOperacao = dataOperacao;
        }

        public int Id { get; set; }
        public string NomeOperacao { get; set; }
        public double Resultado { get; set; }
        public DateTime DataOperacao { get; set; }
    }
}
