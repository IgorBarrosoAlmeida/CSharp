using bytebank.Titular;

namespace bytebank.Contas {
    public class ContaCorrente{
        // Atributos
        public Cliente titular;
        public string id;
        public int agencia;
        public double saldo;

        // Métodos
        public void Depositar(double valor){
            this.saldo += valor;
        }

        public bool Sacar(double valor) {
            if(valor > this.saldo){
                return false;
            } else{
                this.saldo -= valor;
                return true;
            }
        }

        public bool Transferir(ContaCorrente destinatario, double valor) {
            if(this.Sacar(valor)) {
                destinatario.Depositar(valor);
                return true;
            } else{
                return false;
            }
        }

        public void ImprimeDados() {
            System.Console.WriteLine("Titular: ");
            System.Console.WriteLine("   Nome: " + this.titular.nome + "\n   CPF: " + this.titular.CPF + "\n   Profissão: " + this.titular.profissao);
            System.Console.WriteLine("ID da conta: " + this.id);
            System.Console.WriteLine("Agência: " + this.agencia);
            System.Console.WriteLine("Saldo: " + this.saldo);
        }
    }
}