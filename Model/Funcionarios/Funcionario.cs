
namespace UniActivity.Model.Funcionarios
{
    public abstract class Funcionario

    {
        public string Nome { get; private set; }
        public string Cargo { get; protected set; }

        public Funcionario(string nome)

        {

            Nome = nome;

        }



        // Polimorfismo: mC)todo abstrato que serC! implementado de forma diferente por subclasses.

        public abstract double CalcularCustoHora();

    }
}
