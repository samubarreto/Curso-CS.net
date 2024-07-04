using Calculadora.services;

namespace CalculadoraTestes;

public class CalculadoraTestes
{
    private CalculadoraImp _calc;
    public CalculadoraTestes()
    {
        _calc = new CalculadoraImp();
    }

    [Fact]
    public void DeveSomar5Com10ERetornar15()
    {
        // Arrange -> montar cenário
        int num1 = 5;
        int num2 = 10;

        // Act -> somar
        int res = _calc.Somar(num1, num2);

        // Assert -> validar se retornou 15
        Assert.Equal(15, res);
    }

    [Fact]
    public void DeveSomar10Com10ERetornar20()
    {
        // Arrange -> montar cenário
        int num1 = 10;
        int num2 = 10;

        // Act -> somar
        int res = _calc.Somar(num1, num2);

        // Assert -> validar se retornou 20
        Assert.Equal(20, res);
    }

    [Fact]
    public void DeveVerificarSe4EhParERetornarVerdadeiro()
    {
        // Arrange -> montar cenário
        int num = 4;

        // Act -> paridade
        bool res = _calc.EhPar(num);

        // Assert -> validar se 4 é par
        Assert.True(res);
    }

    [Theory]
    [InlineData(new int[] { 2, 4, 6, 8, 10, 12 })]
    public void DeveVerificarSeOsNumerosSaoParesERetornarVerdadeiro(int[] numeros)
    {
        // Act + Assert
        Assert.All(numeros, num => Assert.True(_calc.EhPar(num)));
    }
}