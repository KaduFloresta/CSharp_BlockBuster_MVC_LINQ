using Models;
using System.Collections.Generic;

namespace Repositories
{
    public class ClienteRepositories
    {
		// Lista de CLientes
		public static List<ClienteModels> clientes = new List<ClienteModels>();

		// Repositório dos CLientes
		public static void ImportarCliente()
		{
			// Lista com 5 Clientes
			ClienteModels cliente1 = new ClienteModels(1,
			"Adriano Medeiros Sá", "21/01/1978", "123.123.123-12", 3);
			
			ClienteModels cliente2 = new ClienteModels(2,
			"João Pedro Silva", "13/08/1945", "456.456.456-45", 2);
			
			ClienteModels cliente3 = new ClienteModels(3,
			"Maria de Fátima Antunes", "02/12/2001", "789.789.789-78", 4);
			
			ClienteModels cliente4 = new ClienteModels(4,
			"Letícia Eugenia Soares", "11/02/1988", "098.098.098-09", 5);
						
			ClienteModels cliente5 = new ClienteModels(5,
			"Belmiro Schmmitt", "15/07/1995", "753.753.753-75", 1);
		}

		// Retorno dos Clientes da Lista
		public static List<ClienteModels> Clientes()
			{
				return clientes;
			} 

		// Soma 1 a cada Cliente adicionado
		public static int GetId()
			{
				return clientes.Count + 1;
			}            
    }
}