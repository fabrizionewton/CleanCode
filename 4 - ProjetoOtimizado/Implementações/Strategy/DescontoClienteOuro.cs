using ProjetoOtimizado.Interfaces;

namespace ProjetoOtimizado.Implementações.Strategy
{
    public class DescontoClienteOuro : ICalculadoraDesconto
    {
        public decimal AplicaDesconto(decimal valor)
        {
            return valor - (Constantes.DESCONT_CLIENTE_OURO * valor);
        }
    }
}
