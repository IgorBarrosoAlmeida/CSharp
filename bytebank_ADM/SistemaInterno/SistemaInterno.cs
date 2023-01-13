using bytebank_ADM.Funcionarios;
using System;

namespace bytebank_ADM.SistemaInterno {
    public class SistemaInterno {

        // Métodos
        public bool Logar(IAutenticavel funcionario, string login, string senha) {
            bool autenticado = funcionario.Autenticar(login, senha);

            if(autenticado) {
                Console.WriteLine("Bem vindo ao sistema");
                return true;
            } else{
                Console.WriteLine("Senha ou login incorreto");
                return false;
            }
        }
    }
}