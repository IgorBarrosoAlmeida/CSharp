using bytebank_ADM.SistemaInterno;

namespace bytebank_ADM.Parceria {
    public class ParceiroComercial : IAutenticavel {
        // Propriedades
        public string Nome { get; set; }
        public string Senha { get; set; }
        public string Login { get; set; }

        // Construtores
        public ParceiroComercial(string login, string senha) {
            this.Login = login;
            this.Senha = senha;
        }

        // Métodos
        public bool Autenticar(string login,string senha) {
            return ((this.Senha == senha) && (this.Login == login));
        }
    }
}