using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Universidade;

namespace Universidade
{

    internal class Prova
    {
       
        public string nome { get; set; }
        public int pontos { get; set; }
    

        // Criando a lista de provas
        List<Prova> listaProvas = new List<Prova>();

        // Adicionando as provas à lista
  
    public void CadastrarProva()
        {
            listaProvas.Add(new Prova { nome = "provaBimestral1", pontos = 2 });
            listaProvas.Add(new Prova { nome = "provaBimestral2", pontos = 2 });
            listaProvas.Add(new Prova { nome = "provaFinal", pontos = 3 });

        }

        public void LancarNotas()
        {
            Professor professor = new Professor();
            MatriculaAluno matriculaAluno = new MatriculaAluno();
            matriculaAluno.AdicionandoDadosAluno();
            List<Aluno> listaAluno = matriculaAluno.ListaAluno;



            string nomeAlunoLancarNota = "teo";
                // Solicitação do nome do aluno e lançamento da nota
                do {

                    Console.Write("Digite o nome do aluno: ");
                    nomeAlunoLancarNota = Console.ReadLine();

                    Aluno alunoSelecionado = listaAluno.Find(aluno => aluno.nome == nomeAlunoLancarNota);

                    if (alunoSelecionado != null)
                    {
                        Console.WriteLine("Aluno encontrado: " + alunoSelecionado.nome);

                        Console.WriteLine("Digite a nota do aluno:");
                        double nota = Convert.ToDouble(Console.ReadLine());

                        LancarNotas(alunoSelecionado, nota); // Chamada corrigida do método
                    }
                    else
                    {
                        Console.Write("Aluno não encontrado. Digite novamente: ");
                        nomeAlunoLancarNota = Console.ReadLine();
                    }
                } while (nomeAlunoLancarNota == null);


               

        }
                // Método LancarNotas dentro da mesma classe
                public void LancarNotas(Aluno aluno, double nota)
                {
                    // Implementação para lançar notas do aluno
                }
        
    }
}

        

