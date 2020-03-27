using System;
using Models;
using Controllers;
using System.Linq;
using System.Collections;

namespace View
{
    public class ClienteView
    {
        public void addCliente(int idCliente, string nome, string dataNasc, string cpf, int diaDev)
        {
            ClienteController.addCliente(idCliente, nome, dataNasc, cpf, diaDev);
        }

        public void getCliente(ClienteModels cliente)
        {
            Console.Write(cliente);
        }

        // Relação de Clientes da Lista
        public static void ListarClientes()
        {
            Console.WriteLine("=================[ LISTA DE CLIENTES ]=================");
            ClienteController.GetClientes().ForEach(filme => Console.WriteLine(filme));
        }

        // Teste Consulta LINQ
        public static void ConsultarCliente()
        {
            Console.WriteLine("Digite o ID do Cliente: ");
            int idCliente = Convert.ToInt32(Console.ReadLine());

            IEnumerable query =
            from cliente in ClienteController.GetClientes()
            where cliente.IdCliente == idCliente
            select cliente.ToString();

            foreach (string cliente in query)
            {
                Console.WriteLine("=================[ CONSULTA CLIENTE ]==================");
                Console.WriteLine(cliente.ToString());
            }
        }
    }
}