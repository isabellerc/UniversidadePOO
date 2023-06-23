
										Sobre o Projeto Minimundo: Universidade

	Este projeto foi feito para controle de acessos e funções em uma universidade. Onde, administradores, professores e alunos terão suas respectivas funções e atribuições.
------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
	Neste sistema teremos 9 classes. São elas:
Pessoa	
Aluno	
Administrador	
Professor
Matricula Aluno (lista)
Matricula Professor
Menu Principal
Prova	
Program
--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------	
	Teremos 17 métodos. São eles:
Idade
Menu Aluno
Imprimir Dados Aluno
Gerar Relatorio Aluno
Menu Administrador
Menu Professor
AdicionandoDadosAluno
Imprimir Alunos
Cadastrar Professor
Solicitar Dados Professor
Lançar Notas
Imprimir Notas
Gerar Relatório
Menu
LancarNotas
ImprimirNotas
Gerar Relatório
Chamar Menu Principal
---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
	Relação entre Classes e Métodos:

Classe:							x				Métodos:		
-------------------------------------------------------------------------------------
Pessoa										Idade
											Menu Aluno
-------------------------------------------------------------------------------------
Aluno										Imprimir Dados Aluno
											Gerar Relatorio Aluno	
-------------------------------------------------------------------------------------
Administrador								Menu Administrador			
--------------------------------------------------------------------------------------
Professor									Menu Professor
--------------------------------------------------------------------------------------
Matricula Aluno								AdicionandoDadosAluno
											Imprimir Alunos 
											Cadastrar Professor
											Solicitar Dados Professor
--------------------------------------------------------------------------------------
Matricula Professor							Lançar Notas
											Imprimir Notas
											Gerar Relatório
--------------------------------------------------------------------------------------
Menu Principal								Menu
											LancarNotas
--------------------------------------------------------------------------------------
Prova										ImprimirNotas
											Gerar Relatório
--------------------------------------------------------------------------------------
Program										Chamar Menu Principal
	
------------------------------------------------------------------------------------------------------------------------------------------
	O que foi pedido:
Herança e Abstração: Pessoa é classe abstrata que origina as Classes Aluno e Professor.
Método com retorno: Idade.
Método sem retorno:
Método com parâmetro:  CadastrarProfessor(Professor professor).
Método sem parâmetro:
Método Construtor:
Lista de Objetos de Classe: listaAluno.
Busca em Objetos:
Busca utilizando Lambda: Aluno aluno = listaAluno.FirstOrDefault(a => a.nome.Equals(nome, StringComparison.OrdinalIgnoreCase));
Menu para manipular o objeto: MenuPrincipal, MenuAdministrador, MenuAluno, MenuProfessor.


	