using System;
using System.IO;
using Excel = Microsoft.Office.Interop.Excel;

namespace LayoutCarga
{

	public class LayoutsCSV
	{
		class Layout0100
		{
			public string Header00(int agregadorCliente, char tipoCarga)
			{
				DateTime data = DateTime.Now;
				int tamanhoFiller = 280;
				string filler = new string(' ', tamanhoFiller);
				string layout = "0100";
				string header = "00" + layout + agregadorCliente.ToString("000000") + "000000" + data.ToString("dd/MM/yyyyHH:mm") + tipoCarga
				+ filler + "000001";

				return header;
			}

			public string Trailer99(int rowCount, int agregadorCliente, char tipoCarga)
			{
				int tamanhoFiller = 306;
				string filler = new string(' ', tamanhoFiller);
				string trailer = "99" + (rowCount + 2).ToString("000000") + filler + (rowCount + 2).ToString("000000");

				return trailer;
			}

			public string Inclusao01(string[] source, int rowCount)
			{
				string linha = "";
				LeituraGravacao format = new LeituraGravacao();

				linha += format.Truncate(source[0], 2);
				linha += format.Truncate(source[1], 1);
				linha += format.Truncate(source[2], 6);
				linha += format.Truncate(source[3], 19);
				linha += format.Truncate(source[4], 19);
				linha += format.Truncate(source[5], 50);
				linha += format.Truncate(source[6], 30);
				linha += format.Truncate(source[7], 10);
				linha += format.Truncate(source[8], 1);
				linha += format.Truncate(source[9], 15);
				linha += format.Truncate(source[10], 10);
				linha += format.Truncate(source[11], 11);
				linha += format.Truncate(source[12], 40);
				linha += format.Truncate(source[13], 5);
				linha += format.Truncate(source[14], 10);
				linha += format.Truncate(source[15], 20);
				linha += format.Truncate(source[16], 30);
				linha += format.Truncate(source[17], 2);
				linha += format.Truncate(source[0], 8);
				linha += format.Truncate(source[0], 10);
				linha += format.Truncate(source[0], 10);
				linha += format.Truncate(source[0], 1);
				linha += format.Truncate(source[0], 4);
				linha += rowCount.ToString("000000");

				return linha;
			}
		}
	}
}
//		class Layout0200
//		{
//			public void Inclusao01(string source, string arquivoSalvar, int agregadorCliente, char tipoCarga)
//			{
//				Excel.Application xlApp = new Excel.Application();
//				Excel.Workbook xlWorkbook = xlApp.Workbooks.Open(source);
//				Excel._Worksheet xlWorksheet = xlWorkbook.Sheets[1];
//				Excel.Range xlRange = xlWorksheet.UsedRange;

//				int rowCount = xlRange.Rows.Count;

//				using (StreamWriter writer = new StreamWriter(arquivoSalvar)
//				{
//					DateTime data = DateTime.Now;
//					string filler = " ";
//					int tamanhoFiller = 310;
//					string layout = "0200";

//					writer.WriteLine("00{0}{1}000000{2}{3}{4," + tamanhoFiller + "}" + "000001", layout,
//					agregadorCliente.ToString("000000"), data.ToString("dd/MM/yyyyHH:mm"), tipoCarga, filler);

//					for (int i = 1; i < rowCount + 1; i++)
//					{
//						LeituraGravacao format = new LeituraGravacao();

