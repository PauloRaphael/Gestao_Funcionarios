
using UniActivity.Model.Funcionarios;

namespace UniActivity.Model.Projetos
{
    public class Alocacao

    {
        public Funcionario Funcionario { get; private set; }

        public int Horas { get; private set; }



        public Alocacao(Funcionario funcionario, int horas)

        {

            Funcionario = funcionario;

            Horas = horas;

        }

    }
}
