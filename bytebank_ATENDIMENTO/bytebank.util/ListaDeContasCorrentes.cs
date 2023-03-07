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
                this.MudaTamanhoArray(this._contas.Length + 1);
            }
            this._contas[this._proximaPosicao] = conta;
            this._proximaPosicao++;
        }

        public void MudaTamanhoArray(int novoTamanho) {
            ContaCorrente[] arrayNovo = new ContaCorrente[novoTamanho];
            
            // Copia as contas já existentes para o array novo
            if(novoTamanho >= this._contas.Length) {
                for(int i = 0; i < this._contas.Length; i++) {
                    arrayNovo[i] = this._contas[i];
                }
            } else {
                for(int i = 0; i < novoTamanho; i++) {
                    arrayNovo[i] = this._contas[i];
                }
            }

            // Passa o array com mais posições pro como array do objeto
            this._contas = arrayNovo;
        }

        public void Remover(ContaCorrente conta) {
            int indice = 0;

            // Busca o indice da conta que deve ser removida
            foreach(ContaCorrente c in this._contas) {
                if(c == conta) {
                    break;
                } else {
                    indice++;
                }
            }

            // Atualiza as posições
            for(int i = indice; i < this._contas.Length-1; i++) {
                _contas[i] = _contas[i + 1];
            }
            this._proximaPosicao--;
            this._contas[this._proximaPosicao] = null;
            this.MudaTamanhoArray(this._contas.Length - 1);
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

        public ContaCorrente RecuperarContaIndice(int indice) {
            if(indice < 0 || indice >= this._proximaPosicao) {
                throw new ArgumentOutOfRangeException(nameof(indice));
            }

            return this._contas[indice];
        }
        
        public int Tamanho {get;}

        public ContaCorrente this[int indice] {
            get {
                return this.RecuperarContaIndice(indice);
            }
        }
    }
}