//						linha += "{0,2}", format.Truncate(xlRange.Cells[i, 1].Text, 2);
//						linha += "{0,1}", format.Truncate(xlRange.Cells[i, 2].Text, 1);
//						linha += "{0,6}", format.Truncate(xlRange.Cells[i, 3].Text, 6);
//						linha += "{0,-19}", format.Truncate(xlRange.Cells[i, 4].Text, 19);
//						linha += "{0,-19}", format.Truncate(xlRange.Cells[i, 5].Text, 19);
//						linha += "{0,-50}", format.Truncate(xlRange.Cells[i, 6].Text, 50);
//						linha += "{0,-30}", format.Truncate(xlRange.Cells[i, 7].Text, 30);
//						linha += "{0,10}", format.Truncate(xlRange.Cells[i, 8].Text, 10);
//						linha += "{0,1}", format.Truncate(xlRange.Cells[i, 9].Text, 1);
//						linha += "{0,15}", format.Truncate(xlRange.Cells[i, 10].Text, 15);
//						linha += "{0,10}", format.Truncate(xlRange.Cells[i, 11].Text, 10);
//						linha += "{0,11}", format.Truncate(xlRange.Cells[i, 12].Text, 11);
//						linha += "{0,40}", format.Truncate(xlRange.Cells[i, 13].Text, 40);
//						linha += "{0,5}", format.Truncate(xlRange.Cells[i, 14].Text, 5);
//						linha += "{0,10}", format.Truncate(xlRange.Cells[i, 15].Text, 10);
//						linha += "{0,20}", format.Truncate(xlRange.Cells[i, 16].Text, 20);
//						linha += "{0,30}", format.Truncate(xlRange.Cells[i, 17].Text, 30);
//						linha += "{0,2}", format.Truncate(xlRange.Cells[i, 18].Text, 2);
//						linha += "{0,8}", format.Truncate(xlRange.Cells[i, 19].Text, 8);
//						linha += "{0,10}", format.Truncate(xlRange.Cells[i, 20].Text, 10);
//						linha += "{0,10}", format.Truncate(xlRange.Cells[i, 21].Text, 10);
//						linha += "{0,1}", format.Truncate(xlRange.Cells[i, 22].Text, 1);
//						linha += "{0,-20}", format.Truncate(xlRange.Cells[i, 23].Text, 20);
//						linha += "{0,14}", format.Truncate(xlRange.Cells[i, 24].Text, 14);
//						writer.WriteLine("{0}", (i + 1).ToString("000000");

//					}
//					tamanhoFiller = 336;
//					linha += "99{0}{1," + tamanhoFiller + "}" + "{2}", (rowCount + 2).ToString("000000"),
//						filler, (rowCount + 2).ToString("000000");
//				}
//				xlWorkbook.Close();
//			}
//			public void Limite04(string source, string arquivoSalvar, int agregadorCliente, char tipoCarga)
//			{
//				Excel.Application xlApp = new Excel.Application();
//				Excel.Workbook xlWorkbook = xlApp.Workbooks.Open(source);
//				Excel._Worksheet xlWorksheet = xlWorkbook.Sheets[1];
//				Excel.Range xlRange = xlWorksheet.UsedRange;

//				int rowCount = xlRange.Rows.Count;
//				using (StreamWriter writer = new StreamWriter(arquivoSalvar)
//				{
//					DateTime data = DateTime.Now;
//					string filler = " ";
//					int tamanhoFiller = 310;
//					string layout = "0200";

//					writer.WriteLine("00{0}{1}000000{2}{3}{4," + tamanhoFiller + "}" + "000001", layout,
//					agregadorCliente.ToString("000000"), data.ToString("dd/MM/yyyyHH:mm"), tipoCarga, filler);

//					for (int i = 1; i < rowCount + 1; i++)
//					{
//						LeituraGravacao format = new LeituraGravacao();

//						linha += "{0,2}", format.Truncate(xlRange.Cells[i, 1].Text, 2);
//						linha += "{0,1}", format.Truncate(xlRange.Cells[i, 2].Text, 1);
//						linha += "{0,6}", format.Truncate(xlRange.Cells[i, 3].Text, 6);
//						linha += "{0,-20}", format.Truncate(xlRange.Cells[i, 4].Text, 20);
//						linha += "{0,17}", format.Truncate(xlRange.Cells[i, 5].Text.ToString("00000000000000000"), 17);
//						linha += "{0,-50}", format.Truncate(xlRange.Cells[i, 6].Text, 10);
//						linha += "{0,288}", format.Truncate(xlRange.Cells[i, 7].Text, 288);
//						writer.WriteLine("{0}", (i + 1).ToString("000000");

//					}
//					tamanhoFiller = 336;
//					linha += "99{0}{1," + tamanhoFiller + "}" + "{2}", (rowCount + 2).ToString("000000"),
//						filler, (rowCount + 2).ToString("000000");
//				}
//				xlWorkbook.Close();
//			}
//			public void Demissao06(string source, string arquivoSalvar, int agregadorCliente, char tipoCarga)
//			{
//				Excel.Application xlApp = new Excel.Application();
//				Excel.Workbook xlWorkbook = xlApp.Workbooks.Open(source);
//				Excel._Worksheet xlWorksheet = xlWorkbook.Sheets[1];
//				Excel.Range xlRange = xlWorksheet.UsedRange;

