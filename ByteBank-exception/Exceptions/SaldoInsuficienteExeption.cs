namespace ByteBank_exception.Exceptions {
    public class SaldoInsuficienteException : Exception {
        public double Saldo { get; }
        public double ValorSaque { get; }
        // Construtor
        public SaldoInsuficienteException (string mensagem, double saldo, double valorSaque) : base(mensagem) {
            this.Saldo = saldo;
            this.ValorSaque = valorSaque;
        }
    }
}
