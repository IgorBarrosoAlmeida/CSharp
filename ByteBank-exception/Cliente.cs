using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank_exception {
    public class Cliente {
        // Atributos e propriedades
        private string _cpf;
        public string Nome { get; set; }
        public string CPF {
            get {
                return _cpf;
            }
            set {
                // Escrevo minha lógica de validação de CPF
                _cpf = value;
            }
        }
        public string Profissao { get; set; }
    }
}
