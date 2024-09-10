using ProjetoOtimizado.Interfaces;

namespace ProjetoOtimizado.Implementações
{
    public class CalculadoraDescontoPorFidelidade : ICalculadoraDescontoPorFidelidade
    {
        public decimal CalcularDesconto(decimal valorOriginal, int tempoDaContaEmAnos)
        {
            decimal percentualDescontoPorFidelidade = 
                (tempoDaContaEmAnos > Constantes.DESCONT_MAXIMO_POR_FIDELIDADE) 
                    ? (decimal)Constantes.DESCONT_MAXIMO_POR_FIDELIDADE / 100
                    : (decimal)tempoDaContaEmAnos / 100;
            var valorComDesconto = valorOriginal - (valorOriginal * percentualDescontoPorFidelidade);

            return valorComDesconto;
        }
    }
}
