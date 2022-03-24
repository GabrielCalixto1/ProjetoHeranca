

//Voce devera criar um sistema para abertura de pedidos e pagamentos de uma lanchonete
// A lanchonete possui 3 itens de venda: pizzas, lanches e salgadinhos. 
// Seu sistema deve controlar os Pedidos, para todos pedidos precisamos saber o nome do cliente
//Os Pratos que ele pediu, e devemos calcular o valor e realizar o pagamento, recebendo o valor e calculando troco se necessário
//Regras: Todo prato deverá ter recheio e o valor, e o comportamento de calcular seu preço
// Uma Pizza pode ter borda recheada, considere o valor de 30 reais e +10 caso tenha borda recheada
// Um Salgadinho deverá ter um tipo que pode variar entre "Assado" e "Frito" considere o valor de 7 reais para frito e 6 para assados
// Um lanche poderá ser duplo, considere o valor de 30 reais e +50% se for duplo
// Os pedidos serão criados da classe Main

using finaldesemana2.Pedidos;
namespace finaldesemana2
{

    public class Program
    {

        static void Main(string[] args)
        {
          /*  bool repetir = true;
            double total = 0;
            Pizza pizza = new Pizza();
            Lanche lanche = new Lanche();
            Salgadinho salgadinho = new Salgadinho();
            Pessoa pessoa = new Pessoa();

            Console.WriteLine("Bem vindo à lanchonete Quase 3 Lanches");
            pessoa.InsiraDados();

            Console.WriteLine($"\n{pessoa.Nome}O que vai comer hoje? \n\n1-Pizza R$30 \n2-Lanche R$30 \n3-Salgadinho R$6");
            int opcao = int.Parse(Console.ReadLine());
            do
            {

                if (opcao == 1)
                {
                    total = total + pizza.BordaFina;
                    Console.WriteLine("Você deseja adicionar borda recheada? R$ 10");

                    if (Pedido.MarqueAOpcao())
                    {
                        total = total + pizza.AdicionalBordaRecheada;
                    }
                }


                else if (opcao == 2)
                {
                    total = total + lanche.LancheNormal;
                    Console.WriteLine("Você deseja tunar seu lanche para duplo? +50% do valor do lanche");

                    if (Pedido.MarqueAOpcao())
                    {
                        total = total + lanche.AdicionalDuplo;
                    }
                }

                else if (opcao == 3)
                {
                    total = total + salgadinho.Frito;
                    Console.WriteLine("Você deseja trocar o salgado frito por assado? R$ +1");

                    if (Pedido.MarqueAOpcao())
                    {
                        total = total + salgadinho.AdicionalAssado;
                    }
                }

                else if (opcao != 1 && opcao != 2 && opcao != 3)
                {
                    Console.WriteLine("Opção invalida Digite novamente");
                    repetir = false;
                }
            } while (repetir); */

            var numerosMaisUm = new List<int>();
            var numeros = new List<int>();
            var strings = new List<string>();
            for (var contador = 0; contador < 10; contador++)
            {
                numeros.Add(contador);
                numerosMaisUm.Add(contador + 10);
                strings.Add(contador.ToString());
            }
            numeros.AddRange(numerosMaisUm);
            var tentativaUm = numeros.Remove(5+6);

            var indexString = strings.IndexOf(Console.ReadLine());
            var indexCinco = numeros.IndexOf(int.Parse(Console.ReadLine()));
            var posicaoDoMeuNome = numeros.ElementAt(3);
            var valorNaPosicaoTres = numeros.ElementAt(3);
            var valorPar = numeros.Find(numero => numero % 2 ==0);
            var valoresPares = numeros.Where(numero => numero % 2 ==0);
            var valoresParesDois = numeros.FindAll(numero => numero % 2 == 0);

            Console.WriteLine("Finalizou");

        }

    }
}










