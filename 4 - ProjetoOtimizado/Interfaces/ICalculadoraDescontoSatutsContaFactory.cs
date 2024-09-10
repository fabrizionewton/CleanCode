namespace ProjetoOtimizado.Interfaces
{
    public interface ICalculadoraDescontoSatutsContaFactory
    {
        ICalculadoraDesconto GetCalculosDescontoSatusConta(StatusDaConta statusDaConta);
    }
}
