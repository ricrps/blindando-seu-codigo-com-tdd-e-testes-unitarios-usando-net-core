using DioTests;

namespace TestCalculadora
{
    public class CalculadoraTest
    {
        [Theory]
        [InlineData(1, 2, 3)]
        [InlineData(4, 5, 9)]
        [InlineData(18, 2, 20)]
        public void TestSomar(int n1, int n2, int resultadoEsperado)
        {
            var calc = new Calculadora();
            var resultado = calc.Somar(n1, n2);
            Assert.Equal(resultadoEsperado, resultado);
        }

        [Theory]
        [InlineData(10, 2, 8)]
        [InlineData(4, 5, -1)]
        [InlineData(18, 2, 16)]
        public void TestSubtrair(int n1, int n2, int resultadoEsperado)
        {
            var calc = new Calculadora();
            var resultado = calc.Subtrair(n1, n2);
            Assert.Equal(resultadoEsperado, resultado);
        }

        [Theory]
        [InlineData(10, 2, 20)]
        [InlineData(4, 6, 24)]
        [InlineData(18, 2, 36)]
        public void TestMultiplicar(int n1, int n2, int resultadoEsperado)
        {
            var calc = new Calculadora();
            var resultado = calc.Multiplicar(n1, n2);
            Assert.Equal(resultadoEsperado, resultado);
        }

        [Theory]
        [InlineData(10, 2, 5)]
        [InlineData(12, 6, 2)]
        [InlineData(100, 4, 25)]
        public void TestDividir(int n1, int n2, int resultadoEsperado)
        {
            var calc = new Calculadora();
            var resultado = calc.Dividir(n1, n2);
            Assert.Equal(resultadoEsperado, resultado);
        }

        [Fact]
        public void TestDividirPorZero()
        {
            var calc = new Calculadora();
            Assert.Throws<DivideByZeroException>(() => calc.Dividir(10, 0));
        }

        [Fact]
        public void TestGetHistorico()
        {
            var calc = new Calculadora();
            int n1 = 10;
            int n2 = 5;
            var resultadoEsperado = new List<string>
            {
                $"{n1} / {n2} = {n1/n2}",
                $"{n1} * {n2} = {n1*n2}",
                $"{n1} - {n2} = {n1-n2}",
            };

            calc.Somar(n1, n2);
            calc.Subtrair(n1, n2);
            calc.Multiplicar(n1, n2);
            calc.Dividir(n1, n2);

            var resultado = calc.GetHistorico();

            Assert.Equal(resultadoEsperado, resultado);
        }
    }
}