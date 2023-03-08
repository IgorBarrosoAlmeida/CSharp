namespace bytebank_ATENDIMENTO.bytebank.Exceptions {
    public class ByteBankException : Exception {
        // Construtores
        public ByteBankException() { }
        public ByteBankException(string message) : base(message) { }
        public ByteBankException(string message, Exception inner) : base(message, inner) { }  
        protected ByteBankException(
            System.Runtime.Serialization.SerializationInfo info,
            System.Runtime.Serialization.StreamingContext context) : base(info, context) {}
    }
}