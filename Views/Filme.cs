using System;
using Models;
using Controllers;
using System.Linq;
using System.Collections;

namespace View
{
    public class FilmeView
    {
        public void addFilme(int idFilme, string titulo, string dataLanc, string sinopse, double valorLoc, int estoque)  
            {
                FilmeController.addFilme(idFilme, titulo, dataLanc, sinopse, valorLoc, estoque);
            }

        public void getFilme(FilmeModels filmes)
            {
                Console.Write(filmes);
            }

        // Relação de Filmes da Lista
        public static void ListarFilmes()
            {
                Console.WriteLine ("---===[ LISTA DE FILMES ]===---");
                 FilmeController.GetFilmes().ForEach(filme => Console.WriteLine(filme));
            }  

        //Teste Consulta LINQ
        public static void ConsultarFilmeLINQ()
            {
                Console.WriteLine ("Digite o ID do Filme: ");
                int idFilme = Convert.ToInt32(Console.ReadLine());
                IEnumerable query =
                from filme in FilmeController.GetFilmes()
                where filme.IdFilme == idFilme
                select filme.Titulo;

                foreach (string filmes in query)
                    {
                        Console.WriteLine(filmes);
                    }
            }

            // Consulta Filme pelo ID
        public static void ConsultarFilme()
        {
            FilmeModels filme;
            do
            {
                Console.WriteLine("Digite o ID do Filme: ");
                int idFilme = Convert.ToInt32(Console.ReadLine());
                filme = null;

                try
                {
                    filme = FilmeController.GetFilme(idFilme);
                    if (filme == null)
                    {
                        Console.WriteLine("FILME NÃOLOCALIZADO!");
                    }
                }
                catch
                {
                    Console.WriteLine("FILME NÃOLOCALIZADO!");
                }
            } while (filme == null);
            Console.WriteLine(filme.ToString());
        }      
    }
}