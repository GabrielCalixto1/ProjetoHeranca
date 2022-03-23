namespace finaldesemana2.Pedidos
{
    public class Pedido : Pessoa
    {
        public bool MarqueAOpcao()
        {
            bool repetir = true;
            string opcao;
            bool SimOuNao;
            do
            {
                Console.WriteLine("Digite ''S'' para sim e ''N'' para não");
                opcao = Console.ReadLine();
                if (opcao == "s" || opcao == "S")
                {
                    SimOuNao = true;
                    repetir = false;
                }
                else if (opcao != "n" || opcao != "N")
                {
                    SimOuNao = false;
                    repetir = false;
                }
                else
                {
                    SimOuNao = false;
                    Console.WriteLine("Opção Inválida!");


                }
            }
            while (repetir);
            return SimOuNao;
        }
    }
}
