using System;
using System.Collections.Generic;
using Controllers;
using Repositories;

namespace Models 
{
	public class LocacaoModels 
	{
		// Atributos
		public int IdLocacao { get; set; }
		public ClienteModels Cliente { get; set; }
		public DateTime DataLocacao { get; set; }

		// Lista de Filmes da Locação
		public List<FilmeModels> filmes = new List<FilmeModels>();

		// Construtor
		public LocacaoModels (int idLocacao, ClienteModels cliente) 
			{
				IdLocacao = LocacaoRepositories.GetId();
				Cliente = cliente;
				DataLocacao = DateTime.Today;

				Repositories.LocacaoRepositories.AdicionarLocacao(this);
			}

		// Adição de Filmes
		public void AdicionarFilme(FilmeModels filme) 
			{
				filmes.Add(filme);
			}

		// Informações da Locação
		public override string ToString() 
			{
				string retorno = $"----------------===[ DADOS LOCAÇÃO ]===----------------\n" +
					Cliente +
					$"-> PREÇO TOTAL DAS LOCAÇÕES: R$ {LocacaoController.PrecoTotalLocaçoes(filmes)}\n" +
					$"-> DATA DE DEVOLUÇÃO: {LocacaoController.calculoDataDevolucao(DataLocacao)}\n" +
					$"-> QTDE TOTAL DE FILMES LOCADOS: {LocacaoController.TotalFilmes(filmes)}\n" +
					$"-------------------------------------------------------\n";
				
				foreach (FilmeModels filme in filmes)
					{
						retorno += filme;
					}
					return retorno;

			}

		// Retorno da Lista de Locações
		public static List<LocacaoModels> GetLocacaoModels() 
			{
				return LocacaoRepositories.Locacoes();
			}
		// Retorno da Locação pelo ID
		public static LocacaoModels GetLocacao(int idLocacao)
			{
				return LocacaoRepositories.Locacoes().Find (locacao => locacao.IdLocacao == idLocacao);
			}			
	}
}