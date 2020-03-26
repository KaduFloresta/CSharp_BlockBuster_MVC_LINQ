using System;
using View;
using Repositories;

/**
 *  @author Kadu Floresta
 * 
 * 
*/

namespace Locadora_MVC_LinQ
{
	public class Principal 
	{
		public static void Main(String[] args) 
		{	
		ClienteRepositories.ImportarCliente();
		FilmeRepositories.ImportarFilme();

		Console.WriteLine("LOCADORA DE FILMES MVC - LinQ");

		// Menu Principal - Inserir - Consultar - Listar
		int menu = 0;
		do 
		{ 
            Console.WriteLine("\n|*********************************|");			  
              Console.WriteLine("|==============MENU===============|");
			  Console.WriteLine("|*********************************|"); 
              Console.WriteLine("| 1 >>> Inserir Locação           |");
			  Console.WriteLine("| 2 >>> Consultar Cliente         |");
              Console.WriteLine("| 3 >>> Listar Clientes           |");
			  Console.WriteLine("| 4 >>> Consultar Filme           |");
			  Console.WriteLine("| 5 >>> Listar Filmes             |");
			  Console.WriteLine("| 6 >>> Consultar Locação         |");
			  Console.WriteLine("| 7 >>> Listar Locações           |");			  
			  Console.WriteLine("| 0 >>> SAIR                      |");			  
              Console.WriteLine("|---------------------------------|");
			  Console.WriteLine("|*********************************|\n");

			  Console.WriteLine("\nDigite a Opção: ");
				try
					{			
						menu = Convert.ToInt32 (Console.ReadLine());
					} 
					catch
						{
							Console.WriteLine ("OPÇÃO INVÁLIDA!");
							menu = 99;
						}
			
			switch (menu)
			{
				case 1: // Adicionar Locacao
					LocacaoView.AdicionarLocacao();
					break;
				case 2: // Consultar Cliente
					ClienteView.ConsultarCliente();
					break;
				case 3: // Listar Clientes
					ClienteView.ListarClientes();
					break;
				case 4: // Consultar Filme
					FilmeView.ConsultarFilme();
					break;
				case 5: // Listar Filmes
					FilmeView.ListarFilmes();
					break;
				case 6: // Consultar Locação
					LocacaoView.ConsultarLocacao();
					break;
				case 7: // Lista Locação
					LocacaoView.ListarLocacao();
					break;
			}
		} while (menu != 0);
			
		}
	}
}
