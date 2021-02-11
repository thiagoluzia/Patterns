using System.Text;

namespace Facade.DTO
{
    public class Pessoa
    {
        #region Propriedade
        public int Id { get; set; }
        public string Nome { get; set; }
        public string RG { get; set; }
        public string CPF { get; set; }
        #endregion

        #region Metodo / Sobrecarga
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append($"Nome: {Nome}");

            if (!string.IsNullOrEmpty(CPF))
            {
                sb.AppendLine($"RG: {RG}");
            }

            if (!string.IsNullOrEmpty(CPF))
            {
                sb.AppendLine($"CPF: {CPF}");
            }

            return sb.ToString();
        }
        #endregion
    }
}
