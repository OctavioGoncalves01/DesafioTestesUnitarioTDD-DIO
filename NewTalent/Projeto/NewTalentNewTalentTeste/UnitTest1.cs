using System;
using NewTalent.Models;
using Xunit;

namespace NewTalentNewTalentTeste
{
    public class CalculadoraTeste
    {
        private Calculadora _calc;
        public CalculadoraTeste() => _calc = new Calculadora();



        /*[Fact]
        public void TesteSomar()
        {
            // Calculadora calc = new Calculadora();
            //Arrang

            //Act
            int resultado = _calc.Somar(1, 2);

            //Assert
            Assert.Equal(3, resultado);
       }
       */
       //Para podemos fazer varios validações podmos usar o Theory

       //Somar
        [Theory]
        [InlineData (1, 2, 3)]
        [InlineData (7, 3, 10)]
        [InlineData (1, 1, 2)]
        public void TesteSomar(int valor1,int valor2, int resultado)
        {
            //Arrange

            //Act
            int resultadoEsparado = _calc.Somar(valor1, valor2);

            //Assert
            Assert.Equal(resultado, resultadoEsparado);
       }

       //Subtrair
        [Theory]
        [InlineData (2, 1, 1)]
        [InlineData (3, 7, -4)]
        [InlineData (5, 1, 4)]
        public void TesteSubtrir(int valor1,int valor2, int resultado)
        {
            //Arrange

            //Act
            int resultadoEsparado = _calc.Subtrair(valor1, valor2);

            //Assert
            Assert.Equal(resultado, resultadoEsparado);
       }


       //Multiplicar
        [Theory]
        [InlineData (1, 2, 2)]
        [InlineData (7, 3, 21)]
        [InlineData (10, 5, 50)]
        public void TesteMultiplicar(int valor1,int valor2, int resultado)
        {
            //Arrange

            //Act
            int resultadoEsparado = _calc.Multiplicar(valor1, valor2);

            //Assert
            Assert.Equal(resultado, resultadoEsparado);
       }

       //Dividir
        [Theory]
        [InlineData (10, 2, 5)]
        [InlineData (50, 2, 25)]
        [InlineData (4, 2, 2)]
        public void TesteDividir(int valor1,int valor2, int resultado)
        {
            //Arrange

            //Act
            int resultadoEsparado = _calc.Dividir(valor1, valor2);

            //Assert
            Assert.Equal(resultado, resultadoEsparado);
       }

       //Divisao com Zero
        [Fact]
        public void TesteDividirComZero()
        {
            //Arrange

            //Act

            //Assert
            Assert.Throws<DivideByZeroException>(
                () => _calc.Dividir(1, 0)
            );
       }


        //Divisao com Zero
        [Fact]
        public void TesteHistoricoDeOperacoes()
        {
            //Arrange
            
           
            //Act
            _calc.Somar(1, 5);
            _calc.Dividir(10, 5);
            _calc.Subtrair(1, 5);
            _calc.Multiplicar(2, 5);
           var lista = _calc.Historico();
            //Assert
            Assert.NotEmpty(lista);
            Assert.Equal(3, lista.Count);
       }






    }
}
