using System;
using Models;
using Controllers;
using System.Linq;
using System.Collections;
using System.Collections.Generic;

namespace View
{
    public class LocacaoView
    {
        public void addLocacao (int idLocacao, ClienteModels cliente)
            {
                LocacaoController.addLocacao(idLocacao, cliente);
            }

        // Listando os CLientes da Lista
        public static void ListarLocacao()
        {     
            List<LocacaoModels> locacoes = LocacaoController.GetLocacaoModels();

            locacoes.ForEach(locacao => Console.WriteLine(locacao));
        }

        // Adicionando Locação na Lista pelo ID do CLiente
        public static void AdicionarLocacao()
        {
            List<ClienteModels> clientes = ClienteController.GetClientes();
            List<FilmeModels> filmes = FilmeController.GetFilmes();
            
            
            int idCliente = 0;
           
            Console.WriteLine("\nDigite o ID Cliente:");
            idCliente = Convert.ToInt32(Console.ReadLine());

            if (idCliente <= 5) 
            { 
                ClienteModels cliente = clientes.Find(cliente => cliente.IdCliente == idCliente);

                LocacaoModels locacao = LocacaoController.addLocacao(1, cliente);
            
                int idFilme = 0;

                // Eqto IdFilme não for ZERO continua adicionando Locação                           
                do
                {
                    Console.WriteLine("\nDigite o ID Filme: ");
                    Console.WriteLine("DIGITE ZERO (0) P/ FINALIZAR!");
                    idFilme = Convert.ToInt32(Console.ReadLine());

                    if (idFilme != 0) 
                    {
                        FilmeModels filme = filmes.Find(filme => filme.IdFilme == idFilme);

                        locacao.AdicionarFilme(filme);
                    }
                } while (idFilme != 0);  
            }                  
        }

        //Teste Consulta LINQ
        public static void ConsultarLocacaoLINQ()
            {
                Console.WriteLine ("Digite o ID da Locação: ");
                int idLocacao = Convert.ToInt32(Console.ReadLine());
                IEnumerable query =
                from locacao in LocacaoController.GetLocacaoModels()
                where locacao.IdLocacao == idLocacao
                select locacao;

                foreach (string locacoes in query)
                    {
                        Console.WriteLine(locacoes);
                    }
            }


        // Consulta Locação pelo ID
        public static void ConsultarLocacao () 
        {
            LocacaoModels locacao;

            do {
                Console.WriteLine ("Digite o ID da Locação: ");;
                int idLocacao = Convert.ToInt32 (Console.ReadLine ());
                locacao = null;

                
                try {
                    locacao = LocacaoController.GetLocacao(idLocacao);
                    if (locacao == null) 
                    {
                        Console.WriteLine ("LOCAÇÃO NÃO LOCALIZADA!");
                    }
                } catch {
                    Console.WriteLine ("LOCAÇÃO NÃO LOCALIZADA!");
                }
            } while (locacao == null);
            Console.WriteLine (locacao.ToString ());
        }
    }
}