namespace ProjetoOtimizado.Interfaces
{
    public interface ICalculadoraDescontoPorFidelidade
    {
        decimal CalcularDesconto(decimal valorOriginal, int tempoDaContaEmAnos);
    }
}