//				int rowCount = xlRange.Rows.Count;
//				using (StreamWriter writer = new StreamWriter(arquivoSalvar)
//				{
//					DateTime data = DateTime.Now;
//					string filler = " ";
//					int tamanhoFiller = 310;
//					string layout = "0200";

//					writer.WriteLine("00{0}{1}000000{2}{3}{4," + tamanhoFiller + "}" + "000001", layout,
//					agregadorCliente.ToString("000000"), data.ToString("dd/MM/yyyyHH:mm"), tipoCarga, filler);

//					for (int i = 1; i < rowCount + 1; i++)
//					{
//						LeituraGravacao format = new LeituraGravacao();

//						linha += "{0,2}", format.Truncate(xlRange.Cells[i, 1].Text, 2);
//						linha += "{0,1}", format.Truncate(xlRange.Cells[i, 2].Text, 1);
//						linha += "{0,6}", format.Truncate(xlRange.Cells[i, 3].Text, 6);
//						linha += "{0,-20}", format.Truncate(xlRange.Cells[i, 4].Text, 20);
//						linha += "{0,10}", format.Truncate(xlRange.Cells[i, 5].Text, 10);
//						linha += "{0,305}", format.Truncate(xlRange.Cells[i, 6].Text, 305);
//						writer.WriteLine("{0}", (i + 1).ToString("000000");

//					}
//					tamanhoFiller = 336;
//					linha += "99{0}{1," + tamanhoFiller + "}" + "{2}", (rowCount + 2).ToString("000000"),
//						filler, (rowCount + 2).ToString("000000");
//				}
//				xlWorkbook.Close();
//			}
//		}
//		class Layout0210
//		{
//			public void Inclusao01(string source, string arquivoSalvar, int agregadorCliente, char tipoCarga)
//			{
//				Excel.Application xlApp = new Excel.Application();
//				Excel.Workbook xlWorkbook = xlApp.Workbooks.Open(source);
//				Excel._Worksheet xlWorksheet = xlWorkbook.Sheets[1];
//				Excel.Range xlRange = xlWorksheet.UsedRange;

//				int rowCount = xlRange.Rows.Count;
//				using (StreamWriter writer = new StreamWriter(arquivoSalvar)
//				{
//					DateTime data = DateTime.Now;
//					string filler = " ";
//					int tamanhoFiller = 310;
//					string layout = "0210";

//					writer.WriteLine("00{0}{1}000000{2}{3}{4," + tamanhoFiller + "}" + "000001", layout,
//					agregadorCliente.ToString("000000"), data.ToString("dd/MM/yyyyHH:mm"), tipoCarga, filler);

//					for (int i = 1; i < rowCount + 1; i++)
//					{
//						LeituraGravacao format = new LeituraGravacao();

//						linha += "{0,2}", format.Truncate(xlRange.Cells[i, 1].Text, 2);
//						linha += "{0,1}", format.Truncate(xlRange.Cells[i, 2].Text, 1);
//						linha += "{0,6}", format.Truncate(xlRange.Cells[i, 3].Text, 6);
//						linha += "{0,-19}", format.Truncate(xlRange.Cells[i, 4].Text, 19);
//						linha += "{0,-19}", format.Truncate(xlRange.Cells[i, 5].Text, 19);
//						linha += "{0,-50}", format.Truncate(xlRange.Cells[i, 6].Text, 50);
//						linha += "{0,-30}", format.Truncate(xlRange.Cells[i, 7].Text, 30);
//						linha += "{0,10}", format.Truncate(xlRange.Cells[i, 8].Text, 10);
//						linha += "{0,1}", format.Truncate(xlRange.Cells[i, 9].Text, 1);
//						linha += "{0,15}", format.Truncate(xlRange.Cells[i, 10].Text, 15);
//						linha += "{0,10}", format.Truncate(xlRange.Cells[i, 11].Text, 10);
//						linha += "{0,11}", format.Truncate(xlRange.Cells[i, 12].Text, 11);
//						linha += "{0,40}", format.Truncate(xlRange.Cells[i, 13].Text, 40);
//						linha += "{0,5}", format.Truncate(xlRange.Cells[i, 14].Text, 5);
//						linha += "{0,10}", format.Truncate(xlRange.Cells[i, 15].Text, 10);
//						linha += "{0,20}", format.Truncate(xlRange.Cells[i, 16].Text, 20);
//						linha += "{0,30}", format.Truncate(xlRange.Cells[i, 17].Text, 30);
//						linha += "{0,2}", format.Truncate(xlRange.Cells[i, 18].Text, 2);
//						linha += "{0,8}", format.Truncate(xlRange.Cells[i, 19].Text, 8);
//						linha += "{0,10}", format.Truncate(xlRange.Cells[i, 20].Text, 10);
//						linha += "{0,10}", format.Truncate(xlRange.Cells[i, 21].Text, 10);
//						linha += "{0,1}", format.Truncate(xlRange.Cells[i, 22].Text, 1);
//						linha += "{0,-20}", format.Truncate(xlRange.Cells[i, 23].Text, 20);
//						linha += "{0,1}", format.Truncate(xlRange.Cells[i, 24].Text, 1);
//						linha += "{0,1}", format.Truncate(xlRange.Cells[i, 25].Text, 1);
//						linha += "{0,12}", format.Truncate(xlRange.Cells[i, 26].Text, 12);
//						writer.WriteLine("{0}", (i + 1).ToString("000000");

