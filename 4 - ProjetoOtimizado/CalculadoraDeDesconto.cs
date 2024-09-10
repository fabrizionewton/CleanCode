using ProjetoOtimizado.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoOtimizado
{
    public class CalculadoraDeDesconto
    {
        private readonly ICalculadoraDescontoSatutsContaFactory _calculadoraDescontoSatutsContaFactory;
        private readonly ICalculadoraDescontoPorFidelidade _calculadoraDescontoPorFidelidade;

        public CalculadoraDeDesconto(ICalculadoraDescontoSatutsContaFactory calculadoraDescontoSatutsContaFactory
            ,ICalculadoraDescontoPorFidelidade calculadoraDescontoPorFidelidade)
        {
            _calculadoraDescontoSatutsContaFactory = calculadoraDescontoSatutsContaFactory;
            _calculadoraDescontoPorFidelidade = calculadoraDescontoPorFidelidade;
        }

        public decimal AplicarDesconto(decimal valorOriginal,StatusDaConta tipoDaConta, int tempoDeContaEmAnos)
        {
            var calculadoraDesconto = _calculadoraDescontoSatutsContaFactory.GetCalculosDescontoSatusConta(tipoDaConta);

            var valorComDescontoStatus = calculadoraDesconto.AplicaDesconto(valorOriginal);

            var valorFinal = _calculadoraDescontoPorFidelidade.CalcularDesconto(valorComDescontoStatus, tempoDeContaEmAnos);

            return valorFinal;
        }
    }
}
