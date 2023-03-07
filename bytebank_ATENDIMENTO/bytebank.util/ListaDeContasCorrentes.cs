using bytebank.Modelos.Conta;

namespace bytebank_ATENDIMENTO.bytebank.util {
    public class ListaDeContasCorrentes {

        private ContaCorrente[] _contas = null;
        private int _proximaPosicao = 0;

        public ListaDeContasCorrentes(int tamanhoInicial=5) {
            this._contas = new ContaCorrente[tamanhoInicial];
        }

        public void AddConta(ContaCorrente conta) {
            if(this._contas.Length == this._proximaPosicao) {
                this.AumentarArray(this._contas.Length + 1);
            }
            this._contas[this._proximaPosicao] = conta;
            this._proximaPosicao++;
        }

        public void AumentarArray(int tamanhoNecessario) {
            ContaCorrente[] arrayNovo = new ContaCorrente[tamanhoNecessario];
            
            // Copia as contas já existentes para o array novo
            for(int i = 0; i < this._contas.Length; i++) {
                arrayNovo[i] = this._contas[i];
            }

            // Passa o array com mais posições pro como array do objeto
            this._contas = arrayNovo;
        }

        public void PrintArray() {
            foreach(var conta in _contas) {
                System.Console.WriteLine($"Num Agencia: {conta.Numero_agencia}");
                System.Console.WriteLine($"id: {conta.Id}");
                System.Console.WriteLine("");
            }
        }

        public ContaCorrente MaiorSaldo() {
            if(this._contas != null) {
                double maior= -1;
                ContaCorrente conta = null;
                
                for(int i = 0; i < this._contas.Length; i++) {
                    if(maior < this._contas[i].Saldo) {
                        maior = this._contas[i].Saldo;
                        conta = this._contas[i];
                    }
                }

                return conta;
            } else {
                return null;
            }
        }
    }
}