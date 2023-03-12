namespace ByteBank_exception.Exceptions {
    public class OperacaoFinanceiraException : Exception {
        // Construtores
        public OperacaoFinanceiraException()
        { }

        public OperacaoFinanceiraException(string mensagem) : base(mensagem)
        { }
    
        public OperacaoFinanceiraException(string mensagem, Exception excecaoInterna) : base(mensagem, excecaoInterna)
        { }
    }
}
