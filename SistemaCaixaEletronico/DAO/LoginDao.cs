using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SistemaCaixaEletronico.DAO;

namespace SistemaCaixaEletronico.DAO
{
    class LoginDao
    {
        public String mensagem = "";
        public bool tem = false;
        SqlCommand cmd = new SqlCommand();
        Conexao con = new Conexao();
        SqlDataReader dr;

        public bool verificarLogin(String login, String senha)
        {
            // verificar no banco se tem no banco
            cmd.CommandText = "SELECT * FROM Login WHERE login = @login and senha = @senha";

            cmd.Parameters.AddWithValue("@login", login);
            cmd.Parameters.AddWithValue("@senha", senha);

            try
            {
                cmd.Connection = con.conectar();
                dr = cmd.ExecuteReader();
                if (dr.HasRows) //se foi encontrado
                {
                    tem = true;
                }
            }
            catch (SqlException)
            {
                this.mensagem = "Erro com o banco de dados!";
            }
            return tem;
        }

        public String cadastra(String email, String senha)
        {
            // cadastra no banco 
            return mensagem;
        }
    }
}

