namespace _4s_1b_trabalho_lp1.exceptions
{
    public class PedreiraNaoListadaException : Exception
    {
        public PedreiraNaoListadaException() : base ("A pedreira informada não existe no cadastro!") { }
        public PedreiraNaoListadaException(string mensagem) : base(mensagem) { }
        public PedreiraNaoListadaException(string mensagem, Exception inner) : base(mensagem, inner) { }
    }
}
