namespace SegundaETerceiraMelhoria.Interfaces
{
    public interface ICalculadoraDescontoPorFidelidade
    {
        decimal CalcularDesconto(decimal valorOriginal, int tempoDaContaEmAnos);
    }
}
