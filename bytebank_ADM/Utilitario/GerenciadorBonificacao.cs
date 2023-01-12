using bytebank_ADM.Funcionarios;

namespace bytebank_ADM.Utilitario {
    class GerenciadorBonificacao {
        public double TotalBonificacao { get; private set; }

        public void Registrar(Funcionario funcionario){
            this.TotalBonificacao += funcionario.GetBonificacao();
        }
    }
}