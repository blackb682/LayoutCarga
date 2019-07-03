using System;
using System.IO;
using Excel = Microsoft.Office.Interop.Excel;

namespace LayoutCarga
{
	class LeituraGravacao
	{
		public void LerArquivo(string source)
		{
			Excel.Application xlApp = new Excel.Application();
			Excel.Workbook xlWorkbook = xlApp.Workbooks.Open(source);
			Excel._Worksheet xlWorksheet = xlWorkbook.Sheets[1];
			Excel.Range xlRange = xlWorksheet.UsedRange;

			int rowCount = xlRange.Rows.Count;

		}
		public void GravarArquivo(string layout, int agregadorCliente, string acao, char tipoCarga, string source, string arquivoSalvar)
		{
			LayoutsInclusao inclusao = new LayoutsInclusao();
			LayoutsLimite limite = new LayoutsLimite();
			LayoutsDemissao demissao = new LayoutsDemissao();

			switch (acao)
			{
				
				case "01":
					switch (layout)
					{
						case "0100":
							inclusao.Layout100(source, arquivoSalvar, agregadorCliente, tipoCarga);
							break;
						case "0200":
							inclusao.Layout200(source, arquivoSalvar, agregadorCliente, tipoCarga);
							break;
						case "0210":
							inclusao.Layout210(source, arquivoSalvar, agregadorCliente, tipoCarga);
							break;
						case "0300":
							inclusao.Layout300(source, arquivoSalvar, agregadorCliente, tipoCarga);
							break;
						case "0310":
							inclusao.Layout310(source, arquivoSalvar, agregadorCliente, tipoCarga);
							break;
					}
					break;
				case "04":
					switch (layout)
					{
						case "0200":
							limite.Layout200(source, arquivoSalvar, agregadorCliente, tipoCarga);
							break;
						case "0210":
							limite.Layout210(source, arquivoSalvar, agregadorCliente, tipoCarga);
							break;
						case "0300":
							limite.Layout300(source, arquivoSalvar, agregadorCliente, tipoCarga);
							break;
						case "0310":
							limite.Layout310(source, arquivoSalvar, agregadorCliente, tipoCarga);
							break;
					}
					break;

				case "06":
					switch (layout)
					{
						case "0200":
							demissao.Layout200(source, arquivoSalvar, agregadorCliente, tipoCarga);
							break;
						case "0210":
							demissao.Layout210(source, arquivoSalvar, agregadorCliente, tipoCarga);
							break;
						case "0300":
							demissao.Layout300(source, arquivoSalvar, agregadorCliente, tipoCarga);
							break;
						case "0310":
							demissao.Layout310(source, arquivoSalvar, agregadorCliente, tipoCarga);
							break;
					}
					break;
			}
		}
	


	public string Truncate(string source, int length)
	{
		if (source.Length > length)
		{
			source = source.Substring(0, length);
		}
		return source;
	}

}
}
