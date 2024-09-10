using SegundaETerceiraMelhoria.Interfaces;

namespace SegundaETerceiraMelhoria.Implementações.Strategy
{
    public class DescontoClientePadrao : ICalculadoraDesconto
    {
        public decimal AplicaDesconto(decimal valor)
        {
            return valor;
        }
    }
}
