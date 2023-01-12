namespace bytebank_ADM.Funcionarios {
    public abstract class Funcionario {
        // Propriedades
        public String Nome { get; set; }
        public String Cpf { get; private set; }
        public double Salario { get; protected set; }

        public static int TotalFuncionarios { get; private set; }
    
        // Construtores
        public Funcionario(string cpf, double salario){
            this.Cpf = cpf;
            this.Salario = salario;
            TotalFuncionarios++;
        }

        // Métodos
        public abstract double GetBonificacao(); // Método abstrato

        public virtual void ImprimeDados() {
            System.Console.WriteLine("Nome: " + this.Nome);
            System.Console.WriteLine("CPF: " + this.Cpf);
            System.Console.WriteLine("Salario: " + this.Salario);
            Console.WriteLine("Bonificação: " + GetBonificacao());
            System.Console.WriteLine();
        }

        public abstract void AumentarSalario(); // Método abstrato
    }
}