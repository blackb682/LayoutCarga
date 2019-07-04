using System;
using System.IO;
using Excel = Microsoft.Office.Interop.Excel;

namespace LayoutCarga
{
	class LayoutsInclusao
	{
		public void Layout100(string source, string arquivoSalvar, int agregadorCliente, char tipoCarga)
		{
			Excel.Application xlApp = new Excel.Application();
			Excel.Workbook xlWorkbook = xlApp.Workbooks.Open(source);
			Excel._Worksheet xlWorksheet = xlWorkbook.Sheets[1];
			Excel.Range xlRange = xlWorksheet.UsedRange;

			int rowCount = xlRange.Rows.Count;
			using (StreamWriter writer = new StreamWriter(arquivoSalvar))
			{
				DateTime data = DateTime.Now;
				string filler = " ";
				int tamanhoFiller = 310;
				string layout = "0200";

				writer.WriteLine("00{0}{1}000000{2}{3}{4," + tamanhoFiller + "}" + "000001", layout,
				agregadorCliente.ToString("000000"), data.ToString("dd/MM/yyyyHH:mm"), tipoCarga, filler);

				for (int i = 1; i < rowCount + 1; i++)
				{
					LeituraGravacao format = new LeituraGravacao();

					writer.Write("{0,2}", format.Truncate(xlRange.Cells[i, 1].Text, 2));
					writer.Write("{0,1}", format.Truncate(xlRange.Cells[i, 2].Text, 1));
					writer.Write("{0,6}", format.Truncate(xlRange.Cells[i, 3].Text, 6));
					writer.Write("{0,-19}", format.Truncate(xlRange.Cells[i, 4].Text, 19));
					writer.Write("{0,-19}", format.Truncate(xlRange.Cells[i, 5].Text, 19));
					writer.Write("{0,-50}", format.Truncate(xlRange.Cells[i, 6].Text, 50));
					writer.Write("{0,-30}", format.Truncate(xlRange.Cells[i, 7].Text, 30));
					writer.Write("{0,10}", format.Truncate(xlRange.Cells[i, 8].Text, 10));
					writer.Write("{0,1}", format.Truncate(xlRange.Cells[i, 9].Text, 1));
					writer.Write("{0,15}", format.Truncate(xlRange.Cells[i, 10].Text, 15));
					writer.Write("{0,10}", format.Truncate(xlRange.Cells[i, 11].Text, 10));
					writer.Write("{0,11}", format.Truncate(xlRange.Cells[i, 12].Text, 11));
					writer.Write("{0,40}", format.Truncate(xlRange.Cells[i, 13].Text, 40));
					writer.Write("{0,5}", format.Truncate(xlRange.Cells[i, 14].Text, 5));
					writer.Write("{0,10}", format.Truncate(xlRange.Cells[i, 15].Text, 10));
					writer.Write("{0,20}", format.Truncate(xlRange.Cells[i, 16].Text, 20));
					writer.Write("{0,30}", format.Truncate(xlRange.Cells[i, 17].Text, 30));
					writer.Write("{0,2}", format.Truncate(xlRange.Cells[i, 18].Text, 2));
					writer.Write("{0,8}", format.Truncate(xlRange.Cells[i, 19].Text, 8));
					writer.Write("{0,10}", format.Truncate(xlRange.Cells[i, 20].Text, 10));
					writer.Write("{0,10}", format.Truncate(xlRange.Cells[i, 21].Text, 10));
					writer.Write("{0,1}", format.Truncate(xlRange.Cells[i, 22].Text, 1));
					writer.Write("{0,-20}", format.Truncate(xlRange.Cells[i, 23].Text, 20));
					writer.Write("{0,14}", format.Truncate(xlRange.Cells[i, 24].Text, 14));
					writer.WriteLine("{0}", (i + 1).ToString("000000"));

				}
				tamanhoFiller = 336;
				writer.Write("99{0}{1," + tamanhoFiller + "}" + "{2}", (rowCount + 2).ToString("000000"),
					filler, (rowCount + 2).ToString("000000"));
			}
			xlWorkbook.Close();
		}
		public void Layout200(string source, string arquivoSalvar, int agregadorCliente, char tipoCarga)
		{
			Excel.Application xlApp = new Excel.Application();
			Excel.Workbook xlWorkbook = xlApp.Workbooks.Open(source);
			Excel._Worksheet xlWorksheet = xlWorkbook.Sheets[1];
			Excel.Range xlRange = xlWorksheet.UsedRange;

			int rowCount = xlRange.Rows.Count;
			using (StreamWriter writer = new StreamWriter(arquivoSalvar))
			{
				DateTime data = DateTime.Now;
				string filler = " ";
				int tamanhoFiller = 310;
				string layout = "0200";

				writer.WriteLine("00{0}{1}000000{2}{3}{4," + tamanhoFiller + "}" + "000001", layout,
				agregadorCliente.ToString("000000"), data.ToString("dd/MM/yyyyHH:mm"), tipoCarga, filler);

				for (int i = 1; i < rowCount + 1; i++)
				{
					LeituraGravacao format = new LeituraGravacao();

					writer.Write("{0,2}", format.Truncate(xlRange.Cells[i, 1].Text, 2));
					writer.Write("{0,1}", format.Truncate(xlRange.Cells[i, 2].Text, 1));
					writer.Write("{0,6}", format.Truncate(xlRange.Cells[i, 3].Text, 6));
					writer.Write("{0,-19}", format.Truncate(xlRange.Cells[i, 4].Text, 19));
					writer.Write("{0,-19}", format.Truncate(xlRange.Cells[i, 5].Text, 19));
					writer.Write("{0,-50}", format.Truncate(xlRange.Cells[i, 6].Text, 50));
					writer.Write("{0,-30}", format.Truncate(xlRange.Cells[i, 7].Text, 30));
					writer.Write("{0,10}", format.Truncate(xlRange.Cells[i, 8].Text, 10));
					writer.Write("{0,1}", format.Truncate(xlRange.Cells[i, 9].Text, 1));
					writer.Write("{0,15}", format.Truncate(xlRange.Cells[i, 10].Text, 15));
					writer.Write("{0,10}", format.Truncate(xlRange.Cells[i, 11].Text, 10));
					writer.Write("{0,11}", format.Truncate(xlRange.Cells[i, 12].Text, 11));
					writer.Write("{0,40}", format.Truncate(xlRange.Cells[i, 13].Text, 40));
					writer.Write("{0,5}", format.Truncate(xlRange.Cells[i, 14].Text, 5));
					writer.Write("{0,10}", format.Truncate(xlRange.Cells[i, 15].Text, 10));
					writer.Write("{0,20}", format.Truncate(xlRange.Cells[i, 16].Text, 20));
					writer.Write("{0,30}", format.Truncate(xlRange.Cells[i, 17].Text, 30));
					writer.Write("{0,2}", format.Truncate(xlRange.Cells[i, 18].Text, 2));
					writer.Write("{0,8}", format.Truncate(xlRange.Cells[i, 19].Text, 8));
					writer.Write("{0,10}", format.Truncate(xlRange.Cells[i, 20].Text, 10));
					writer.Write("{0,10}", format.Truncate(xlRange.Cells[i, 21].Text, 10));
					writer.Write("{0,1}", format.Truncate(xlRange.Cells[i, 22].Text, 1));
					writer.Write("{0,-20}", format.Truncate(xlRange.Cells[i, 23].Text, 20));
					writer.Write("{0,14}", format.Truncate(xlRange.Cells[i, 24].Text, 14));
					writer.WriteLine("{0}", (i + 1).ToString("000000"));

				}
				tamanhoFiller = 336;
				writer.Write("99{0}{1," + tamanhoFiller + "}" + "{2}", (rowCount + 2).ToString("000000"),
					filler, (rowCount + 2).ToString("000000"));
			}
			xlWorkbook.Close();
		}
		public void Layout210(string source, string arquivoSalvar, int agregadorCliente, char tipoCarga)
		{
			Excel.Application xlApp = new Excel.Application();
			Excel.Workbook xlWorkbook = xlApp.Workbooks.Open(source);
			Excel._Worksheet xlWorksheet = xlWorkbook.Sheets[1];
			Excel.Range xlRange = xlWorksheet.UsedRange;

			int rowCount = xlRange.Rows.Count;
			using (StreamWriter writer = new StreamWriter(arquivoSalvar))
			{
				DateTime data = DateTime.Now;
				string filler = " ";
				int tamanhoFiller = 310;
				string layout = "0200";

				writer.WriteLine("00{0}{1}000000{2}{3}{4," + tamanhoFiller + "}" + "000001", layout,
				agregadorCliente.ToString("000000"), data.ToString("dd/MM/yyyyHH:mm"), tipoCarga, filler);

				for (int i = 1; i < rowCount + 1; i++)
				{
					LeituraGravacao format = new LeituraGravacao();

					writer.Write("{0,2}", format.Truncate(xlRange.Cells[i, 1].Text, 2));
					writer.Write("{0,1}", format.Truncate(xlRange.Cells[i, 2].Text, 1));
					writer.Write("{0,6}", format.Truncate(xlRange.Cells[i, 3].Text, 6));
					writer.Write("{0,-19}", format.Truncate(xlRange.Cells[i, 4].Text, 19));
					writer.Write("{0,-19}", format.Truncate(xlRange.Cells[i, 5].Text, 19));
					writer.Write("{0,-50}", format.Truncate(xlRange.Cells[i, 6].Text, 50));
					writer.Write("{0,-30}", format.Truncate(xlRange.Cells[i, 7].Text, 30));
					writer.Write("{0,10}", format.Truncate(xlRange.Cells[i, 8].Text, 10));
					writer.Write("{0,1}", format.Truncate(xlRange.Cells[i, 9].Text, 1));
					writer.Write("{0,15}", format.Truncate(xlRange.Cells[i, 10].Text, 15));
					writer.Write("{0,10}", format.Truncate(xlRange.Cells[i, 11].Text, 10));
					writer.Write("{0,11}", format.Truncate(xlRange.Cells[i, 12].Text, 11));
					writer.Write("{0,40}", format.Truncate(xlRange.Cells[i, 13].Text, 40));
					writer.Write("{0,5}", format.Truncate(xlRange.Cells[i, 14].Text, 5));
					writer.Write("{0,10}", format.Truncate(xlRange.Cells[i, 15].Text, 10));
					writer.Write("{0,20}", format.Truncate(xlRange.Cells[i, 16].Text, 20));
					writer.Write("{0,30}", format.Truncate(xlRange.Cells[i, 17].Text, 30));
					writer.Write("{0,2}", format.Truncate(xlRange.Cells[i, 18].Text, 2));
					writer.Write("{0,8}", format.Truncate(xlRange.Cells[i, 19].Text, 8));
					writer.Write("{0,10}", format.Truncate(xlRange.Cells[i, 20].Text, 10));
					writer.Write("{0,10}", format.Truncate(xlRange.Cells[i, 21].Text, 10));
					writer.Write("{0,1}", format.Truncate(xlRange.Cells[i, 22].Text, 1));
					writer.Write("{0,-20}", format.Truncate(xlRange.Cells[i, 23].Text, 20));
					writer.Write("{0,14}", format.Truncate(xlRange.Cells[i, 24].Text, 14));
					writer.WriteLine("{0}", (i + 1).ToString("000000"));

				}
				tamanhoFiller = 336;
				writer.Write("99{0}{1," + tamanhoFiller + "}" + "{2}", (rowCount + 2).ToString("000000"),
					filler, (rowCount + 2).ToString("000000"));
			}
			xlWorkbook.Close();
		}
		public void Layout300(string source, string arquivoSalvar, int agregadorCliente, char tipoCarga)
		{
			Excel.Application xlApp = new Excel.Application();
			Excel.Workbook xlWorkbook = xlApp.Workbooks.Open(source);
			Excel._Worksheet xlWorksheet = xlWorkbook.Sheets[1];
			Excel.Range xlRange = xlWorksheet.UsedRange;

			int rowCount = xlRange.Rows.Count;
			using (StreamWriter writer = new StreamWriter(arquivoSalvar))
			{
				DateTime data = DateTime.Now;
				string filler = " ";
				int tamanhoFiller = 310;
				string layout = "0200";

				writer.WriteLine("00{0}{1}000000{2}{3}{4," + tamanhoFiller + "}" + "000001", layout,
				agregadorCliente.ToString("000000"), data.ToString("dd/MM/yyyyHH:mm"), tipoCarga, filler);

				for (int i = 1; i < rowCount + 1; i++)
				{
					LeituraGravacao format = new LeituraGravacao();

					writer.Write("{0,2}", format.Truncate(xlRange.Cells[i, 1].Text, 2));
					writer.Write("{0,1}", format.Truncate(xlRange.Cells[i, 2].Text, 1));
					writer.Write("{0,6}", format.Truncate(xlRange.Cells[i, 3].Text, 6));
					writer.Write("{0,-19}", format.Truncate(xlRange.Cells[i, 4].Text, 19));
					writer.Write("{0,-19}", format.Truncate(xlRange.Cells[i, 5].Text, 19));
					writer.Write("{0,-50}", format.Truncate(xlRange.Cells[i, 6].Text, 50));
					writer.Write("{0,-30}", format.Truncate(xlRange.Cells[i, 7].Text, 30));
					writer.Write("{0,10}", format.Truncate(xlRange.Cells[i, 8].Text, 10));
					writer.Write("{0,1}", format.Truncate(xlRange.Cells[i, 9].Text, 1));
					writer.Write("{0,15}", format.Truncate(xlRange.Cells[i, 10].Text, 15));
					writer.Write("{0,10}", format.Truncate(xlRange.Cells[i, 11].Text, 10));
					writer.Write("{0,11}", format.Truncate(xlRange.Cells[i, 12].Text, 11));
					writer.Write("{0,40}", format.Truncate(xlRange.Cells[i, 13].Text, 40));
					writer.Write("{0,5}", format.Truncate(xlRange.Cells[i, 14].Text, 5));
					writer.Write("{0,10}", format.Truncate(xlRange.Cells[i, 15].Text, 10));
					writer.Write("{0,20}", format.Truncate(xlRange.Cells[i, 16].Text, 20));
					writer.Write("{0,30}", format.Truncate(xlRange.Cells[i, 17].Text, 30));
					writer.Write("{0,2}", format.Truncate(xlRange.Cells[i, 18].Text, 2));
					writer.Write("{0,8}", format.Truncate(xlRange.Cells[i, 19].Text, 8));
					writer.Write("{0,10}", format.Truncate(xlRange.Cells[i, 20].Text, 10));
					writer.Write("{0,10}", format.Truncate(xlRange.Cells[i, 21].Text, 10));
					writer.Write("{0,1}", format.Truncate(xlRange.Cells[i, 22].Text, 1));
					writer.Write("{0,-20}", format.Truncate(xlRange.Cells[i, 23].Text, 20));
					writer.Write("{0,14}", format.Truncate(xlRange.Cells[i, 24].Text, 14));
					writer.WriteLine("{0}", (i + 1).ToString("000000"));

				}
				tamanhoFiller = 336;
				writer.Write("99{0}{1," + tamanhoFiller + "}" + "{2}", (rowCount + 2).ToString("000000"),
					filler, (rowCount + 2).ToString("000000"));
			}
			xlWorkbook.Close();
		}
		public void Layout310(string source, string arquivoSalvar, int agregadorCliente, char tipoCarga)
		{
			Excel.Application xlApp = new Excel.Application();
			Excel.Workbook xlWorkbook = xlApp.Workbooks.Open(source);
			Excel._Worksheet xlWorksheet = xlWorkbook.Sheets[1];
			Excel.Range xlRange = xlWorksheet.UsedRange;

			int rowCount = xlRange.Rows.Count;
			using (StreamWriter writer = new StreamWriter(arquivoSalvar))
			{
				DateTime data = DateTime.Now;
				string filler = " ";
				int tamanhoFiller = 310;
				string layout = "0200";

				writer.WriteLine("00{0}{1}000000{2}{3}{4," + tamanhoFiller + "}" + "000001", layout,
				agregadorCliente.ToString("000000"), data.ToString("dd/MM/yyyyHH:mm"), tipoCarga, filler);

				for (int i = 1; i < rowCount + 1; i++)
				{
					LeituraGravacao format = new LeituraGravacao();

					writer.Write("{0,2}", format.Truncate(xlRange.Cells[i, 1].Text, 2));
					writer.Write("{0,1}", format.Truncate(xlRange.Cells[i, 2].Text, 1));
					writer.Write("{0,6}", format.Truncate(xlRange.Cells[i, 3].Text, 6));
					writer.Write("{0,-19}", format.Truncate(xlRange.Cells[i, 4].Text, 19));
					writer.Write("{0,-19}", format.Truncate(xlRange.Cells[i, 5].Text, 19));
					writer.Write("{0,-50}", format.Truncate(xlRange.Cells[i, 6].Text, 50));
					writer.Write("{0,-30}", format.Truncate(xlRange.Cells[i, 7].Text, 30));
					writer.Write("{0,10}", format.Truncate(xlRange.Cells[i, 8].Text, 10));
					writer.Write("{0,1}", format.Truncate(xlRange.Cells[i, 9].Text, 1));
					writer.Write("{0,15}", format.Truncate(xlRange.Cells[i, 10].Text, 15));
					writer.Write("{0,10}", format.Truncate(xlRange.Cells[i, 11].Text, 10));
					writer.Write("{0,11}", format.Truncate(xlRange.Cells[i, 12].Text, 11));
					writer.Write("{0,40}", format.Truncate(xlRange.Cells[i, 13].Text, 40));
					writer.Write("{0,5}", format.Truncate(xlRange.Cells[i, 14].Text, 5));
					writer.Write("{0,10}", format.Truncate(xlRange.Cells[i, 15].Text, 10));
					writer.Write("{0,20}", format.Truncate(xlRange.Cells[i, 16].Text, 20));
					writer.Write("{0,30}", format.Truncate(xlRange.Cells[i, 17].Text, 30));
					writer.Write("{0,2}", format.Truncate(xlRange.Cells[i, 18].Text, 2));
					writer.Write("{0,8}", format.Truncate(xlRange.Cells[i, 19].Text, 8));
					writer.Write("{0,10}", format.Truncate(xlRange.Cells[i, 20].Text, 10));
					writer.Write("{0,10}", format.Truncate(xlRange.Cells[i, 21].Text, 10));
					writer.Write("{0,1}", format.Truncate(xlRange.Cells[i, 22].Text, 1));
					writer.Write("{0,-20}", format.Truncate(xlRange.Cells[i, 23].Text, 20));
					writer.Write("{0,14}", format.Truncate(xlRange.Cells[i, 24].Text, 14));
					writer.WriteLine("{0}", (i + 1).ToString("000000"));

				}
				tamanhoFiller = 336;
				writer.Write("99{0}{1," + tamanhoFiller + "}" + "{2}", (rowCount + 2).ToString("000000"),
					filler, (rowCount + 2).ToString("000000"));
			}
			xlWorkbook.Close();
		}
	}

