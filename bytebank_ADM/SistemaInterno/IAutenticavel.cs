using bytebank_ADM.Funcionarios;

namespace bytebank_ADM.SistemaInterno {
    public interface IAutenticavel{
        // Propriedades
        public string Senha { get; set; }
        public string Login { get; set; }

        // Métodos
        public bool Autenticar(string login,string senha);
    }
}