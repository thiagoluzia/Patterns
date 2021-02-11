using System.Text;

namespace Facade.DTO
{
    public class Endereco
    {
        #region Propriedades
        public int Id { get; set; }
        public string Logradouro { get; set; }
        public string Numero { get; set; }
        public string Bairro { get; set; }
        public string Cidade { get; set; }
        public string CEP { get; set; }
        public string  Obs { get; set; }
        #endregion

        #region Construtores
        public Endereco()
        {
        }
        //Construtor Personalizado
        public Endereco(string logradouro, string numero, string bairro, string cidade, string cep = null, string obs = null)
        {
            Logradouro = logradouro;
            Numero = numero;
            Bairro = bairro;
            Cidade = cidade;
            CEP = null;
            Obs = null;
        }
        #endregion

        #region Metodo / Sobrecarga
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("Endereço: ");
            sb.AppendLine($"Logradouro: {Logradouro}");
            sb.AppendLine($"Número: {Numero}");
            sb.AppendLine($"Bairro: {Bairro}");
            sb.AppendLine($"Cidade: {Cidade}");

            if (!string.IsNullOrEmpty(CEP))
            {
                sb.AppendLine($"CEP: {CEP}");
            }

            if (!string.IsNullOrEmpty(Obs))
            {
                sb.AppendLine($"Observação: {Obs}");
            }

            return sb.ToString();
        }
        #endregion

    }
}