	class LayoutsDemissao
	{
		public void Layout100(string source, string arquivoSalvar, int agregadorCliente, char tipoCarga)
		{
			Excel.Application xlApp = new Excel.Application();
			Excel.Workbook xlWorkbook = xlApp.Workbooks.Open(source);
			Excel._Worksheet xlWorksheet = xlWorkbook.Sheets[1];
			Excel.Range xlRange = xlWorksheet.UsedRange;

			int rowCount = xlRange.Rows.Count;
			using (StreamWriter writer = new StreamWriter(arquivoSalvar))
			{
				DateTime data = DateTime.Now;
				string filler = " ";
				int tamanhoFiller = 310;
				string layout = "0200";

				writer.WriteLine("00{0}{1}000000{2}{3}{4," + tamanhoFiller + "}" + "000001", layout,
				agregadorCliente.ToString("000000"), data.ToString("dd/MM/yyyyHH:mm"), tipoCarga, filler);

				for (int i = 1; i < rowCount + 1; i++)
				{
					LeituraGravacao format = new LeituraGravacao();

					writer.Write("{0,2}", format.Truncate(xlRange.Cells[i, 1].Text, 2));
					writer.Write("{0,1}", format.Truncate(xlRange.Cells[i, 2].Text, 1));
					writer.Write("{0,6}", format.Truncate(xlRange.Cells[i, 3].Text, 6));
					writer.Write("{0,-19}", format.Truncate(xlRange.Cells[i, 4].Text, 19));
					writer.Write("{0,-19}", format.Truncate(xlRange.Cells[i, 5].Text, 19));
					writer.Write("{0,-50}", format.Truncate(xlRange.Cells[i, 6].Text, 50));
					writer.Write("{0,-30}", format.Truncate(xlRange.Cells[i, 7].Text, 30));
					writer.Write("{0,10}", format.Truncate(xlRange.Cells[i, 8].Text, 10));
					writer.Write("{0,1}", format.Truncate(xlRange.Cells[i, 9].Text, 1));
					writer.Write("{0,15}", format.Truncate(xlRange.Cells[i, 10].Text, 15));
					writer.Write("{0,10}", format.Truncate(xlRange.Cells[i, 11].Text, 10));
					writer.Write("{0,11}", format.Truncate(xlRange.Cells[i, 12].Text, 11));
					writer.Write("{0,40}", format.Truncate(xlRange.Cells[i, 13].Text, 40));
					writer.Write("{0,5}", format.Truncate(xlRange.Cells[i, 14].Text, 5));
					writer.Write("{0,10}", format.Truncate(xlRange.Cells[i, 15].Text, 10));
					writer.Write("{0,20}", format.Truncate(xlRange.Cells[i, 16].Text, 20));
					writer.Write("{0,30}", format.Truncate(xlRange.Cells[i, 17].Text, 30));
					writer.Write("{0,2}", format.Truncate(xlRange.Cells[i, 18].Text, 2));
					writer.Write("{0,8}", format.Truncate(xlRange.Cells[i, 19].Text, 8));
					writer.Write("{0,10}", format.Truncate(xlRange.Cells[i, 20].Text, 10));
					writer.Write("{0,10}", format.Truncate(xlRange.Cells[i, 21].Text, 10));
					writer.Write("{0,1}", format.Truncate(xlRange.Cells[i, 22].Text, 1));
					writer.Write("{0,-20}", format.Truncate(xlRange.Cells[i, 23].Text, 20));
					writer.Write("{0,14}", format.Truncate(xlRange.Cells[i, 24].Text, 14));
					writer.WriteLine("{0}", (i + 1).ToString("000000"));

				}
				tamanhoFiller = 336;
				writer.Write("99{0}{1," + tamanhoFiller + "}" + "{2}", (rowCount + 2).ToString("000000"),
					filler, (rowCount + 2).ToString("000000"));
			}
			xlWorkbook.Close();
		}
		public void Layout200(string source, string arquivoSalvar, int agregadorCliente, char tipoCarga)
		{
			Excel.Application xlApp = new Excel.Application();
			Excel.Workbook xlWorkbook = xlApp.Workbooks.Open(source);
			Excel._Worksheet xlWorksheet = xlWorkbook.Sheets[1];
			Excel.Range xlRange = xlWorksheet.UsedRange;

			int rowCount = xlRange.Rows.Count;
			using (StreamWriter writer = new StreamWriter(arquivoSalvar))
			{
				DateTime data = DateTime.Now;
				string filler = " ";
				int tamanhoFiller = 310;
				string layout = "0200";

				writer.WriteLine("00{0}{1}000000{2}{3}{4," + tamanhoFiller + "}" + "000001", layout,
				agregadorCliente.ToString("000000"), data.ToString("dd/MM/yyyyHH:mm"), tipoCarga, filler);

				for (int i = 1; i < rowCount + 1; i++)
				{
					LeituraGravacao format = new LeituraGravacao();

					writer.Write("{0,2}", format.Truncate(xlRange.Cells[i, 1].Text, 2));
					writer.Write("{0,1}", format.Truncate(xlRange.Cells[i, 2].Text, 1));
					writer.Write("{0,6}", format.Truncate(xlRange.Cells[i, 3].Text, 6));
					writer.Write("{0,-19}", format.Truncate(xlRange.Cells[i, 4].Text, 19));
					writer.Write("{0,-19}", format.Truncate(xlRange.Cells[i, 5].Text, 19));
					writer.Write("{0,-50}", format.Truncate(xlRange.Cells[i, 6].Text, 50));
					writer.Write("{0,-30}", format.Truncate(xlRange.Cells[i, 7].Text, 30));
					writer.Write("{0,10}", format.Truncate(xlRange.Cells[i, 8].Text, 10));
					writer.Write("{0,1}", format.Truncate(xlRange.Cells[i, 9].Text, 1));
					writer.Write("{0,15}", format.Truncate(xlRange.Cells[i, 10].Text, 15));
					writer.Write("{0,10}", format.Truncate(xlRange.Cells[i, 11].Text, 10));
					writer.Write("{0,11}", format.Truncate(xlRange.Cells[i, 12].Text, 11));
					writer.Write("{0,40}", format.Truncate(xlRange.Cells[i, 13].Text, 40));
					writer.Write("{0,5}", format.Truncate(xlRange.Cells[i, 14].Text, 5));
					writer.Write("{0,10}", format.Truncate(xlRange.Cells[i, 15].Text, 10));
					writer.Write("{0,20}", format.Truncate(xlRange.Cells[i, 16].Text, 20));
					writer.Write("{0,30}", format.Truncate(xlRange.Cells[i, 17].Text, 30));
					writer.Write("{0,2}", format.Truncate(xlRange.Cells[i, 18].Text, 2));
					writer.Write("{0,8}", format.Truncate(xlRange.Cells[i, 19].Text, 8));
					writer.Write("{0,10}", format.Truncate(xlRange.Cells[i, 20].Text, 10));
					writer.Write("{0,10}", format.Truncate(xlRange.Cells[i, 21].Text, 10));
					writer.Write("{0,1}", format.Truncate(xlRange.Cells[i, 22].Text, 1));
					writer.Write("{0,-20}", format.Truncate(xlRange.Cells[i, 23].Text, 20));
					writer.Write("{0,14}", format.Truncate(xlRange.Cells[i, 24].Text, 14));
					writer.WriteLine("{0}", (i + 1).ToString("000000"));

				}
				tamanhoFiller = 336;
				writer.Write("99{0}{1," + tamanhoFiller + "}" + "{2}", (rowCount + 2).ToString("000000"),
					filler, (rowCount + 2).ToString("000000"));
			}
			xlWorkbook.Close();
		}
		public void Layout210(string source, string arquivoSalvar, int agregadorCliente, char tipoCarga)
		{
			Excel.Application xlApp = new Excel.Application();
			Excel.Workbook xlWorkbook = xlApp.Workbooks.Open(source);
			Excel._Worksheet xlWorksheet = xlWorkbook.Sheets[1];
			Excel.Range xlRange = xlWorksheet.UsedRange;

			int rowCount = xlRange.Rows.Count;
			using (StreamWriter writer = new StreamWriter(arquivoSalvar))
			{
				DateTime data = DateTime.Now;
				string filler = " ";
				int tamanhoFiller = 310;
				string layout = "0200";

				writer.WriteLine("00{0}{1}000000{2}{3}{4," + tamanhoFiller + "}" + "000001", layout,
				agregadorCliente.ToString("000000"), data.ToString("dd/MM/yyyyHH:mm"), tipoCarga, filler);

				for (int i = 1; i < rowCount + 1; i++)
				{
					LeituraGravacao format = new LeituraGravacao();

					writer.Write("{0,2}", format.Truncate(xlRange.Cells[i, 1].Text, 2));
					writer.Write("{0,1}", format.Truncate(xlRange.Cells[i, 2].Text, 1));
					writer.Write("{0,6}", format.Truncate(xlRange.Cells[i, 3].Text, 6));
					writer.Write("{0,-19}", format.Truncate(xlRange.Cells[i, 4].Text, 19));
					writer.Write("{0,-19}", format.Truncate(xlRange.Cells[i, 5].Text, 19));
					writer.Write("{0,-50}", format.Truncate(xlRange.Cells[i, 6].Text, 50));
					writer.Write("{0,-30}", format.Truncate(xlRange.Cells[i, 7].Text, 30));
					writer.Write("{0,10}", format.Truncate(xlRange.Cells[i, 8].Text, 10));
					writer.Write("{0,1}", format.Truncate(xlRange.Cells[i, 9].Text, 1));
					writer.Write("{0,15}", format.Truncate(xlRange.Cells[i, 10].Text, 15));
					writer.Write("{0,10}", format.Truncate(xlRange.Cells[i, 11].Text, 10));
					writer.Write("{0,11}", format.Truncate(xlRange.Cells[i, 12].Text, 11));
					writer.Write("{0,40}", format.Truncate(xlRange.Cells[i, 13].Text, 40));
					writer.Write("{0,5}", format.Truncate(xlRange.Cells[i, 14].Text, 5));
					writer.Write("{0,10}", format.Truncate(xlRange.Cells[i, 15].Text, 10));
					writer.Write("{0,20}", format.Truncate(xlRange.Cells[i, 16].Text, 20));
					writer.Write("{0,30}", format.Truncate(xlRange.Cells[i, 17].Text, 30));
					writer.Write("{0,2}", format.Truncate(xlRange.Cells[i, 18].Text, 2));
					writer.Write("{0,8}", format.Truncate(xlRange.Cells[i, 19].Text, 8));
					writer.Write("{0,10}", format.Truncate(xlRange.Cells[i, 20].Text, 10));
					writer.Write("{0,10}", format.Truncate(xlRange.Cells[i, 21].Text, 10));
					writer.Write("{0,1}", format.Truncate(xlRange.Cells[i, 22].Text, 1));
					writer.Write("{0,-20}", format.Truncate(xlRange.Cells[i, 23].Text, 20));
					writer.Write("{0,14}", format.Truncate(xlRange.Cells[i, 24].Text, 14));
					writer.WriteLine("{0}", (i + 1).ToString("000000"));

				}
				tamanhoFiller = 336;
				writer.Write("99{0}{1," + tamanhoFiller + "}" + "{2}", (rowCount + 2).ToString("000000"),
					filler, (rowCount + 2).ToString("000000"));
			}
			xlWorkbook.Close();
		}
		public void Layout300(string source, string arquivoSalvar, int agregadorCliente, char tipoCarga)
		{
			Excel.Application xlApp = new Excel.Application();
			Excel.Workbook xlWorkbook = xlApp.Workbooks.Open(source);
			Excel._Worksheet xlWorksheet = xlWorkbook.Sheets[1];
			Excel.Range xlRange = xlWorksheet.UsedRange;

			int rowCount = xlRange.Rows.Count;
			using (StreamWriter writer = new StreamWriter(arquivoSalvar))
			{
				DateTime data = DateTime.Now;
				string filler = " ";
				int tamanhoFiller = 310;
				string layout = "0200";

				writer.WriteLine("00{0}{1}000000{2}{3}{4," + tamanhoFiller + "}" + "000001", layout,
				agregadorCliente.ToString("000000"), data.ToString("dd/MM/yyyyHH:mm"), tipoCarga, filler);

				for (int i = 1; i < rowCount + 1; i++)
				{
					LeituraGravacao format = new LeituraGravacao();

					writer.Write("{0,2}", format.Truncate(xlRange.Cells[i, 1].Text, 2));
					writer.Write("{0,1}", format.Truncate(xlRange.Cells[i, 2].Text, 1));
					writer.Write("{0,6}", format.Truncate(xlRange.Cells[i, 3].Text, 6));
					writer.Write("{0,-19}", format.Truncate(xlRange.Cells[i, 4].Text, 19));
					writer.Write("{0,-19}", format.Truncate(xlRange.Cells[i, 5].Text, 19));
					writer.Write("{0,-50}", format.Truncate(xlRange.Cells[i, 6].Text, 50));
					writer.Write("{0,-30}", format.Truncate(xlRange.Cells[i, 7].Text, 30));
					writer.Write("{0,10}", format.Truncate(xlRange.Cells[i, 8].Text, 10));
					writer.Write("{0,1}", format.Truncate(xlRange.Cells[i, 9].Text, 1));
					writer.Write("{0,15}", format.Truncate(xlRange.Cells[i, 10].Text, 15));
					writer.Write("{0,10}", format.Truncate(xlRange.Cells[i, 11].Text, 10));
					writer.Write("{0,11}", format.Truncate(xlRange.Cells[i, 12].Text, 11));
					writer.Write("{0,40}", format.Truncate(xlRange.Cells[i, 13].Text, 40));
					writer.Write("{0,5}", format.Truncate(xlRange.Cells[i, 14].Text, 5));
					writer.Write("{0,10}", format.Truncate(xlRange.Cells[i, 15].Text, 10));
					writer.Write("{0,20}", format.Truncate(xlRange.Cells[i, 16].Text, 20));
					writer.Write("{0,30}", format.Truncate(xlRange.Cells[i, 17].Text, 30));
					writer.Write("{0,2}", format.Truncate(xlRange.Cells[i, 18].Text, 2));
					writer.Write("{0,8}", format.Truncate(xlRange.Cells[i, 19].Text, 8));
					writer.Write("{0,10}", format.Truncate(xlRange.Cells[i, 20].Text, 10));
					writer.Write("{0,10}", format.Truncate(xlRange.Cells[i, 21].Text, 10));
					writer.Write("{0,1}", format.Truncate(xlRange.Cells[i, 22].Text, 1));
					writer.Write("{0,-20}", format.Truncate(xlRange.Cells[i, 23].Text, 20));
					writer.Write("{0,14}", format.Truncate(xlRange.Cells[i, 24].Text, 14));
					writer.WriteLine("{0}", (i + 1).ToString("000000"));

				}
				tamanhoFiller = 336;
				writer.Write("99{0}{1," + tamanhoFiller + "}" + "{2}", (rowCount + 2).ToString("000000"),
					filler, (rowCount + 2).ToString("000000"));
			}
			xlWorkbook.Close();
		}
		public void Layout310(string source, string arquivoSalvar, int agregadorCliente, char tipoCarga)
		{
			Excel.Application xlApp = new Excel.Application();
			Excel.Workbook xlWorkbook = xlApp.Workbooks.Open(source);
			Excel._Worksheet xlWorksheet = xlWorkbook.Sheets[1];
			Excel.Range xlRange = xlWorksheet.UsedRange;

			int rowCount = xlRange.Rows.Count;
			using (StreamWriter writer = new StreamWriter(arquivoSalvar))
			{
				DateTime data = DateTime.Now;
				string filler = " ";
				int tamanhoFiller = 310;
				string layout = "0200";

				writer.WriteLine("00{0}{1}000000{2}{3}{4," + tamanhoFiller + "}" + "000001", layout,
				agregadorCliente.ToString("000000"), data.ToString("dd/MM/yyyyHH:mm"), tipoCarga, filler);

				for (int i = 1; i < rowCount + 1; i++)
				{
					LeituraGravacao format = new LeituraGravacao();

					writer.Write("{0,2}", format.Truncate(xlRange.Cells[i, 1].Text, 2));
					writer.Write("{0,1}", format.Truncate(xlRange.Cells[i, 2].Text, 1));
					writer.Write("{0,6}", format.Truncate(xlRange.Cells[i, 3].Text, 6));
					writer.Write("{0,-19}", format.Truncate(xlRange.Cells[i, 4].Text, 19));
					writer.Write("{0,-19}", format.Truncate(xlRange.Cells[i, 5].Text, 19));
					writer.Write("{0,-50}", format.Truncate(xlRange.Cells[i, 6].Text, 50));
					writer.Write("{0,-30}", format.Truncate(xlRange.Cells[i, 7].Text, 30));
					writer.Write("{0,10}", format.Truncate(xlRange.Cells[i, 8].Text, 10));
					writer.Write("{0,1}", format.Truncate(xlRange.Cells[i, 9].Text, 1));
					writer.Write("{0,15}", format.Truncate(xlRange.Cells[i, 10].Text, 15));
					writer.Write("{0,10}", format.Truncate(xlRange.Cells[i, 11].Text, 10));
					writer.Write("{0,11}", format.Truncate(xlRange.Cells[i, 12].Text, 11));
					writer.Write("{0,40}", format.Truncate(xlRange.Cells[i, 13].Text, 40));
					writer.Write("{0,5}", format.Truncate(xlRange.Cells[i, 14].Text, 5));
					writer.Write("{0,10}", format.Truncate(xlRange.Cells[i, 15].Text, 10));
					writer.Write("{0,20}", format.Truncate(xlRange.Cells[i, 16].Text, 20));
					writer.Write("{0,30}", format.Truncate(xlRange.Cells[i, 17].Text, 30));
					writer.Write("{0,2}", format.Truncate(xlRange.Cells[i, 18].Text, 2));
					writer.Write("{0,8}", format.Truncate(xlRange.Cells[i, 19].Text, 8));
					writer.Write("{0,10}", format.Truncate(xlRange.Cells[i, 20].Text, 10));
					writer.Write("{0,10}", format.Truncate(xlRange.Cells[i, 21].Text, 10));
					writer.Write("{0,1}", format.Truncate(xlRange.Cells[i, 22].Text, 1));
					writer.Write("{0,-20}", format.Truncate(xlRange.Cells[i, 23].Text, 20));
					writer.Write("{0,14}", format.Truncate(xlRange.Cells[i, 24].Text, 14));
					writer.WriteLine("{0}", (i + 1).ToString("000000"));

				}
				tamanhoFiller = 336;
				writer.Write("99{0}{1," + tamanhoFiller + "}" + "{2}", (rowCount + 2).ToString("000000"),
					filler, (rowCount + 2).ToString("000000"));
			}
			xlWorkbook.Close();
		}
	}

