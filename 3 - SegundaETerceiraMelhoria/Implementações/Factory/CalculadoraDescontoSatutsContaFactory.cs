using SegundaETerceiraMelhoria.Implementações.Strategy;
using SegundaETerceiraMelhoria.Interfaces;

namespace SegundaETerceiraMelhoria.Implementações.Factory
{
    public class CalculadoraDescontoSatutsContaFactory : ICalculadoraDescontoSatutsContaFactory
    {
        public ICalculadoraDesconto GetCalculosDescontoSatusConta(StatusDaConta statusDaConta)
        {
            ICalculadoraDesconto calcular;

            calcular = statusDaConta switch
            {
                StatusDaConta.ClienteEspecial => new DescontoClienteEspecial(),
                StatusDaConta.ClienteOuro => new DescontoClienteOuro(),
                StatusDaConta.ClienteVip => new DescontoClienteVip(),
                StatusDaConta.ClientePadrao => new DescontoClientePadrao(),
                _ => throw new ArgumentOutOfRangeException()
            };

            return calcular;
        }
    }
}
