using System;
using Models;
using System.Collections.Generic;

namespace Controllers 
{
    public class LocacaoController
    {
		// Adição da Locação
        public static LocacaoModels addLocacao(int idLocacao, ClienteModels cliente)
            {
                return new LocacaoModels(idLocacao, cliente);
            }

		// Método com o Valor Total das Locações (Preço)
		public static double PrecoTotalLocaçoes(List<FilmeModels> filmes) 
			{
                double ValorTotal = 0;

				foreach (FilmeModels filme in filmes) 
					{
						ValorTotal += filme.ValorLocacaoFilme;
					}

                return Math.Round(ValorTotal,2);
			}

		// Calculo Data de Devolução
		public static string calculoDataDevolucao(DateTime Data) 
			{
				//Data.AddDays(ClienteModels.Dias);
				return Data.ToString().Substring(0,10);
			}

		// Total de Filmes da Lista
        public static double TotalFilmes(List<FilmeModels> filmes) 
			{
                return filmes.Count;
			}

		// Retorno da Lista de Locações
        public static List<LocacaoModels> GetLocacao()
			{
				return LocacaoModels.GetLocacao();
			}

		// Retorno da Locação pelo ID
		public static LocacaoModels GetLocacao (int idLocacao)
			{
				return LocacaoModels.GetLocacao(idLocacao);
			}
    }      
}