//					}
//					tamanhoFiller = 336;
//					linha += "99{0}{1," + tamanhoFiller + "}" + "{2}", (rowCount + 2).ToString("000000"),
//						filler, (rowCount + 2).ToString("000000");
//				}
//				xlWorkbook.Close();
//			}
//			public void Limite04(string source, string arquivoSalvar, int agregadorCliente, char tipoCarga)
//			{
//				Excel.Application xlApp = new Excel.Application();
//				Excel.Workbook xlWorkbook = xlApp.Workbooks.Open(source);
//				Excel._Worksheet xlWorksheet = xlWorkbook.Sheets[1];
//				Excel.Range xlRange = xlWorksheet.UsedRange;

//				int rowCount = xlRange.Rows.Count;
//				using (StreamWriter writer = new StreamWriter(arquivoSalvar)
//				{
//					DateTime data = DateTime.Now;
//					string filler = " ";
//					int tamanhoFiller = 310;
//					string layout = "0210";

//					writer.WriteLine("00{0}{1}000000{2}{3}{4," + tamanhoFiller + "}" + "000001", layout,
//					agregadorCliente.ToString("000000"), data.ToString("dd/MM/yyyyHH:mm"), tipoCarga, filler);

//					for (int i = 1; i < rowCount + 1; i++)
//					{
//						LeituraGravacao format = new LeituraGravacao();

//						linha += "{0,2}", format.Truncate(xlRange.Cells[i, 1].Text, 2);
//						linha += "{0,1}", format.Truncate(xlRange.Cells[i, 2].Text, 1);
//						linha += "{0,6}", format.Truncate(xlRange.Cells[i, 3].Text, 6);
//						linha += "{0,-20}", format.Truncate(xlRange.Cells[i, 4].Text, 20);
//						linha += "{0,17}", format.Truncate(xlRange.Cells[i, 5].Text.ToString("00000000000000000"), 17);
//						linha += "{0,-50}", format.Truncate(xlRange.Cells[i, 6].Text, 10);
//						linha += "{0,288}", format.Truncate(xlRange.Cells[i, 7].Text, 288);
//						writer.WriteLine("{0}", (i + 1).ToString("000000");

//					}
//					tamanhoFiller = 336;
//					linha += "99{0}{1," + tamanhoFiller + "}" + "{2}", (rowCount + 2).ToString("000000"),
//						filler, (rowCount + 2).ToString("000000");
//				}
//				xlWorkbook.Close();
//			}
//			public void Demissao06(string source, string arquivoSalvar, int agregadorCliente, char tipoCarga)
//			{
//				Excel.Application xlApp = new Excel.Application();
//				Excel.Workbook xlWorkbook = xlApp.Workbooks.Open(source);
//				Excel._Worksheet xlWorksheet = xlWorkbook.Sheets[1];
//				Excel.Range xlRange = xlWorksheet.UsedRange;

