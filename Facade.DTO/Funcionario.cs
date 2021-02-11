using System.Text;

namespace Facade.DTO
{
    public class Funcionario : Pessoa
    {
        #region Propriedades
        public Endereco Endereco { get; set; }
        public string Telefone { get; set; }
        #endregion

        #region Construtor
        public Funcionario(string RG, string CPF, Endereco endereco, string telefone = null)
        {
            this.RG = RG;
            this.CPF = CPF;
            Endereco = endereco;
            Telefone = null;
        }
        #endregion

        #region Metodo / Sobrecarga
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            Pessoa pessoa = new Pessoa();

            sb.Append(pessoa.ToString());

            if (!string.IsNullOrEmpty(Telefone))
            {
                sb.AppendLine($"Telefone: {Telefone}");
            }

            sb.AppendLine(Endereco.ToString());

            return Endereco.ToString();
        }
        #endregion
    }
}
