using Microsoft.Extensions.DependencyInjection;
using ProjetoOtimizado;
using ProjetoOtimizado.Implementações;
using ProjetoOtimizado.Implementações.Factory;
using ProjetoOtimizado.Interfaces;

var serviceProvider = new ServiceCollection()
    .AddScoped<ICalculadoraDescontoSatutsContaFactory,CalculadoraDescontoSatutsContaFactory>()
    .AddScoped<ICalculadoraDescontoPorFidelidade, CalculadoraDescontoPorFidelidade>()
    .AddScoped<CalculadoraDeDesconto>()
    .BuildServiceProvider();

var calculadoraDeDesconto = serviceProvider.GetService<CalculadoraDeDesconto>() ?? throw new InvalidOperationException("A instancia de CalculadoraDeDesconto não pode ser criada.");

decimal valorOriginal = 142m;
int tempoDeContaEmAnos = 3;

decimal precoComDesconto = calculadoraDeDesconto.AplicarDesconto(valorOriginal, StatusDaConta.ClientePadrao, tempoDeContaEmAnos);
Console.WriteLine($"\nCliente Padrão - Preço com Desconto: {precoComDesconto}");

precoComDesconto = calculadoraDeDesconto.AplicarDesconto(valorOriginal, StatusDaConta.ClienteEspecial, tempoDeContaEmAnos);
Console.WriteLine($"\nCliente Especial - Preço com Desconto: {precoComDesconto}");

precoComDesconto = calculadoraDeDesconto.AplicarDesconto(valorOriginal, StatusDaConta.ClienteOuro, tempoDeContaEmAnos);
Console.WriteLine($"\nCliente Ouro - Preço com Desconto: {precoComDesconto}");

precoComDesconto = calculadoraDeDesconto.AplicarDesconto(valorOriginal, StatusDaConta.ClienteVip, tempoDeContaEmAnos);
Console.WriteLine($"\nCliente Vip - Preço com Desconto: {precoComDesconto}");