//				int rowCount = xlRange.Rows.Count;
//				using (StreamWriter writer = new StreamWriter(arquivoSalvar)
//				{
//					DateTime data = DateTime.Now;
//					string filler = " ";
//					int tamanhoFiller = 310;
//					string layout = "0210";

//					writer.WriteLine("00{0}{1}000000{2}{3}{4," + tamanhoFiller + "}" + "000001", layout,
//					agregadorCliente.ToString("000000"), data.ToString("dd/MM/yyyyHH:mm"), tipoCarga, filler);

//					for (int i = 1; i < rowCount + 1; i++)
//					{
//						LeituraGravacao format = new LeituraGravacao();

//						linha += "{0,2}", format.Truncate(xlRange.Cells[i, 1].Text, 2);
//						linha += "{0,1}", format.Truncate(xlRange.Cells[i, 2].Text, 1);
//						linha += "{0,6}", format.Truncate(xlRange.Cells[i, 3].Text, 6);
//						linha += "{0,-20}", format.Truncate(xlRange.Cells[i, 4].Text, 20);
//						linha += "{0,10}", format.Truncate(xlRange.Cells[i, 5].Text, 10);
//						linha += "{0,305}", format.Truncate(xlRange.Cells[i, 6].Text, 305);
//						writer.WriteLine("{0}", (i + 1).ToString("000000");

//					}
//					tamanhoFiller = 336;
//					linha += "99{0}{1," + tamanhoFiller + "}" + "{2}", (rowCount + 2).ToString("000000"),
//						filler, (rowCount + 2).ToString("000000");
//				}
//				xlWorkbook.Close();
//			}
//		}
//		class Layout0220
//		{ }
//		class Layout0300
//		{
//			public void Inclusao01(string source, string arquivoSalvar, int agregadorCliente, char tipoCarga)
//			{
//				Excel.Application xlApp = new Excel.Application();
//				Excel.Workbook xlWorkbook = xlApp.Workbooks.Open(source);
//				Excel._Worksheet xlWorksheet = xlWorkbook.Sheets[1];
//				Excel.Range xlRange = xlWorksheet.UsedRange;

//				int rowCount = xlRange.Rows.Count;
//				using (StreamWriter writer = new StreamWriter(arquivoSalvar)
//				{
//					DateTime data = DateTime.Now;
//					string filler = " ";
//					int tamanhoFiller = 330;
//					string layout = "0300";

//					writer.WriteLine("00{0}{1}000000{2}{3}{4," + tamanhoFiller + "}" + "000001", layout,
//					agregadorCliente.ToString("000000"), data.ToString("dd/MM/yyyyHH:mm"), tipoCarga, filler);

//					for (int i = 1; i < rowCount + 1; i++)
//					{
//						LeituraGravacao format = new LeituraGravacao();

//						linha += "{0,2}", format.Truncate(xlRange.Cells[i, 1].Text, 2);
//						linha += "{0,1}", format.Truncate(xlRange.Cells[i, 2].Text, 1);
//						linha += "{0,6}", format.Truncate(xlRange.Cells[i, 3].Text, 6);
//						linha += "{0,-19}", format.Truncate(xlRange.Cells[i, 4].Text, 19);
//						linha += "{0,-19}", format.Truncate(xlRange.Cells[i, 5].Text, 19);
//						linha += "{0,-50}", format.Truncate(xlRange.Cells[i, 6].Text, 50);
//						linha += "{0,-30}", format.Truncate(xlRange.Cells[i, 7].Text, 30);
//						linha += "{0,10}", format.Truncate(xlRange.Cells[i, 8].Text, 10);
//						linha += "{0,1}", format.Truncate(xlRange.Cells[i, 9].Text, 1);
//						linha += "{0,15}", format.Truncate(xlRange.Cells[i, 10].Text, 15);
//						linha += "{0,10}", format.Truncate(xlRange.Cells[i, 11].Text, 10);
//						linha += "{0,11}", format.Truncate(xlRange.Cells[i, 12].Text, 11);
//						linha += "{0,40}", format.Truncate(xlRange.Cells[i, 13].Text, 40);
//						linha += "{0,5}", format.Truncate(xlRange.Cells[i, 14].Text, 5);
//						linha += "{0,10}", format.Truncate(xlRange.Cells[i, 15].Text, 10);
//						linha += "{0,20}", format.Truncate(xlRange.Cells[i, 16].Text, 20);
//						linha += "{0,30}", format.Truncate(xlRange.Cells[i, 17].Text, 30);
//						linha += "{0,2}", format.Truncate(xlRange.Cells[i, 18].Text, 2);
//						linha += "{0,8}", format.Truncate(xlRange.Cells[i, 19].Text, 8);
//						linha += "{0,10}", format.Truncate(xlRange.Cells[i, 20].Text, 10);
//						linha += "{0,10}", format.Truncate(xlRange.Cells[i, 21].Text, 10);
//						linha += "{0,1}", format.Truncate(xlRange.Cells[i, 22].Text, 1);
//						linha += "{0,-20}", format.Truncate(xlRange.Cells[i, 23].Text, 20);
//						linha += "{0,1}", format.Truncate(xlRange.Cells[i, 24].Text, 1);
//						linha += "{0,9}", format.Truncate(xlRange.Cells[i, 25].Text.ToString("000000000"), 9);
//						linha += "{0,18}", format.Truncate(xlRange.Cells[i, 26].Text, 18);
//						writer.WriteLine("{0}", (i + 1).ToString("000000");

