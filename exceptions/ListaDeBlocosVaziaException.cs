namespace _4s_1b_trabalho_lp1.exceptions
{
    public class ListaDeBlocosVaziaException : Exception
    {
        public ListaDeBlocosVaziaException() : base("A lista está vazia!") { }
        public ListaDeBlocosVaziaException(string mensagem) : base(mensagem) { }
        public ListaDeBlocosVaziaException(string mensagem, Exception inner): base (mensagem, inner) { }
    }
}
