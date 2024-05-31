using System;
using Xunit;
using NewTalents;

namespace TestNewTalents
{
    public class UnitTest1
    {
        [Theory]
        [InlineData (1,2,3)]
        [InlineData (4,5,9)]
        public void TesteSomar(int val1, int val2, int resultado)
        {
            Calculadora calc = new Calculadora();

            int resultadoCaluladora = calc.somar(val1, val2);

            Assert.Equal(resultado, resultadoCaluladora);
        }

        [Theory]
        [InlineData(1, 2, 2)]
        [InlineData(4, 5, 20)]
        public void TesteMultiplicar(int val1, int val2, int resultado)
        {
            Calculadora calc = new Calculadora();

            int resultadoCaluladora = calc.multiplicar(val1, val2);

            Assert.Equal(resultado, resultadoCaluladora);
        }

        [Theory]
        [InlineData(6, 2, 3)]
        [InlineData(5, 5, 1)]
        public void TesteDivir(int val1, int val2, int resultado)
        {
            Calculadora calc = new Calculadora();

            int resultadoCaluladora = calc.dividir(val1, val2);

            Assert.Equal(resultado, resultadoCaluladora);
        }

        [Theory]
        [InlineData(6, 2, 4)]
        [InlineData(5, 5, 0)]
        public void TesteSubtrair(int val1, int val2, int resultado)
        {
            Calculadora calc = new Calculadora();

            int resultadoCaluladora = calc.subtrair(val1, val2);

            Assert.Equal(resultado, resultadoCaluladora);
        }

        [Fact]
        public void TestarDivisaoPorZero() 
        {
            Calculadora calc = new Calculadora();

            Assert.Throws<DivideByZeroException>(
                () => calc.dividir(3,0)
                );   // caso não saiba como será adivisãonutliza-se a classe pai Exception no lugar DivideByZeroException
        }

        [Fact]
        public void TestarHistorico()
        {
            Calculadora calc = new Calculadora();

            calc.somar(1, 2);
            calc.somar(2, 8);
            calc.somar(3, 7);
            calc.somar(4, 1);

            var list = calc.historico();
            
            Assert.NotEmpty(calc.historico());
            Assert.Equal(3, list.Count);
        }
    }
}