//					}
//					tamanhoFiller = 356;
//					linha += "99{0}{1," + tamanhoFiller + "}" + "{2}", (rowCount + 2).ToString("000000"),
//						filler, (rowCount + 2).ToString("000000");
//				}
//				xlWorkbook.Close();
//			}
//			public void Limite04(string source, string arquivoSalvar, int agregadorCliente, char tipoCarga)
//			{
//				Excel.Application xlApp = new Excel.Application();
//				Excel.Workbook xlWorkbook = xlApp.Workbooks.Open(source);
//				Excel._Worksheet xlWorksheet = xlWorkbook.Sheets[1];
//				Excel.Range xlRange = xlWorksheet.UsedRange;

//				int rowCount = xlRange.Rows.Count;
//				using (StreamWriter writer = new StreamWriter(arquivoSalvar)
//				{
//					DateTime data = DateTime.Now;
//					string filler = " ";
//					int tamanhoFiller = 330;
//					string layout = "0300";

//					writer.WriteLine("00{0}{1}000000{2}{3}{4," + tamanhoFiller + "}" + "000001", layout,
//					agregadorCliente.ToString("000000"), data.ToString("dd/MM/yyyyHH:mm"), tipoCarga, filler);

//					for (int i = 1; i < rowCount + 1; i++)
//					{
//						LeituraGravacao format = new LeituraGravacao();

//						linha += "{0,2}", format.Truncate(xlRange.Cells[i, 1].Text, 2);
//						linha += "{0,1}", format.Truncate(xlRange.Cells[i, 2].Text, 1);
//						linha += "{0,6}", format.Truncate(xlRange.Cells[i, 3].Text, 6);
//						linha += "{0,-20}", format.Truncate(xlRange.Cells[i, 4].Text, 20);
//						linha += "{0,-17}", format.Truncate(xlRange.Cells[i, 5].Text.ToString("00000000000000000"), 17);
//						linha += "{0,10}", format.Truncate(xlRange.Cells[i, 6].Text, 10);
//						linha += "{0,308}", format.Truncate(xlRange.Cells[i, 7].Text, 308);
//						writer.WriteLine("{0}", (i + 1).ToString("000000");

//					}
//					tamanhoFiller = 356;
//					linha += "99{0}{1," + tamanhoFiller + "}" + "{2}", (rowCount + 2).ToString("000000"),
//						filler, (rowCount + 2).ToString("000000");
//				}
//				xlWorkbook.Close();
//			}
//			public void Demissao06(string source, string arquivoSalvar, int agregadorCliente, char tipoCarga)
//			{
//				Excel.Application xlApp = new Excel.Application();
//				Excel.Workbook xlWorkbook = xlApp.Workbooks.Open(source);
//				Excel._Worksheet xlWorksheet = xlWorkbook.Sheets[1];
//				Excel.Range xlRange = xlWorksheet.UsedRange;

//				int rowCount = xlRange.Rows.Count;
//				using (StreamWriter writer = new StreamWriter(arquivoSalvar)
//				{
//					DateTime data = DateTime.Now;
//					string filler = " ";
//					int tamanhoFiller = 330;
//					string layout = "0300";

