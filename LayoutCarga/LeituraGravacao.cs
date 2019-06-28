using System;
using System.IO;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;



namespace LayoutCarga
{
	class LeituraGravacao
	{



		public void LerArquivo(string source, int colCount, string arquivoSalvar, string layout, 
			int agregadorCliente, string cliente, string beneficio, string acao, string tipoRegistro)
		{
			Excel.Application xlApp = new Excel.Application();
			Excel.Workbook xlWorkbook = xlApp.Workbooks.Open(source);
			Excel._Worksheet xlWorksheet = xlWorkbook.Sheets[1];
			Excel.Range xlRange = xlWorksheet.UsedRange;

			int rowCount = xlRange.Rows.Count;

			MessageBox.Show(rowCount + " " + colCount);

			string[,] conteudo = new string[rowCount, colCount];

			string cell = string.Empty;
			//try
			//{

			//	for (int i = 1; i < rowCount; i++)
			//	{
			//		for (int j = 1; j < colCount; j++)
			//		{
			//			conteudo[i-1,j] = xlRange.Cells[i, j].Text.ToString();
			//		}
			//	}

			//}
			//catch (Exception ex)
			//{
			//	MessageBox.Show(ex.Message);
			//}

			try
			{

				using (StreamWriter writer = new StreamWriter(arquivoSalvar))
				{
					DateTime data = DateTime.Now;
					string filler = " ";
					int tamanhoFiller = 310;
					acao = "01";
					tipoRegistro = "I";
					beneficio = "055441";


					writer.WriteLine("00{0}{1}000000{2}C{3," + tamanhoFiller + "}" + "000001", layout,
						agregadorCliente.ToString("000000"), data.ToString("dd/MM/yyyyHH:mm"), filler);

					for (int i = 1; i < rowCount + 1; i++)
					{

						writer.Write("{0,2}", xlRange.Cells[i, 1].Text);
						writer.Write("{0,1}", xlRange.Cells[i, 2].Text);
						writer.Write("{0,6}", xlRange.Cells[i, 3].Text);
						writer.Write("{0,-19}", xlRange.Cells[i, 4].Text);
						writer.Write("{0,-19}", xlRange.Cells[i, 5].Text);
						writer.Write("{0,-50}", xlRange.Cells[i, 6].Text);
						writer.Write("{0,-30}", xlRange.Cells[i, 7].Text);
						writer.Write("{0,10}", xlRange.Cells[i, 8].Text);
						writer.Write("{0,1}", xlRange.Cells[i, 9].Text);
						writer.Write("{0,15}", xlRange.Cells[i, 10].Text);
						writer.Write("{0,10}", xlRange.Cells[i, 11].Text);
						writer.Write("{0,11}", xlRange.Cells[i, 12].Text);
						writer.Write("{0,40}", xlRange.Cells[i, 13].Text);
						writer.Write("{0,5}", xlRange.Cells[i, 14].Text);
						writer.Write("{0,10}", xlRange.Cells[i, 15].Text);
						writer.Write("{0,20}", xlRange.Cells[i, 16].Text);
						writer.Write("{0,30}", xlRange.Cells[i, 17].Text);
						writer.Write("{0,2}", xlRange.Cells[i, 18].Text);
						writer.Write("{0,8}", xlRange.Cells[i, 19].Text);
						writer.Write("{0,10}", xlRange.Cells[i, 20].Text);
						writer.Write("{0,10}", xlRange.Cells[i, 21].Text);
						writer.Write("{0,1}", xlRange.Cells[i, 22].Text);
						writer.Write("{0,-20}", xlRange.Cells[i, 23].Text);
						writer.Write("{0,14}", xlRange.Cells[i, 24].Text);
						writer.WriteLine("{0}", (i+1).ToString("000000"));

					}
					tamanhoFiller = 336;
					writer.Write("99{0}{1," + tamanhoFiller + "}" + "{2}", (rowCount + 2).ToString("000000"),
						filler, (rowCount + 2).ToString("000000"));
				}


			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}
	}
}
