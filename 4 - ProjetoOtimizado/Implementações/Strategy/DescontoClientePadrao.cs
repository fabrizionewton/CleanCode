using ProjetoOtimizado.Interfaces;

namespace ProjetoOtimizado.Implementações.Strategy
{
    public class DescontoClientePadrao : ICalculadoraDesconto
    {
        public decimal AplicaDesconto(decimal valor)
        {
            return valor;
        }
    }
}
