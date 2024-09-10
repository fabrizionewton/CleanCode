using ProjetoOtimizado.Interfaces;

namespace ProjetoOtimizado.Implementações.Strategy
{
    public class DescontoClienteEspecial : ICalculadoraDesconto
    {
        public decimal AplicaDesconto(decimal valor)
        {
            return valor - (Constantes.DESCONT_CLIENTE_ESPECIAL * valor);

        }
    }
}