	public class LayoutsLimite
	{
		public void Layout200(string source, string arquivoSalvar, int agregadorCliente, char tipoCarga)
		{
			Excel.Application xlApp = new Excel.Application();
			Excel.Workbook xlWorkbook = xlApp.Workbooks.Open(source);
			Excel._Worksheet xlWorksheet = xlWorkbook.Sheets[1];
			Excel.Range xlRange = xlWorksheet.UsedRange;

			int rowCount = xlRange.Rows.Count;
			using (StreamWriter writer = new StreamWriter(arquivoSalvar))
			{
				DateTime data = DateTime.Now;
				string filler = " ";
				int tamanhoFiller = 310;
				string layout = "0200";

				writer.WriteLine("00{0}{1}000000{2}{3}{4," + tamanhoFiller + "}" + "000001", layout,
				agregadorCliente.ToString("000000"), data.ToString("dd/MM/yyyyHH:mm"), tipoCarga, filler);

				for (int i = 1; i < rowCount + 1; i++)
				{
					LeituraGravacao format = new LeituraGravacao();

					writer.Write("{0,2}", format.Truncate(xlRange.Cells[i, 1].Text, 2));
					writer.Write("{0,1}", format.Truncate(xlRange.Cells[i, 2].Text, 1));
					writer.Write("{0,6}", format.Truncate(xlRange.Cells[i, 3].Text, 6));
					writer.Write("{0,-19}", format.Truncate(xlRange.Cells[i, 4].Text, 19));
					writer.Write("{0,-19}", format.Truncate(xlRange.Cells[i, 5].Text, 19));
					writer.Write("{0,-50}", format.Truncate(xlRange.Cells[i, 6].Text, 50));
					writer.Write("{0,-30}", format.Truncate(xlRange.Cells[i, 7].Text, 30));
					writer.Write("{0,10}", format.Truncate(xlRange.Cells[i, 8].Text, 10));
					writer.Write("{0,1}", format.Truncate(xlRange.Cells[i, 9].Text, 1));
					writer.Write("{0,15}", format.Truncate(xlRange.Cells[i, 10].Text, 15));
					writer.Write("{0,10}", format.Truncate(xlRange.Cells[i, 11].Text, 10));
					writer.Write("{0,11}", format.Truncate(xlRange.Cells[i, 12].Text, 11));
					writer.Write("{0,40}", format.Truncate(xlRange.Cells[i, 13].Text, 40));
					writer.Write("{0,5}", format.Truncate(xlRange.Cells[i, 14].Text, 5));
					writer.Write("{0,10}", format.Truncate(xlRange.Cells[i, 15].Text, 10));
					writer.Write("{0,20}", format.Truncate(xlRange.Cells[i, 16].Text, 20));
					writer.Write("{0,30}", format.Truncate(xlRange.Cells[i, 17].Text, 30));
					writer.Write("{0,2}", format.Truncate(xlRange.Cells[i, 18].Text, 2));
					writer.Write("{0,8}", format.Truncate(xlRange.Cells[i, 19].Text, 8));
					writer.Write("{0,10}", format.Truncate(xlRange.Cells[i, 20].Text, 10));
					writer.Write("{0,10}", format.Truncate(xlRange.Cells[i, 21].Text, 10));
					writer.Write("{0,1}", format.Truncate(xlRange.Cells[i, 22].Text, 1));
					writer.Write("{0,-20}", format.Truncate(xlRange.Cells[i, 23].Text, 20));
					writer.Write("{0,14}", format.Truncate(xlRange.Cells[i, 24].Text, 14));
					writer.WriteLine("{0}", (i + 1).ToString("000000"));

				}
				tamanhoFiller = 336;
				writer.Write("99{0}{1," + tamanhoFiller + "}" + "{2}", (rowCount + 2).ToString("000000"),
					filler, (rowCount + 2).ToString("000000"));
			}
			xlWorkbook.Close();
		}
		public void Layout210(string source, string arquivoSalvar, int agregadorCliente, char tipoCarga)
		{
			Excel.Application xlApp = new Excel.Application();
			Excel.Workbook xlWorkbook = xlApp.Workbooks.Open(source);
			Excel._Worksheet xlWorksheet = xlWorkbook.Sheets[1];
			Excel.Range xlRange = xlWorksheet.UsedRange;

			int rowCount = xlRange.Rows.Count;
			using (StreamWriter writer = new StreamWriter(arquivoSalvar))
			{
				DateTime data = DateTime.Now;
				string filler = " ";
				int tamanhoFiller = 310;
				string layout = "0200";

				writer.WriteLine("00{0}{1}000000{2}{3}{4," + tamanhoFiller + "}" + "000001", layout,
				agregadorCliente.ToString("000000"), data.ToString("dd/MM/yyyyHH:mm"), tipoCarga, filler);

				for (int i = 1; i < rowCount + 1; i++)
				{
					LeituraGravacao format = new LeituraGravacao();

					writer.Write("{0,2}", format.Truncate(xlRange.Cells[i, 1].Text, 2));
					writer.Write("{0,1}", format.Truncate(xlRange.Cells[i, 2].Text, 1));
					writer.Write("{0,6}", format.Truncate(xlRange.Cells[i, 3].Text, 6));
					writer.Write("{0,-19}", format.Truncate(xlRange.Cells[i, 4].Text, 19));
					writer.Write("{0,-19}", format.Truncate(xlRange.Cells[i, 5].Text, 19));
					writer.Write("{0,-50}", format.Truncate(xlRange.Cells[i, 6].Text, 50));
					writer.Write("{0,-30}", format.Truncate(xlRange.Cells[i, 7].Text, 30));
					writer.Write("{0,10}", format.Truncate(xlRange.Cells[i, 8].Text, 10));
					writer.Write("{0,1}", format.Truncate(xlRange.Cells[i, 9].Text, 1));
					writer.Write("{0,15}", format.Truncate(xlRange.Cells[i, 10].Text, 15));
					writer.Write("{0,10}", format.Truncate(xlRange.Cells[i, 11].Text, 10));
					writer.Write("{0,11}", format.Truncate(xlRange.Cells[i, 12].Text, 11));
					writer.Write("{0,40}", format.Truncate(xlRange.Cells[i, 13].Text, 40));
					writer.Write("{0,5}", format.Truncate(xlRange.Cells[i, 14].Text, 5));
					writer.Write("{0,10}", format.Truncate(xlRange.Cells[i, 15].Text, 10));
					writer.Write("{0,20}", format.Truncate(xlRange.Cells[i, 16].Text, 20));
					writer.Write("{0,30}", format.Truncate(xlRange.Cells[i, 17].Text, 30));
					writer.Write("{0,2}", format.Truncate(xlRange.Cells[i, 18].Text, 2));
					writer.Write("{0,8}", format.Truncate(xlRange.Cells[i, 19].Text, 8));
					writer.Write("{0,10}", format.Truncate(xlRange.Cells[i, 20].Text, 10));
					writer.Write("{0,10}", format.Truncate(xlRange.Cells[i, 21].Text, 10));
					writer.Write("{0,1}", format.Truncate(xlRange.Cells[i, 22].Text, 1));
					writer.Write("{0,-20}", format.Truncate(xlRange.Cells[i, 23].Text, 20));
					writer.Write("{0,14}", format.Truncate(xlRange.Cells[i, 24].Text, 14));
					writer.WriteLine("{0}", (i + 1).ToString("000000"));

				}
				tamanhoFiller = 336;
				writer.Write("99{0}{1," + tamanhoFiller + "}" + "{2}", (rowCount + 2).ToString("000000"),
					filler, (rowCount + 2).ToString("000000"));
			}
			xlWorkbook.Close();
		}
		public void Layout300(string source, string arquivoSalvar, int agregadorCliente, char tipoCarga)
		{
			Excel.Application xlApp = new Excel.Application();
			Excel.Workbook xlWorkbook = xlApp.Workbooks.Open(source);
			Excel._Worksheet xlWorksheet = xlWorkbook.Sheets[1];
			Excel.Range xlRange = xlWorksheet.UsedRange;

			int rowCount = xlRange.Rows.Count;
			using (StreamWriter writer = new StreamWriter(arquivoSalvar))
			{
				DateTime data = DateTime.Now;
				string filler = " ";
				int tamanhoFiller = 310;
				string layout = "0200";

				writer.WriteLine("00{0}{1}000000{2}{3}{4," + tamanhoFiller + "}" + "000001", layout,
				agregadorCliente.ToString("000000"), data.ToString("dd/MM/yyyyHH:mm"), tipoCarga, filler);

				for (int i = 1; i < rowCount + 1; i++)
				{
					LeituraGravacao format = new LeituraGravacao();

					writer.Write("{0,2}", format.Truncate(xlRange.Cells[i, 1].Text, 2));
					writer.Write("{0,1}", format.Truncate(xlRange.Cells[i, 2].Text, 1));
					writer.Write("{0,6}", format.Truncate(xlRange.Cells[i, 3].Text, 6));
					writer.Write("{0,-19}", format.Truncate(xlRange.Cells[i, 4].Text, 19));
					writer.Write("{0,-19}", format.Truncate(xlRange.Cells[i, 5].Text, 19));
					writer.Write("{0,-50}", format.Truncate(xlRange.Cells[i, 6].Text, 50));
					writer.Write("{0,-30}", format.Truncate(xlRange.Cells[i, 7].Text, 30));
					writer.Write("{0,10}", format.Truncate(xlRange.Cells[i, 8].Text, 10));
					writer.Write("{0,1}", format.Truncate(xlRange.Cells[i, 9].Text, 1));
					writer.Write("{0,15}", format.Truncate(xlRange.Cells[i, 10].Text, 15));
					writer.Write("{0,10}", format.Truncate(xlRange.Cells[i, 11].Text, 10));
					writer.Write("{0,11}", format.Truncate(xlRange.Cells[i, 12].Text, 11));
					writer.Write("{0,40}", format.Truncate(xlRange.Cells[i, 13].Text, 40));
					writer.Write("{0,5}", format.Truncate(xlRange.Cells[i, 14].Text, 5));
					writer.Write("{0,10}", format.Truncate(xlRange.Cells[i, 15].Text, 10));
					writer.Write("{0,20}", format.Truncate(xlRange.Cells[i, 16].Text, 20));
					writer.Write("{0,30}", format.Truncate(xlRange.Cells[i, 17].Text, 30));
					writer.Write("{0,2}", format.Truncate(xlRange.Cells[i, 18].Text, 2));
					writer.Write("{0,8}", format.Truncate(xlRange.Cells[i, 19].Text, 8));
					writer.Write("{0,10}", format.Truncate(xlRange.Cells[i, 20].Text, 10));
					writer.Write("{0,10}", format.Truncate(xlRange.Cells[i, 21].Text, 10));
					writer.Write("{0,1}", format.Truncate(xlRange.Cells[i, 22].Text, 1));
					writer.Write("{0,-20}", format.Truncate(xlRange.Cells[i, 23].Text, 20));
					writer.Write("{0,14}", format.Truncate(xlRange.Cells[i, 24].Text, 14));
					writer.WriteLine("{0}", (i + 1).ToString("000000"));

				}
				tamanhoFiller = 336;
				writer.Write("99{0}{1," + tamanhoFiller + "}" + "{2}", (rowCount + 2).ToString("000000"),
					filler, (rowCount + 2).ToString("000000"));
			}
			xlWorkbook.Close();
		}
		public void Layout310(string source, string arquivoSalvar, int agregadorCliente, char tipoCarga)
		{
			Excel.Application xlApp = new Excel.Application();
			Excel.Workbook xlWorkbook = xlApp.Workbooks.Open(source);
			Excel._Worksheet xlWorksheet = xlWorkbook.Sheets[1];
			Excel.Range xlRange = xlWorksheet.UsedRange;

			int rowCount = xlRange.Rows.Count;
			using (StreamWriter writer = new StreamWriter(arquivoSalvar))
			{
				DateTime data = DateTime.Now;
				string filler = " ";
				int tamanhoFiller = 310;
				string layout = "0200";

				writer.WriteLine("00{0}{1}000000{2}{3}{4," + tamanhoFiller + "}" + "000001", layout,
				agregadorCliente.ToString("000000"), data.ToString("dd/MM/yyyyHH:mm"), tipoCarga, filler);

				for (int i = 1; i < rowCount + 1; i++)
				{
					LeituraGravacao format = new LeituraGravacao();

					writer.Write("{0,2}", format.Truncate(xlRange.Cells[i, 1].Text, 2));
					writer.Write("{0,1}", format.Truncate(xlRange.Cells[i, 2].Text, 1));
					writer.Write("{0,6}", format.Truncate(xlRange.Cells[i, 3].Text, 6));
					writer.Write("{0,-19}", format.Truncate(xlRange.Cells[i, 4].Text, 19));
					writer.Write("{0,-19}", format.Truncate(xlRange.Cells[i, 5].Text, 19));
					writer.Write("{0,-50}", format.Truncate(xlRange.Cells[i, 6].Text, 50));
					writer.Write("{0,-30}", format.Truncate(xlRange.Cells[i, 7].Text, 30));
					writer.Write("{0,10}", format.Truncate(xlRange.Cells[i, 8].Text, 10));
					writer.Write("{0,1}", format.Truncate(xlRange.Cells[i, 9].Text, 1));
					writer.Write("{0,15}", format.Truncate(xlRange.Cells[i, 10].Text, 15));
					writer.Write("{0,10}", format.Truncate(xlRange.Cells[i, 11].Text, 10));
					writer.Write("{0,11}", format.Truncate(xlRange.Cells[i, 12].Text, 11));
					writer.Write("{0,40}", format.Truncate(xlRange.Cells[i, 13].Text, 40));
					writer.Write("{0,5}", format.Truncate(xlRange.Cells[i, 14].Text, 5));
					writer.Write("{0,10}", format.Truncate(xlRange.Cells[i, 15].Text, 10));
					writer.Write("{0,20}", format.Truncate(xlRange.Cells[i, 16].Text, 20));
					writer.Write("{0,30}", format.Truncate(xlRange.Cells[i, 17].Text, 30));
					writer.Write("{0,2}", format.Truncate(xlRange.Cells[i, 18].Text, 2));
					writer.Write("{0,8}", format.Truncate(xlRange.Cells[i, 19].Text, 8));
					writer.Write("{0,10}", format.Truncate(xlRange.Cells[i, 20].Text, 10));
					writer.Write("{0,10}", format.Truncate(xlRange.Cells[i, 21].Text, 10));
					writer.Write("{0,1}", format.Truncate(xlRange.Cells[i, 22].Text, 1));
					writer.Write("{0,-20}", format.Truncate(xlRange.Cells[i, 23].Text, 20));
					writer.Write("{0,14}", format.Truncate(xlRange.Cells[i, 24].Text, 14));
					writer.WriteLine("{0}", (i + 1).ToString("000000"));

				}
				tamanhoFiller = 336;
				writer.Write("99{0}{1," + tamanhoFiller + "}" + "{2}", (rowCount + 2).ToString("000000"),
					filler, (rowCount + 2).ToString("000000"));
			}
			xlWorkbook.Close();
		}
	}
}
