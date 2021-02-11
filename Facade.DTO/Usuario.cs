using System.Text;

namespace Facade.DTO
{
    public class Usuario: Pessoa
    {
        #region Propriedades
        public string UserName { get; set; }
        public string Senha { get; set; }
        public string Email { get; set; }
        #endregion

        #region Construtores
        public Usuario()
        {
        }

        //Construtor Personalizado
        public Usuario(string userName, string senha, string email)
        {
            UserName = userName;
            Senha = senha;
            Email = email;
        }
        #endregion

        #region Metodo
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            Pessoa pessoa = new Pessoa();

            sb.Append(pessoa.ToString());
            sb.AppendLine($"User Name: {UserName}");
            sb.AppendLine($"Email: {Email}");

            return sb.ToString();
        }
        #endregion
    }
}
