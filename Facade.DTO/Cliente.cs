using System;
using System.Collections.Generic;
using System.Text;

namespace Facade.DTO
{
    public class Cliente : Pessoa
    {
        #region Propriedades
        public double LimiteDeCompra { get; set; }
        public Endereco Endereco { get; set; }
        #endregion

        #region Construtores
        public Cliente()
        {
        }
        //Construtor personalizado
        public Cliente(Endereco endereco, double limiteDeCompra = 0.0)
        {
            LimiteDeCompra = limiteDeCompra;
            Endereco = endereco;
        }
        #endregion

        #region Metodo / Sobrecarga
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            Pessoa pessoa = new Pessoa();

            sb.Append(pessoa.ToString());

            if (LimiteDeCompra > 0)
            {
                sb.AppendLine($"Limite de Compra: {LimiteDeCompra.ToString("C")}");
            }
            
            sb.Append(Endereco.ToString());

            return sb.ToString();
        }
        #endregion


    }
}
