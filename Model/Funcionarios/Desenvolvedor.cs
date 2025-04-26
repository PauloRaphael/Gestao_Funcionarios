
namespace UniActivity.Model.Funcionarios
{
    public class Desenvolvedor : Funcionario

    {

        public Desenvolvedor(string nome) : base(nome)

        {

            Cargo = "Desenvolvedor";

        }



        public override double CalcularCustoHora() => 100.0;

    }
}
