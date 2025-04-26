
using UniActivity.Model.Funcionarios;
using UniActivity.Model.Projetos;

namespace UniActivity.Model
{
    public class Repositorio

    {

        public List<Funcionario> Funcionarios { get; private set; } = new List<Funcionario>();

        public List<Projeto> Projetos { get; private set; } = new List<Projeto>();



        public void AdicionarFuncionario(Funcionario f) => Funcionarios.Add(f);

        public void AdicionarProjeto(Projeto p) => Projetos.Add(p);



        public Funcionario BuscarFuncionario(string nome)

        => Funcionarios.FirstOrDefault(f => f.Nome.ToLower() == nome.ToLower());



        public Projeto BuscarProjeto(string nome)

        => Projetos.FirstOrDefault(p => p.Nome.ToLower() == nome.ToLower());

        public static void CadastrarFuncionario(Repositorio repo)

        {

            Console.Write("Nome: ");

            var nome = Console.ReadLine();

            Console.Write("Cargo (1 - Desenvolvedor | 2 - Gerente): ");

            var cargo = Console.ReadLine();


            Funcionario f = cargo == "1"
                            ? (Funcionario)new Desenvolvedor(nome)
                            : new Gerente(nome);

            repo.AdicionarFuncionario(f);

            Console.WriteLine("Funcionário cadastrado!");

        }



        public static void CadastrarProjeto(Repositorio repo)

        {

            Console.Write("Nome do projeto: ");

            var nome = Console.ReadLine();

            repo.AdicionarProjeto(new Projeto(nome));

            Console.WriteLine("Projeto cadastrado!");

        }



        public static void AlocarFuncionario(Repositorio repo)

        {

            Console.Write("Nome do projeto: ");

            var nomeProjeto = Console.ReadLine();

            var projeto = repo.BuscarProjeto(nomeProjeto);

            if (projeto == null)
            {
                Console.WriteLine("Projeto nC#o encontrado.");
                return;
            }



            Console.Write("Nome do funcionario: ");

            var nomeFuncionario = Console.ReadLine();

            var funcionario = repo.BuscarFuncionario(nomeFuncionario);

            if (funcionario == null)
            {
                Console.WriteLine("Funcionario não encontrado.");
                return;
            }



            Console.Write("Horas alocadas: ");

            int horas = int.Parse(Console.ReadLine());



            projeto.AdicionarAlocacao(funcionario, horas);

            Console.WriteLine("Alocação realizada!");

        }



        public static void ExibirProjetos(Repositorio repo)

        {

            foreach (var p in repo.Projetos)

            {

                p.ExibirDetalhes();

                Console.WriteLine("-----------");

            }

        }

    }
}
