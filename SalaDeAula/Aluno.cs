namespace finaldesemana2.SalaDeAula
{
    public class Aluno
    {
        public string CPF { get; }
        public string Nome { get; }
        public DateTime DataDeNascimento { get; }

        public Aluno(string nome, DateTime dataNascimento, string cpf)
        {
            Nome = nome;
            DataDeNascimento = dataNascimento;
            CPF = cpf;
        }
    }
}
