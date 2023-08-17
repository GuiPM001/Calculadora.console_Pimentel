using Application.Services;

namespace Application
{
    public class Operacoes
    {
        public static float Somar(float n1, float n2)
        {
            var resultado = n1 + n2;

            OperacaoService.Salvar("SONA", resultado, DateTime.Now);

            return resultado;
        }

        public static float Subtracao(float n1, float n2)
        {
            var resultado = n1 - n2;

            OperacaoService.Salvar("SUBTRAÇÃO", resultado, DateTime.Now);

            return resultado;
        }

        public static float Divisao(float n1, float n2)
        {
            var resultado = n2 == 0 ? 0 : n1 / n2;

            OperacaoService.Salvar("DIVISÃO", resultado, DateTime.Now);

            return resultado;
        }

        public static float Multiplicacao(float n1, float n2)
        {
            var resultado = n1 * n2;

            OperacaoService.Salvar("MULTIPLICAÇÃO", resultado, DateTime.Now);

            return resultado;
        }
    }
}