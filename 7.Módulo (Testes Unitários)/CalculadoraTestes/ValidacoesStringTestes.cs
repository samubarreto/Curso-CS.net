using Calculadora.services;

namespace CalculadoraTestes
{
    public class ValidacoesStringTestes
    {
        private ValidacoesString _validacoes;
        public ValidacoesStringTestes()
        {
            _validacoes = new ValidacoesString();
        }
        [Fact]
        public void DeveContar3CaracteresEmOlaERetornar3()
        {
            // Arrange -> montar cenário
            string palavra = "Ola";

            // Act -> somar
            int res = _validacoes.ContarCaracteres(palavra);

            // Assert -> validar se retornou 3
            Assert.Equal(3, res);
        }
    }
}