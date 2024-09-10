using Microsoft.Extensions.DependencyInjection;
using ProjetoOtimizado;
using ProjetoOtimizado.Implementações;
using ProjetoOtimizado.Implementações.Factory;
using ProjetoOtimizado.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanCode_Tests
{
    public class CalculadoraDeDEscontoTests
    {
        private readonly CalculadoraDeDesconto _calculadoraDeDesconto;
        public CalculadoraDeDEscontoTests()
        {
            //AddTransient garante a criação de novas instâncias para cada teste, promovendo a idependência dos testes.
            var serviceCollection = new ServiceCollection();
            serviceCollection.AddTransient<ICalculadoraDescontoSatutsContaFactory, CalculadoraDescontoSatutsContaFactory>();
            serviceCollection.AddTransient<ICalculadoraDescontoPorFidelidade, CalculadoraDescontoPorFidelidade>();
            serviceCollection.AddTransient<CalculadoraDeDesconto>();
            
            var serviceProvider = serviceCollection.BuildServiceProvider();

            _calculadoraDeDesconto = serviceProvider.GetService<CalculadoraDeDesconto>() ?? throw new InvalidOperationException("A instancia de CalculadoraDeDesconto não pode ser criada.");

        }

        [Theory]
        [InlineData(100,StatusDaConta.ClientePadrao,0,100)]
        [InlineData(100,StatusDaConta.ClienteEspecial,2,88.20)]
        [InlineData(100,StatusDaConta.ClienteOuro,3,67.90)]
        [InlineData(100,StatusDaConta.ClienteVip,5,47.50)]
        public void CalcularDesconto_ValidInputs_ReturnsExpectedResult(decimal valorTotal, StatusDaConta statusDaConta, int tempoDeContaEmAnos, decimal resultadoEsperado)
        {
            //Act - executa o teste
            var resultado = _calculadoraDeDesconto.AplicarDesconto(valorTotal, statusDaConta, tempoDeContaEmAnos);

            //Asert - verifica o resultado do teste
            //precisa de duas casas decimais
            Assert.Equal(resultadoEsperado, resultado,2);
        }

        [Fact]
        public void CalcularDesconto_InvalidSatusDaConta_ThrowsArgumentOutOfRangeException()
        {
            //Arrange - prepara o teste
            var precoProduto = 100m;
            var tempoDeContaEmAnos = 1;
            //status invalido
            var statusDaConta = (StatusDaConta)99;

            //Act & Assert - executa e verifica
            Assert.Throws<ArgumentOutOfRangeException>(()=> _calculadoraDeDesconto.AplicarDesconto(precoProduto,statusDaConta,tempoDeContaEmAnos));
        }
    }
}
