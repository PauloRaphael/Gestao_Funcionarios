using UniActivity.Model;
using UniActivity.Model.Funcionarios;
using UniActivity.Model.Projetos;

internal class Program

{

    static Repositorio repo = new Repositorio();



    static void Main()

    {

        bool sair = false;



        while (!sair)

        {

            Console.WriteLine("\n=== MENU ===");

            Console.WriteLine("1 - Cadastrar Funcionário");

            Console.WriteLine("2 - Cadastrar Projeto");

            Console.WriteLine("3 - Alocar Funcionario a Projeto");

            Console.WriteLine("4 - Exibir Projetos");

            Console.WriteLine("5 - Sair");

            Console.Write("Escolha: ");

            var opcao = Console.ReadLine();



            switch (opcao)

            {

                case "1":
                    Repositorio.CadastrarFuncionario(repo);
                    break;

                case "2":
                    Repositorio.CadastrarProjeto(repo);
                    break;

                case "3":
                    Repositorio.AlocarFuncionario(repo);
                    break;

                case "4":
                    Repositorio.ExibirProjetos(repo);
                    break;

                case "5":
                    sair = true;
                    break;

                default:
                    Console.WriteLine("Opção inválida.");
                    break;

            }

        }

    }

}