using bytebank_ADM.Funcionarios;

namespace bytebank_ADM.Utilitario {
    class GerenciadorBonificacao {
        // Propriedades
        public double TotalBonificacao { get; private set; }

        // Métodos
        public void Registrar(Funcionario funcionario){
            this.TotalBonificacao += funcionario.GetBonificacao();
        }
    }
}