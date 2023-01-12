namespace bytebank_ADM.Funcionarios {
    public class Designer : Funcionario {
        // Construtores
        public Designer(string cpf):base(cpf, 3000) { }

        // Métodos
        public override double GetBonificacao() {
            // Retorna a bonificação de 17%
            return this.Salario * 0.17;
        }

        public override void ImprimeDados()
        {   
            // Exemplo de utilização do "base."
            System.Console.WriteLine("Cargo: Designer");
            base.ImprimeDados();
        }

        public override void AumentarSalario(){
            // Aumento de 11% do salario
            this.Salario *= 1.11;
        }
    }
}