using bytebank_ADM.SistemaInterno;

namespace bytebank_ADM.Funcionarios {
    public class Diretor : funcionarioAutentivavel {
        // Construtores
        public Diretor(string cpf) : base(cpf, 5000) { }

        // Métodos
        public override double GetBonificacao() {
            // Retorna a bonificação de 50%
            return this.Salario * 0.5;
        }

        public override void ImprimeDados()
        {   
            // Exemplo de utilização do "base."
            System.Console.WriteLine("Cargo: Diretor");
            base.ImprimeDados();
        }

        public override void AumentarSalario(){
            // Aumento de 15% do salario
            this.Salario *= 1.15;
        }
    }
}