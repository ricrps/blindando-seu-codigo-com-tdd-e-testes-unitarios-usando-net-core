namespace DioTests
{
    public class Calculadora
    {
        public Queue<string> Operacoes = new Queue<string>();

        public int Somar(int n1, int n2)
        {
            var resultado = n1 + n2;
            AddHistorico ($"{n1} + {n2} = {resultado}");
            return resultado;
        }

        public int Subtrair(int n1, int n2)
        {
            var resultado = n1 - n2;
            AddHistorico($"{n1} - {n2} = {resultado}");
            return resultado;
        }

        public int Multiplicar(int n1, int n2)
        {
            var resultado = n1 * n2;
            AddHistorico($"{n1} * {n2} = {resultado}");
            return resultado;
        }

        public int Dividir(int n1, int n2)
        {
            var resultado = n1 / n2;
            AddHistorico($"{n1} / {n2} = {resultado}");
            return resultado;
        }

        public List<string> GetHistorico()
        {
            return Operacoes.Reverse().ToList();
        }

        private void AddHistorico(string operacao)
        {
            Operacoes.Enqueue(operacao);

            if (Operacoes.Count > 3)
            {
                Operacoes.Dequeue();
            }
        }
    }
}
