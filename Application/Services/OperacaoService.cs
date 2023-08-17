using Application.Context;
using Application.Model;

namespace Application.Services
{
    public class OperacaoService
    {
        public static void Salvar(string nomeOperacao, float resultado, DateTime dataOperacao)
        {
            Console.WriteLine("Salvando dados...");

            var operacao = new Operacao(nomeOperacao, resultado, DateTime.Now);

            SalvarOperacaoNoBanco(operacao);
            SalvarOperacaoNoArquivo(operacao);
        }

        private static void SalvarOperacaoNoBanco(Operacao operacao)
        {
            using var context = new OperacoesContext();

            context.OperacoesHistorico.Add(operacao);
            context.SaveChanges();
        }

        private static void SalvarOperacaoNoArquivo(Operacao operacao)
        {
            var caminhoArquivo = "C:\\Projetos\\Calculadora.console_Pimentel\\ultimo_comando.txt";
            var conteudo = $"{operacao.NomeOperacao} - {operacao.DataOperacao}";

            File.WriteAllText(caminhoArquivo, conteudo);
        }
    }
}
