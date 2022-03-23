namespace finaldesemana2.Pedidos
{
    public class Pessoa
    {
        public string Nome { get; set; }
        public string Telefone { get; set; }

        public void InsiraDados()
        {

            Console.WriteLine("Insira seu nome: ");
            Nome = Console.ReadLine();
            Console.WriteLine("Insira seu telefone: ");
            Telefone = Console.ReadLine();

        }     

    }
}