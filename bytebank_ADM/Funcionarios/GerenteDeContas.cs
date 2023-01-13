using bytebank_ADM.SistemaInterno;

namespace bytebank_ADM.Funcionarios {
    public class GerenteDeContas : Autenticavel {
        // Construtores
        public GerenteDeContas(string cpf):base(cpf, 4000) { }

        // Métodos
        public override double GetBonificacao() {
            // Retorna a bonificação de 25%
            return this.Salario * 0.25;
        }

        public override void ImprimeDados()
        {   
            // Exemplo de utilização do "base."
            System.Console.WriteLine("Cargo: Gerente de Contas");
            base.ImprimeDados();
        }

        public override void AumentarSalario(){
            // Aumento de 5% do salario
            this.Salario *= 1.05;
        }

        /*public override bool Autenticar(string senha){
            return this.Senha == senha;
        }*/
    }
}