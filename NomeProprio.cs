using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace caNomeProprio
{
    internal class NomeProprio
    {

        private string nome_completo;
        private string nome_paper;

        public string Nome_completo { get => nome_completo; set => nome_completo = value; }
        public string Nome_paper { get => nome_paper; set => nome_paper = value; }

        public NomeProprio()
        {      

        }
        public NomeProprio (string _nome_completo, string _nome_paper)
        {
            nome_completo = _nome_completo;
            nome_paper = _nome_paper;
           
        }

        public void ImprimeNomePaper()
        {

            string primeiroNome;
            string nomeMeio;
            string sobrenome;
            char first;

            Console.WriteLine("Insira o Nome Completo");
            string temp = Console.ReadLine();
            char[] delimiterChars = { ' ' };
            string[] nome = temp.Split(delimiterChars);

            if (nome.Length == 2) {

                 primeiroNome = nome[0];
                 
                 sobrenome = nome[1];            

                 nome_paper = sobrenome + ", " + primeiroNome ;

                 Console.WriteLine("Nome paper:" + nome_paper);
            }

            else 
            { 

                primeiroNome = nome[0];
                nomeMeio = nome[1];
                sobrenome = nome[2];

                first = nomeMeio[0];

                nome_paper = sobrenome + ", " + primeiroNome + " " + first + ".";

                Console.WriteLine("Nome paper:" + nome_paper);
            }
    }










    }
}
