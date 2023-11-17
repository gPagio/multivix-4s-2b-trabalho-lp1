namespace _4s_1b_trabalho_lp1.exceptions;

public class CodigoNaoExisteException : Exception
{
    public CodigoNaoExisteException() : base("O código informado não existe!") { }
    public CodigoNaoExisteException(string mensagem) : base(mensagem) { }
    public CodigoNaoExisteException(string mensagem, Exception inner) : base(mensagem, inner) { }
}
