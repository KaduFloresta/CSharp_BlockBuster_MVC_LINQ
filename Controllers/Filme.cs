using Models;
using System.Collections.Generic;

namespace Controllers
{
    public class FilmeController
    {
        // Adição de Filme
        public static void addFilme(int idFilme, string titulo, string dataLancamento, string sinopse, double valorLocacaoFilme, int estoqueFilme)
        {
            new FilmeModels(idFilme, titulo, dataLancamento, sinopse, valorLocacaoFilme, estoqueFilme);
        }

        // Retorno do Valor do Filme
        public string GetFilme(FilmeModels filme)
        {
            string filmeValue = filme.ToString();

            return filmeValue;
        }

        // Retorno da Lista de Filmes
        public static List<FilmeModels> GetFilmes()
        {
            return FilmeModels.GetFilmes();
        }

        // Retorno do Filme pelo ID 
        public static FilmeModels GetFilme(int idFilme)
        {
            return FilmeModels.GetFilme(idFilme);
        }

    }
}