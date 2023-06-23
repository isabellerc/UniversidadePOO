using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace Universidade
{

    public abstract class Pessoa
    {
        public string nome { get; set; }
        public string cpf { get; set; }
        public string endereco { get; set; }
        public DateTime dataNascimento { get; set; }
        public int idade { get; set; }  
        public string curso { get; set; }
        public int periodo { get; set; }

        public int Idade
        {
            get
            {
                DateTime dataAtual = DateTime.Now;
                int idade = dataAtual.Year - dataNascimento.Year;
                if (dataAtual < dataNascimento.AddYears(idade))
                {
                    idade--;
                }
                return idade;
            }
        }

    }
}
