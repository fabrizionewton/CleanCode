using SegundaETerceiraMelhoria.Interfaces;

namespace SegundaETerceiraMelhoria.Implementações.Strategy
{
    public class DescontoClienteOuro : ICalculadoraDesconto
    {
        public decimal AplicaDesconto(decimal valor)
        {
            return valor - (Constantes.DESCONT_CLIENTE_OURO * valor);
        }
    }
}
