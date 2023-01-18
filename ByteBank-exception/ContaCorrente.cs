// using _05_ByteBank;

namespace ByteBank_exception {
    public class ContaCorrente {
        // Atributos e propriedades
        public Cliente Titular { get; set; }
        public static double TaxaOperacao { get; private set; }
        public static int TotalDeContasCriadas { get; private set; }
        private int _agencia;
        public int Agencia {
            get {
                return _agencia;
            }
            private set {
                if (value <= 0)
                {
                    return;
                }

                _agencia = value;
            }
        }
        public int Numero { get; }
        private double _saldo = 100;
        public double Saldo {
            get {
                return _saldo;
            }
            set {
                if (value < 0)
                {
                    return;
                }

                _saldo = value;
            }
        }

        // Construtores
        public ContaCorrente(int agencia, int numero) {
            if(numero <= 0 && agencia <= 0) {
                throw new ArgumentException("Os argumentos agencia e numero devem ser maiores que 0");
            }
            else if(agencia <= 0) {
                throw new ArgumentException("O argumento agencia deve ser maior que 0");
            } else if(numero <= 0) {
                throw new ArgumentException("O argumento numero deve ser maior que 0");
            }

            Agencia = agencia;
            Numero = numero;
            
            TotalDeContasCriadas++;
            TaxaOperacao = 30 /  TotalDeContasCriadas;
        }

        // Métodos
        public bool Sacar(double valor) {
            if (_saldo < valor)
            {
                return false;
            }

            _saldo -= valor;
            return true;
        }

        public void Depositar(double valor) {
            _saldo += valor;
        }

        public bool Transferir(double valor, ContaCorrente contaDestino) {
            if (_saldo < valor)
            {
                return false;
            }

            _saldo -= valor;
            contaDestino.Depositar(valor);
            return true;
        }
    }
}
