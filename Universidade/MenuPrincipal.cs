using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Universidade
{
    internal class MenuPrincipal
    {
        Aluno aluno = new Aluno();
        Administrador administrador = new Administrador();
        Professor professor = new Professor();


       
            public void Menu()
            {
                    
                    Console.WriteLine();
                    Console.WriteLine("                   xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx");
                    Console.WriteLine("                        Bem-vindo ao sistema da Universidade de Araxá!     ");
                    Console.WriteLine("                   xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx");
                    Console.WriteLine();
                    Console.WriteLine("Que tipo de usuário você é:");
                    Console.WriteLine("1 - Aluno");
                    Console.WriteLine("2 - Professor");
                    Console.WriteLine("3 - Administrador");
                    Console.WriteLine("x - Sair");

                    string opcaoUsuario = Console.ReadLine();

                    switch (opcaoUsuario)
                    {
                        case "1":
                           
                            aluno.MenuAluno();
                            break;

                        case "2":
                            Console.WriteLine("Professor");
                            professor.MenuProfessor();
                            break;

                        case "3":
                            Console.WriteLine("Administrador");
                            administrador.MenuAdministrador();
                            break;

                        case "x":
                            return; // Encerra o programa

                        default:
                            Console.WriteLine("Opção inválida!");
                            break;
                    }
                
            }
        }
    }


