using SegundaETerceiraMelhoria.Interfaces;

namespace SegundaETerceiraMelhoria.Implementações.Strategy
{
    public class DescontoClienteEspecial : ICalculadoraDesconto
    {
        public decimal AplicaDesconto(decimal valor)
        {
            return valor - (Constantes.DESCONT_CLIENTE_ESPECIAL * valor);

        }
    }
}
