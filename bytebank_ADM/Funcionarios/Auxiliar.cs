namespace bytebank_ADM.Funcionarios {
    public class Auxiliar : Funcionario {
        // Construtores
        public Auxiliar(string cpf):base(cpf, 2000) { }

        // Métodos
        public override double GetBonificacao() {
            // Retorna a bonificação de 20%
            return this.Salario * 0.20;
        }

        public override void ImprimeDados()
        {   
            // Exemplo de utilização do "base."
            System.Console.WriteLine("Cargo: Auxiliar");
            base.ImprimeDados();
        }

        public override void AumentarSalario(){
            // Aumento de 10% do salario
            this.Salario *= 1.10;
        }
    }
}