//					writer.WriteLine("00{0}{1}000000{2}{3}{4," + tamanhoFiller + "}" + "000001", layout,
//					agregadorCliente.ToString("000000"), data.ToString("dd/MM/yyyyHH:mm"), tipoCarga, filler);

//					for (int i = 1; i < rowCount + 1; i++)
//					{
//						LeituraGravacao format = new LeituraGravacao();

//						linha += "{0,2}", format.Truncate(xlRange.Cells[i, 1].Text, 2);
//						linha += "{0,1}", format.Truncate(xlRange.Cells[i, 2].Text, 1);
//						linha += "{0,6}", format.Truncate(xlRange.Cells[i, 3].Text, 6);
//						linha += "{0,-6}", format.Truncate(xlRange.Cells[i, 4].Text, 6);
//						linha += "{0,-19}", format.Truncate(xlRange.Cells[i, 5].Text, 19);
//						linha += "{0,10}", format.Truncate(xlRange.Cells[i, 6].Text, 10);
//						linha += "{0,320}", format.Truncate(xlRange.Cells[i, 7].Text, 320);
//						writer.WriteLine("{0}", (i + 1).ToString("000000");

//					}
//					tamanhoFiller = 356;
//					linha += "99{0}{1," + tamanhoFiller + "}" + "{2}", (rowCount + 2).ToString("000000"),
//						filler, (rowCount + 2).ToString("000000");
//				}
//				xlWorkbook.Close();
//			}
//		}
//		class Layout0310
//		{
//			public void Inclusao01(string source, string arquivoSalvar, int agregadorCliente, char tipoCarga)
//			{
//				Excel.Application xlApp = new Excel.Application();
//				Excel.Workbook xlWorkbook = xlApp.Workbooks.Open(source);
//				Excel._Worksheet xlWorksheet = xlWorkbook.Sheets[1];
//				Excel.Range xlRange = xlWorksheet.UsedRange;

//				int rowCount = xlRange.Rows.Count;
//				using (StreamWriter writer = new StreamWriter(arquivoSalvar)
//				{
//					DateTime data = DateTime.Now;
//					string filler = " ";
//					int tamanhoFiller = 120;
//					string layout = "0310";

//					writer.WriteLine("00{0}{1}000000{2}{3}{4," + tamanhoFiller + "}" + "000001", layout,
//					agregadorCliente.ToString("000000"), data.ToString("dd/MM/yyyyHH:mm"), tipoCarga, filler);


//					LeituraGravacao format = new LeituraGravacao();
//					for (int i = 1; i < rowCount + 1; i++)
//					{
//						linha += "{0,2}", format.Truncate(xlRange.Cells[i, 1].Text, 2);
//						linha += "{0,1}", format.Truncate(xlRange.Cells[i, 2].Text, 1);
//						linha += "{0,6}", format.Truncate(xlRange.Cells[i, 3].Text, 6);
//						linha += "{0,6}", format.Truncate(xlRange.Cells[i, 4].Text, 6);
//						linha += "{0,-50}", format.Truncate(xlRange.Cells[i, 5].Text, 50);
//						linha += "{0,-20}", format.Truncate(xlRange.Cells[i, 6].Text, 20);
//						linha += "{0,2}", format.Truncate(xlRange.Cells[i, 7].Text.ToString("00"), 2);
//						linha += "{0,10}", format.Truncate(xlRange.Cells[i, 8].Text, 10);
//						linha += "{0,14}", format.Truncate(xlRange.Cells[i, 9].Text, 14);
//						linha += "{0,1}", format.Truncate(xlRange.Cells[i, 10].Text, 1);
//						linha += "{0,10}", format.Truncate(xlRange.Cells[i, 11].Text, 10);
//						linha += "{0,10}", format.Truncate(xlRange.Cells[i, 12].Text, 10);
//						linha += "{0,11}", format.Truncate(xlRange.Cells[i, 13].Text, 11);
//						linha += "{0,11}", format.Truncate(xlRange.Cells[i, 14].Text, 11);
//						writer.WriteLine("{0}", (i + 1).ToString("000000");
//					}

//					tamanhoFiller = 146;
//					linha += "99{0}{1," + tamanhoFiller + "}" + "{2}", (rowCount + 2).ToString("000000"),
//						filler, (rowCount + 2).ToString("000000");
//				}

