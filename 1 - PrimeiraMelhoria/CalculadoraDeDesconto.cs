using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeiraMelhoria
{
    public class CalculadoraDeDesconto
    {
        public decimal CalcularDesconto(decimal valorOriginal,int tipoDaConta, int tempoDeContaEmAnos)
        {
            decimal valorComDesconto = 0;
            decimal percentualDescontoPorFidelidade = (tempoDeContaEmAnos > 5) ? (decimal)5 / 100 : (decimal)tempoDeContaEmAnos / 100; ;

            if (tipoDaConta == 1) { valorComDesconto = valorOriginal; }

            else if (tipoDaConta == 2)
            {
                valorComDesconto = (valorOriginal - (0.1m * valorOriginal)) - percentualDescontoPorFidelidade * (valorOriginal - (0.1m * valorOriginal));
            }
            else if (tipoDaConta == 3)
            {
                valorComDesconto = (0.7m * valorOriginal) - percentualDescontoPorFidelidade * (0.7m * valorOriginal);
            }
            else if (tipoDaConta == 4)
            {
                valorComDesconto = (valorOriginal - (0.5m * valorOriginal)) - percentualDescontoPorFidelidade * (valorOriginal - (0.5m * valorOriginal));
            }

            return valorComDesconto;
        }
    }
}
