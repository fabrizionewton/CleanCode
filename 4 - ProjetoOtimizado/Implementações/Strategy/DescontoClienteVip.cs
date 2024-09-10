using ProjetoOtimizado.Interfaces;

namespace ProjetoOtimizado.Implementações.Strategy
{
    public class DescontoClienteVip : ICalculadoraDesconto
    {
        public decimal AplicaDesconto(decimal valor)
        {
            return valor - (Constantes.DESCONT_CLIENTE_VIP * valor);

        }
    }
}
