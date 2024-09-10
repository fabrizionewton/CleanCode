using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SegundaETerceiraMelhoria
{
    public class CalculadoraDeDesconto
    {
        public decimal CalcularDesconto(decimal valorOriginal,StatusDaConta tipoDaConta, int tempoDeContaEmAnos)
        {
            decimal valorComDesconto = 0;
            decimal percentualDescontoPorFidelidade = (tempoDeContaEmAnos > Constantes.DESCONT_MAXIMO_POR_FIDELIDADE) ? (decimal)5 / 100 : (decimal)tempoDeContaEmAnos / 100;

            valorComDesconto = tipoDaConta switch
            {
                StatusDaConta.ClienteEspecial => CalcularValorComDesconto(valorOriginal, percentualDescontoPorFidelidade, Constantes.DESCONT_CLIENTE_ESPECIAL),
                StatusDaConta.ClienteOuro => CalcularValorComDesconto(valorOriginal, percentualDescontoPorFidelidade, Constantes.DESCONT_CLIENTE_OURO),
                StatusDaConta.ClienteVip => CalcularValorComDesconto(valorOriginal, percentualDescontoPorFidelidade, Constantes.DESCONT_CLIENTE_VIP),
                StatusDaConta.ClientePadrao => valorOriginal,
                _ => throw new ArgumentOutOfRangeException()
            };

            return valorComDesconto;
        }

        public decimal CalcularValorComDesconto(decimal valorOriginal,decimal percentualDescontoPorFidelidade, decimal percentualDesconto)
        {
            decimal valorComDeconto = valorOriginal - (percentualDesconto * valorOriginal);
            return valorComDeconto - (valorComDeconto * percentualDescontoPorFidelidade);

        }
    }
}
