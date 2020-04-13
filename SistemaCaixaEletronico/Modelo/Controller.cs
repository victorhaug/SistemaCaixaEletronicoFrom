using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SistemaCaixaEletronico.DAO;

namespace SistemaCaixaEletronico.Modelo
{
    public class Controller
    {
        public int nota_100 = 100;
        public int nota_50 = 50;
        public int nota_20 = 20;
        public int nota_10 = 10;
        public int nota_5 = 10;
        public bool tem;
        public String mensagem = "";
        public bool acessar(String login, String senha)
        {
            LoginDao loginDao = new LoginDao();
            tem = loginDao.verificarLogin(login, senha);
            if (!loginDao.mensagem.Equals(""))
            {
                this.mensagem = loginDao.mensagem;
            }
            return tem;
        }

        public String cadastra(String email, String senha)
        {
            return mensagem;
        }

        public String Sacar (String numero)
        {
            int valor = Convert.ToInt32(numero);
            
            
            if (valor >= 10 && valor <= 2000)
            {
                if (nota_100 > 0)
                {
                    nota_100 = valor / 100;
                    valor = valor % 100;
                    

                }
                if (nota_50 > 0)
                {
                    nota_50 = valor / 50;
                    valor = valor % 50;
                    

                }
                if (nota_10 > 0)
                {
                    nota_10 = valor / 10;
                    valor = valor % 10;
                    

                }
                if (nota_20 > 0)
                {
                    nota_20 = valor / 20;
                    valor = valor % 20;
                    

                }

                Console.ReadLine();
            }
            else
            {
                //if (nota_5 > 0)
                //{
                //    nota_5 = valor / 5;
                //    valor = valor % 5;
                //    Console.WriteLine("Não possui notas de 5");
                //}

                Console.WriteLine("Não é possível realizar o saque");


                Console.ReadLine();
            }
            return mensagem;
        }


    }
}
