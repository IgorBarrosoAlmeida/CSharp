namespace bytebank_ADM.Funcionarios {
    class Funcionario {
        // Propriedades
        public String Nome { get; set; }
        public String Cpf { get; set; }
        public double Salario { get; set; }
    
        // Métodos
        public double GetBonificacao() {
            // Retorna a bonificação de 10%
            return this.Salario * 0.10;
        }

        public void ImprimeDados() {
            System.Console.WriteLine("Nome: " + this.Nome);
            System.Console.WriteLine("CPF: " + this.Cpf);
            System.Console.WriteLine("Salario: " + this.Salario);
        } 
    }
}