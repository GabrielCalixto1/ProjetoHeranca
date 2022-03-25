namespace finaldesemana2.SalaDeAula
{
    
 public class SalaDeAula
    {
        public string NomeProfessor { get; private set; }
        public string Serie { get;}
        public List<Aluno> Alunos { get; private set; }
        public SalaDeAula(string serie, List<Aluno> listaAlunosInicial, string professor)
        {
            NomeProfessor = professor;
            Serie = serie;
            Alunos = listaAlunosInicial;
        }

        public void AdicionarAluno(string nome, DateTime dataNascimento, string cpf){
            Alunos.Add(new Aluno(nome, dataNascimento, cpf));
        }
        public void AdicionarAluno(Aluno aluno){
            Alunos.Add(aluno);
        }
        public void RemoverAluno(string cpf){
            Alunos.RemoveAll(aluno => aluno.CPF == cpf);
        }
        public void MudarProfessor(string nomeProfessor){
            NomeProfessor = nomeProfessor;
        }
    }
    }
}