//				xlWorkbook.Close();
//			}
//			public void Limite04(string source, string arquivoSalvar, int agregadorCliente, char tipoCarga)
//			{
//				Excel.Application xlApp = new Excel.Application();
//				Excel.Workbook xlWorkbook = xlApp.Workbooks.Open(source);
//				Excel._Worksheet xlWorksheet = xlWorkbook.Sheets[1];
//				Excel.Range xlRange = xlWorksheet.UsedRange;

//				int rowCount = xlRange.Rows.Count;
//				using (StreamWriter writer = new StreamWriter(arquivoSalvar)
//				{
//					DateTime data = DateTime.Now;
//					string filler = " ";
//					int tamanhoFiller = 120;
//					string layout = "0310";

//					writer.WriteLine("00{0}{1}000000{2}{3}{4," + tamanhoFiller + "}" + "000001", layout,
//					agregadorCliente.ToString("000000"), data.ToString("dd/MM/yyyyHH:mm"), tipoCarga, filler);

//					for (int i = 1; i < rowCount + 1; i++)
//					{
//						LeituraGravacao format = new LeituraGravacao();

//						linha += "{0,2}", format.Truncate(xlRange.Cells[i, 1].Text, 2);
//						linha += "{0,6}", format.Truncate(xlRange.Cells[i, 2].Text, 6);
//						linha += "{0,6}", format.Truncate(xlRange.Cells[i, 3].Text, 6);
//						linha += "{0,-20}", format.Truncate(xlRange.Cells[i, 4].Text, 20);
//						linha += "{0,17}", format.Truncate(xlRange.Cells[i, 5].Text.ToString("00000000000000000"), 17);
//						linha += "{0,10}", format.Truncate(xlRange.Cells[i, 6].Text, 10);
//						linha += "{0,93}", format.Truncate(xlRange.Cells[i, 7].Text, 93);
//						writer.WriteLine("{0}", (i + 1).ToString("000000");

//					}
//					tamanhoFiller = 146;
//					linha += "99{0}{1," + tamanhoFiller + "}" + "{2}", (rowCount + 2).ToString("000000"),
//						filler, (rowCount + 2).ToString("000000");
//				}
//				xlWorkbook.Close();
//			}
//			public void Demissao06(string source, string arquivoSalvar, int agregadorCliente, char tipoCarga)
//			{
//				Excel.Application xlApp = new Excel.Application();
//				Excel.Workbook xlWorkbook = xlApp.Workbooks.Open(source);
//				Excel._Worksheet xlWorksheet = xlWorkbook.Sheets[1];
//				Excel.Range xlRange = xlWorksheet.UsedRange;

//				int rowCount = xlRange.Rows.Count;
//				using (StreamWriter writer = new StreamWriter(arquivoSalvar)
//				{
//					DateTime data = DateTime.Now;
//					string filler = " ";
//					int tamanhoFiller = 120;
//					string layout = "0310";

//					writer.WriteLine("00{0}{1}000000{2}{3}{4," + tamanhoFiller + "}" + "000001", layout,
//					agregadorCliente.ToString("000000"), data.ToString("dd/MM/yyyyHH:mm"), tipoCarga, filler);

//					for (int i = 1; i < rowCount + 1; i++)
//					{
//						LeituraGravacao format = new LeituraGravacao();

//						linha += "{0,2}", format.Truncate(xlRange.Cells[i, 1].Text, 2);
//						linha += "{0,6}", format.Truncate(xlRange.Cells[i, 2].Text, 6);
//						linha += "{0,6}", format.Truncate(xlRange.Cells[i, 3].Text, 6);
//						linha += "{0,-20}", format.Truncate(xlRange.Cells[i, 4].Text, 20);
//						linha += "{0,10}", format.Truncate(xlRange.Cells[i, 5].Text, 10);
//						linha += "{0,110}", format.Truncate(xlRange.Cells[i, 6].Text, 110);
//						writer.WriteLine("{0}", (i + 1).ToString("000000");

//					}
//					tamanhoFiller = 146;
//					linha += "99{0}{1," + tamanhoFiller + "}" + "{2}", (rowCount + 2).ToString("000000"),
//						filler, (rowCount + 2).ToString("000000");
//				}
//				xlWorkbook.Close();
//			}
//		}
//	}
//}

