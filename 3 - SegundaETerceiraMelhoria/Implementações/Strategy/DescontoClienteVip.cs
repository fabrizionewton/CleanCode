using SegundaETerceiraMelhoria.Interfaces;

namespace SegundaETerceiraMelhoria.Implementações.Strategy
{
    public class DescontoClienteVip : ICalculadoraDesconto
    {
        public decimal AplicaDesconto(decimal valor)
        {
            return valor - (Constantes.DESCONT_CLIENTE_VIP * valor);

        }
    }
}
