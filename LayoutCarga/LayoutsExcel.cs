using System;
using System.IO;
using Excel = Microsoft.Office.Interop.Excel;

namespace LayoutCarga
{
	public class LayoutsExcel
	{
		class Layout0100
		{
			public void Header00(string source, string arquivoSalvar, int agregadorCliente, char tipoCarga)
			{
				DateTime data = DateTime.Now;
				string filler = " ";
				int tamanhoFiller = 280;
				string layout = "0100";
				using (StreamWriter writer = new StreamWriter(arquivoSalvar))
				{
					writer.WriteLine("00{0}{1}000000{2}{3}{4," + tamanhoFiller + "}" + "000001", layout,
					agregadorCliente.ToString("000000"), data.ToString("dd/MM/yyyyHH:mm"), tipoCarga, filler);
				}
			}
			public void Trailer99(string source, string arquivoSalvar, int agregadorCliente, char tipoCarga)
			{
				Excel.Application xlApp = new Excel.Application();
				Excel.Workbook xlWorkbook = xlApp.Workbooks.Open(source);
				Excel._Worksheet xlWorksheet = xlWorkbook.Sheets[1];
				Excel.Range xlRange = xlWorksheet.UsedRange;
				string filler = " ";
				int tamanhoFiller;
				int rowCount = xlRange.Rows.Count;

				using (StreamWriter writer = new StreamWriter(arquivoSalvar))
				{
					tamanhoFiller = 306;
					writer.Write("99{0}{1," + tamanhoFiller + "}" + "{2}", (rowCount + 2).ToString("000000"),
						filler, (rowCount + 2).ToString("000000"));
				}
			}
			public void Inclusao01(string source, string arquivoSalvar, int agregadorCliente, char tipoCarga)
			{
				Excel.Application xlApp = new Excel.Application();
				Excel.Workbook xlWorkbook = xlApp.Workbooks.Open(source);
				Excel._Worksheet xlWorksheet = xlWorkbook.Sheets[1];
				Excel.Range xlRange = xlWorksheet.UsedRange;

				int rowCount = xlRange.Rows.Count;
				using (StreamWriter writer = new StreamWriter(arquivoSalvar))
				{
					LeituraGravacao format = new LeituraGravacao();
					for (int i = 1; i < rowCount + 1; i++)
					{
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
						writer.Write("{0,4}", format.Truncate(xlRange.Cells[i, 24].Text, 4));
						writer.WriteLine("{0}", (i + 1).ToString("000000"));
					}
				}
				xlWorkbook.Close();
			}
		}
		class Layout0200
		{
			public void Header00(string source, string arquivoSalvar, int agregadorCliente, char tipoCarga)
			{
				DateTime data = DateTime.Now;
				string filler = " ";
				int tamanhoFiller = 310;
				string layout = "0200";

				using (StreamWriter writer = new StreamWriter(arquivoSalvar))
				{
					writer.WriteLine("00{0}{1}000000{2}{3}{4," + tamanhoFiller + "}" + "000001", layout,
					agregadorCliente.ToString("000000"), data.ToString("dd/MM/yyyyHH:mm"), tipoCarga, filler);
				}
			}
			public void Trailer99(string source, string arquivoSalvar, int agregadorCliente, char tipoCarga)
			{
				Excel.Application xlApp = new Excel.Application();
				Excel.Workbook xlWorkbook = xlApp.Workbooks.Open(source);
				Excel._Worksheet xlWorksheet = xlWorkbook.Sheets[1];
				Excel.Range xlRange = xlWorksheet.UsedRange;
				string filler = " ";
				int tamanhoFiller;
				int rowCount = xlRange.Rows.Count;

				using (StreamWriter writer = new StreamWriter(arquivoSalvar))
				{
					tamanhoFiller = 306;
					writer.Write("99{0}{1," + tamanhoFiller + "}" + "{2}", (rowCount + 2).ToString("000000"),
						filler, (rowCount + 2).ToString("000000"));
				}
			}
			public void Inclusao01(string source, string arquivoSalvar, int agregadorCliente, char tipoCarga)
			{
				Excel.Application xlApp = new Excel.Application();
				Excel.Workbook xlWorkbook = xlApp.Workbooks.Open(source);
				Excel._Worksheet xlWorksheet = xlWorkbook.Sheets[1];
				Excel.Range xlRange = xlWorksheet.UsedRange;

				int rowCount = xlRange.Rows.Count;

				using (StreamWriter writer = new StreamWriter(arquivoSalvar))
				{
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
				}
				xlWorkbook.Close();
			}
			public void Limite04(string source, string arquivoSalvar, int agregadorCliente, char tipoCarga)
			{
				Excel.Application xlApp = new Excel.Application();
				Excel.Workbook xlWorkbook = xlApp.Workbooks.Open(source);
				Excel._Worksheet xlWorksheet = xlWorkbook.Sheets[1];
				Excel.Range xlRange = xlWorksheet.UsedRange;

				int rowCount = xlRange.Rows.Count;
				using (StreamWriter writer = new StreamWriter(arquivoSalvar))
				{
					for (int i = 1; i < rowCount + 1; i++)
					{
						LeituraGravacao format = new LeituraGravacao();

						writer.Write("{0,2}", format.Truncate(xlRange.Cells[i, 1].Text, 2));
						writer.Write("{0,1}", format.Truncate(xlRange.Cells[i, 2].Text, 1));
						writer.Write("{0,6}", format.Truncate(xlRange.Cells[i, 3].Text, 6));
						writer.Write("{0,-20}", format.Truncate(xlRange.Cells[i, 4].Text, 20));
						writer.Write("{0,17}", format.Truncate(xlRange.Cells[i, 5].Text.ToString("00000000000000000"), 17));
						writer.Write("{0,-50}", format.Truncate(xlRange.Cells[i, 6].Text, 10));
						writer.Write("{0,288}", format.Truncate(xlRange.Cells[i, 7].Text, 288));
						writer.WriteLine("{0}", (i + 1).ToString("000000"));

					}
				}
				xlWorkbook.Close();
			}
			public void Demissao06(string source, string arquivoSalvar, int agregadorCliente, char tipoCarga)
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
						writer.Write("{0,-20}", format.Truncate(xlRange.Cells[i, 4].Text, 20));
						writer.Write("{0,10}", format.Truncate(xlRange.Cells[i, 5].Text, 10));
						writer.Write("{0,305}", format.Truncate(xlRange.Cells[i, 6].Text, 305));
						writer.WriteLine("{0}", (i + 1).ToString("000000"));

					}
					tamanhoFiller = 336;
					writer.Write("99{0}{1," + tamanhoFiller + "}" + "{2}", (rowCount + 2).ToString("000000"),
						filler, (rowCount + 2).ToString("000000"));
				}
				xlWorkbook.Close();
			}
		}
		class Layout0210
		{
			public void Header00(string source, string arquivoSalvar, int agregadorCliente, char tipoCarga)
			{
				DateTime data = DateTime.Now;
				string filler = " ";
				int tamanhoFiller = 280;
				string layout = "0100";
				using (StreamWriter writer = new StreamWriter(arquivoSalvar))
				{
					writer.WriteLine("00{0}{1}000000{2}{3}{4," + tamanhoFiller + "}" + "000001", layout,
					agregadorCliente.ToString("000000"), data.ToString("dd/MM/yyyyHH:mm"), tipoCarga, filler);
				}
			}
			public void Trailer99(string source, string arquivoSalvar, int agregadorCliente, char tipoCarga)
			{
				Excel.Application xlApp = new Excel.Application();
				Excel.Workbook xlWorkbook = xlApp.Workbooks.Open(source);
				Excel._Worksheet xlWorksheet = xlWorkbook.Sheets[1];
				Excel.Range xlRange = xlWorksheet.UsedRange;
				string filler = " ";
				int tamanhoFiller = 280;
				int rowCount = xlRange.Rows.Count;

				using (StreamWriter writer = new StreamWriter(arquivoSalvar))
				{
					tamanhoFiller = 306;
					writer.Write("99{0}{1," + tamanhoFiller + "}" + "{2}", (rowCount + 2).ToString("000000"),
						filler, (rowCount + 2).ToString("000000"));
				}
			}
			public void Inclusao01(string source, string arquivoSalvar, int agregadorCliente, char tipoCarga)
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
					string layout = "0210";

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
						writer.Write("{0,1}", format.Truncate(xlRange.Cells[i, 24].Text, 1));
						writer.Write("{0,1}", format.Truncate(xlRange.Cells[i, 25].Text, 1));
						writer.Write("{0,12}", format.Truncate(xlRange.Cells[i, 26].Text, 12));
						writer.WriteLine("{0}", (i + 1).ToString("000000"));

					}
					tamanhoFiller = 336;
					writer.Write("99{0}{1," + tamanhoFiller + "}" + "{2}", (rowCount + 2).ToString("000000"),
						filler, (rowCount + 2).ToString("000000"));
				}
				xlWorkbook.Close();
			}
			public void Limite04(string source, string arquivoSalvar, int agregadorCliente, char tipoCarga)
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
					string layout = "0210";

					writer.WriteLine("00{0}{1}000000{2}{3}{4," + tamanhoFiller + "}" + "000001", layout,
					agregadorCliente.ToString("000000"), data.ToString("dd/MM/yyyyHH:mm"), tipoCarga, filler);

					for (int i = 1; i < rowCount + 1; i++)
					{
						LeituraGravacao format = new LeituraGravacao();

						writer.Write("{0,2}", format.Truncate(xlRange.Cells[i, 1].Text, 2));
						writer.Write("{0,1}", format.Truncate(xlRange.Cells[i, 2].Text, 1));
						writer.Write("{0,6}", format.Truncate(xlRange.Cells[i, 3].Text, 6));
						writer.Write("{0,-20}", format.Truncate(xlRange.Cells[i, 4].Text, 20));
						writer.Write("{0,17}", format.Truncate(xlRange.Cells[i, 5].Text.ToString("00000000000000000"), 17));
						writer.Write("{0,-50}", format.Truncate(xlRange.Cells[i, 6].Text, 10));
						writer.Write("{0,288}", format.Truncate(xlRange.Cells[i, 7].Text, 288));
						writer.WriteLine("{0}", (i + 1).ToString("000000"));

					}
					tamanhoFiller = 336;
					writer.Write("99{0}{1," + tamanhoFiller + "}" + "{2}", (rowCount + 2).ToString("000000"),
						filler, (rowCount + 2).ToString("000000"));
				}
				xlWorkbook.Close();
			}
			public void Demissao06(string source, string arquivoSalvar, int agregadorCliente, char tipoCarga)
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
					string layout = "0210";

					writer.WriteLine("00{0}{1}000000{2}{3}{4," + tamanhoFiller + "}" + "000001", layout,
					agregadorCliente.ToString("000000"), data.ToString("dd/MM/yyyyHH:mm"), tipoCarga, filler);

					for (int i = 1; i < rowCount + 1; i++)
					{
						LeituraGravacao format = new LeituraGravacao();

						writer.Write("{0,2}", format.Truncate(xlRange.Cells[i, 1].Text, 2));
						writer.Write("{0,1}", format.Truncate(xlRange.Cells[i, 2].Text, 1));
						writer.Write("{0,6}", format.Truncate(xlRange.Cells[i, 3].Text, 6));
						writer.Write("{0,-20}", format.Truncate(xlRange.Cells[i, 4].Text, 20));
						writer.Write("{0,10}", format.Truncate(xlRange.Cells[i, 5].Text, 10));
						writer.Write("{0,305}", format.Truncate(xlRange.Cells[i, 6].Text, 305));
						writer.WriteLine("{0}", (i + 1).ToString("000000"));

					}
					tamanhoFiller = 336;
					writer.Write("99{0}{1," + tamanhoFiller + "}" + "{2}", (rowCount + 2).ToString("000000"),
						filler, (rowCount + 2).ToString("000000"));
				}
				xlWorkbook.Close();
			}
		}
		class Layout0220
		{
			public void Header00(string source, string arquivoSalvar, int agregadorCliente, char tipoCarga)
			{
				DateTime data = DateTime.Now;
				string filler = " ";
				int tamanhoFiller = 280;
				string layout = "0100";
				using (StreamWriter writer = new StreamWriter(arquivoSalvar))
				{
					writer.WriteLine("00{0}{1}000000{2}{3}{4," + tamanhoFiller + "}" + "000001", layout,
					agregadorCliente.ToString("000000"), data.ToString("dd/MM/yyyyHH:mm"), tipoCarga, filler);
				}
			}
			public void Trailer99(string source, string arquivoSalvar, int agregadorCliente, char tipoCarga)
			{
				Excel.Application xlApp = new Excel.Application();
				Excel.Workbook xlWorkbook = xlApp.Workbooks.Open(source);
				Excel._Worksheet xlWorksheet = xlWorkbook.Sheets[1];
				Excel.Range xlRange = xlWorksheet.UsedRange;
				string filler = " ";
				int tamanhoFiller = 280;
				int rowCount = xlRange.Rows.Count;

				using (StreamWriter writer = new StreamWriter(arquivoSalvar))
				{
					tamanhoFiller = 306;
					writer.Write("99{0}{1," + tamanhoFiller + "}" + "{2}", (rowCount + 2).ToString("000000"),
						filler, (rowCount + 2).ToString("000000"));
				}
			}
		}
		class Layout0300
		{
			public void Header00(string source, string arquivoSalvar, int agregadorCliente, char tipoCarga)
			{
				DateTime data = DateTime.Now;
				string filler = " ";
				int tamanhoFiller = 280;
				string layout = "0100";
				using (StreamWriter writer = new StreamWriter(arquivoSalvar))
				{
					writer.WriteLine("00{0}{1}000000{2}{3}{4," + tamanhoFiller + "}" + "000001", layout,
					agregadorCliente.ToString("000000"), data.ToString("dd/MM/yyyyHH:mm"), tipoCarga, filler);
				}
			}
			public void Trailer99(string source, string arquivoSalvar, int agregadorCliente, char tipoCarga)
			{
				Excel.Application xlApp = new Excel.Application();
				Excel.Workbook xlWorkbook = xlApp.Workbooks.Open(source);
				Excel._Worksheet xlWorksheet = xlWorkbook.Sheets[1];
				Excel.Range xlRange = xlWorksheet.UsedRange;
				string filler = " ";
				int tamanhoFiller = 280;
				int rowCount = xlRange.Rows.Count;

				using (StreamWriter writer = new StreamWriter(arquivoSalvar))
				{
					tamanhoFiller = 306;
					writer.Write("99{0}{1," + tamanhoFiller + "}" + "{2}", (rowCount + 2).ToString("000000"),
						filler, (rowCount + 2).ToString("000000"));
				}
			}
			public void Inclusao01(string source, string arquivoSalvar, int agregadorCliente, char tipoCarga)
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
					int tamanhoFiller = 330;
					string layout = "0300";

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
						writer.Write("{0,1}", format.Truncate(xlRange.Cells[i, 24].Text, 1));
						writer.Write("{0,9}", format.Truncate(xlRange.Cells[i, 25].Text.ToString("000000000"), 9));
						writer.Write("{0,18}", format.Truncate(xlRange.Cells[i, 26].Text, 18));
						writer.WriteLine("{0}", (i + 1).ToString("000000"));

					}
					tamanhoFiller = 356;
					writer.Write("99{0}{1," + tamanhoFiller + "}" + "{2}", (rowCount + 2).ToString("000000"),
						filler, (rowCount + 2).ToString("000000"));
				}
				xlWorkbook.Close();
			}
			public void Limite04(string source, string arquivoSalvar, int agregadorCliente, char tipoCarga)
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
					int tamanhoFiller = 330;
					string layout = "0300";

					writer.WriteLine("00{0}{1}000000{2}{3}{4," + tamanhoFiller + "}" + "000001", layout,
					agregadorCliente.ToString("000000"), data.ToString("dd/MM/yyyyHH:mm"), tipoCarga, filler);

					for (int i = 1; i < rowCount + 1; i++)
					{
						LeituraGravacao format = new LeituraGravacao();

						writer.Write("{0,2}", format.Truncate(xlRange.Cells[i, 1].Text, 2));
						writer.Write("{0,1}", format.Truncate(xlRange.Cells[i, 2].Text, 1));
						writer.Write("{0,6}", format.Truncate(xlRange.Cells[i, 3].Text, 6));
						writer.Write("{0,-20}", format.Truncate(xlRange.Cells[i, 4].Text, 20));
						writer.Write("{0,-17}", format.Truncate(xlRange.Cells[i, 5].Text.ToString("00000000000000000"), 17));
						writer.Write("{0,10}", format.Truncate(xlRange.Cells[i, 6].Text, 10));
						writer.Write("{0,308}", format.Truncate(xlRange.Cells[i, 7].Text, 308));
						writer.WriteLine("{0}", (i + 1).ToString("000000"));

					}
					tamanhoFiller = 356;
					writer.Write("99{0}{1," + tamanhoFiller + "}" + "{2}", (rowCount + 2).ToString("000000"),
						filler, (rowCount + 2).ToString("000000"));
				}
				xlWorkbook.Close();
			}
			public void Demissao06(string source, string arquivoSalvar, int agregadorCliente, char tipoCarga)
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
					int tamanhoFiller = 330;
					string layout = "0300";

					writer.WriteLine("00{0}{1}000000{2}{3}{4," + tamanhoFiller + "}" + "000001", layout,
					agregadorCliente.ToString("000000"), data.ToString("dd/MM/yyyyHH:mm"), tipoCarga, filler);

					for (int i = 1; i < rowCount + 1; i++)
					{
						LeituraGravacao format = new LeituraGravacao();

						writer.Write("{0,2}", format.Truncate(xlRange.Cells[i, 1].Text, 2));
						writer.Write("{0,1}", format.Truncate(xlRange.Cells[i, 2].Text, 1));
						writer.Write("{0,6}", format.Truncate(xlRange.Cells[i, 3].Text, 6));
						writer.Write("{0,-6}", format.Truncate(xlRange.Cells[i, 4].Text, 6));
						writer.Write("{0,-19}", format.Truncate(xlRange.Cells[i, 5].Text, 19));
						writer.Write("{0,10}", format.Truncate(xlRange.Cells[i, 6].Text, 10));
						writer.Write("{0,320}", format.Truncate(xlRange.Cells[i, 7].Text, 320));
						writer.WriteLine("{0}", (i + 1).ToString("000000"));

					}
					tamanhoFiller = 356;
					writer.Write("99{0}{1," + tamanhoFiller + "}" + "{2}", (rowCount + 2).ToString("000000"),
						filler, (rowCount + 2).ToString("000000"));
				}
				xlWorkbook.Close();
			}
		}
		class Layout0310
		{
			public void Header00(string source, string arquivoSalvar, int agregadorCliente, char tipoCarga)
			{
				DateTime data = DateTime.Now;
				string filler = " ";
				int tamanhoFiller = 280;
				string layout = "0100";
				using (StreamWriter writer = new StreamWriter(arquivoSalvar))
				{
					writer.WriteLine("00{0}{1}000000{2}{3}{4," + tamanhoFiller + "}" + "000001", layout,
					agregadorCliente.ToString("000000"), data.ToString("dd/MM/yyyyHH:mm"), tipoCarga, filler);
				}
			}
			public void Trailer99(string source, string arquivoSalvar, int agregadorCliente, char tipoCarga)
			{
				Excel.Application xlApp = new Excel.Application();
				Excel.Workbook xlWorkbook = xlApp.Workbooks.Open(source);
				Excel._Worksheet xlWorksheet = xlWorkbook.Sheets[1];
				Excel.Range xlRange = xlWorksheet.UsedRange;
				string filler = " ";
				int tamanhoFiller = 280;
				int rowCount = xlRange.Rows.Count;

				using (StreamWriter writer = new StreamWriter(arquivoSalvar))
				{
					tamanhoFiller = 306;
					writer.Write("99{0}{1," + tamanhoFiller + "}" + "{2}", (rowCount + 2).ToString("000000"),
						filler, (rowCount + 2).ToString("000000"));
				}
			}
			public void Inclusao01(string source, string arquivoSalvar, int agregadorCliente, char tipoCarga)
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
					int tamanhoFiller = 120;
					string layout = "0310";

					writer.WriteLine("00{0}{1}000000{2}{3}{4," + tamanhoFiller + "}" + "000001", layout,
					agregadorCliente.ToString("000000"), data.ToString("dd/MM/yyyyHH:mm"), tipoCarga, filler);


					LeituraGravacao format = new LeituraGravacao();
					for (int i = 1; i < rowCount + 1; i++)
					{
						writer.Write("{0,2}", format.Truncate(xlRange.Cells[i, 1].Text, 2));
						writer.Write("{0,1}", format.Truncate(xlRange.Cells[i, 2].Text, 1));
						writer.Write("{0,6}", format.Truncate(xlRange.Cells[i, 3].Text, 6));
						writer.Write("{0,6}", format.Truncate(xlRange.Cells[i, 4].Text, 6));
						writer.Write("{0,-50}", format.Truncate(xlRange.Cells[i, 5].Text, 50));
						writer.Write("{0,-20}", format.Truncate(xlRange.Cells[i, 6].Text, 20));
						writer.Write("{0,2}", format.Truncate(xlRange.Cells[i, 7].Text.ToString("00"), 2));
						writer.Write("{0,10}", format.Truncate(xlRange.Cells[i, 8].Text, 10));
						writer.Write("{0,14}", format.Truncate(xlRange.Cells[i, 9].Text, 14));
						writer.Write("{0,1}", format.Truncate(xlRange.Cells[i, 10].Text, 1));
						writer.Write("{0,10}", format.Truncate(xlRange.Cells[i, 11].Text, 10));
						writer.Write("{0,10}", format.Truncate(xlRange.Cells[i, 12].Text, 10));
						writer.Write("{0,11}", format.Truncate(xlRange.Cells[i, 13].Text, 11));
						writer.Write("{0,11}", format.Truncate(xlRange.Cells[i, 14].Text, 11));
						writer.WriteLine("{0}", (i + 1).ToString("000000"));
					}

					tamanhoFiller = 146;
					writer.Write("99{0}{1," + tamanhoFiller + "}" + "{2}", (rowCount + 2).ToString("000000"),
						filler, (rowCount + 2).ToString("000000"));
				}

				xlWorkbook.Close();
			}
			public void Limite04(string source, string arquivoSalvar, int agregadorCliente, char tipoCarga)
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
					int tamanhoFiller = 120;
					string layout = "0310";

					writer.WriteLine("00{0}{1}000000{2}{3}{4," + tamanhoFiller + "}" + "000001", layout,
					agregadorCliente.ToString("000000"), data.ToString("dd/MM/yyyyHH:mm"), tipoCarga, filler);

					for (int i = 1; i < rowCount + 1; i++)
					{
						LeituraGravacao format = new LeituraGravacao();

						writer.Write("{0,2}", format.Truncate(xlRange.Cells[i, 1].Text, 2));
						writer.Write("{0,6}", format.Truncate(xlRange.Cells[i, 2].Text, 6));
						writer.Write("{0,6}", format.Truncate(xlRange.Cells[i, 3].Text, 6));
						writer.Write("{0,-20}", format.Truncate(xlRange.Cells[i, 4].Text, 20));
						writer.Write("{0,17}", format.Truncate(xlRange.Cells[i, 5].Text.ToString("00000000000000000"), 17));
						writer.Write("{0,10}", format.Truncate(xlRange.Cells[i, 6].Text, 10));
						writer.Write("{0,93}", format.Truncate(xlRange.Cells[i, 7].Text, 93));
						writer.WriteLine("{0}", (i + 1).ToString("000000"));

					}
					tamanhoFiller = 146;
					writer.Write("99{0}{1," + tamanhoFiller + "}" + "{2}", (rowCount + 2).ToString("000000"),
						filler, (rowCount + 2).ToString("000000"));
				}
				xlWorkbook.Close();
			}
			public void Demissao06(string source, string arquivoSalvar, int agregadorCliente, char tipoCarga)
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
					int tamanhoFiller = 120;
					string layout = "0310";

					writer.WriteLine("00{0}{1}000000{2}{3}{4," + tamanhoFiller + "}" + "000001", layout,
					agregadorCliente.ToString("000000"), data.ToString("dd/MM/yyyyHH:mm"), tipoCarga, filler);

					for (int i = 1; i < rowCount + 1; i++)
					{
						LeituraGravacao format = new LeituraGravacao();

						writer.Write("{0,2}", format.Truncate(xlRange.Cells[i, 1].Text, 2));
						writer.Write("{0,6}", format.Truncate(xlRange.Cells[i, 2].Text, 6));
						writer.Write("{0,6}", format.Truncate(xlRange.Cells[i, 3].Text, 6));
						writer.Write("{0,-20}", format.Truncate(xlRange.Cells[i, 4].Text, 20));
						writer.Write("{0,10}", format.Truncate(xlRange.Cells[i, 5].Text, 10));
						writer.Write("{0,110}", format.Truncate(xlRange.Cells[i, 6].Text, 110));
						writer.WriteLine("{0}", (i + 1).ToString("000000"));

					}
					tamanhoFiller = 146;
					writer.Write("99{0}{1," + tamanhoFiller + "}" + "{2}", (rowCount + 2).ToString("000000"),
						filler, (rowCount + 2).ToString("000000"));
				}
				xlWorkbook.Close();
			}
		}
	}
}

