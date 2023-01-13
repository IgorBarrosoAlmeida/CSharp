using bytebank_ADM.SistemaInterno;

namespace bytebank_ADM.Funcionarios {
    public abstract class funcionarioAutentivavel: Funcionario, IAutenticavel {
        // Propriedades
        public string Senha { get; set; }
        public string Login { get; set; }

        // Construtores
        protected funcionarioAutentivavel(string cpf, double salario) : base(cpf, salario) { }

        // Métodos
        public bool Autenticar(string login,string senha) {
            return ((this.Senha == senha) && (this.Login == login));
        }

    
    }
}