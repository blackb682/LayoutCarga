using System.IO;
using System.Windows.Forms;

namespace LayoutCarga
{
	class ValidacaoArquivo
	{
		public static void ValidaArquivo(string arquivo, string layout)
		{
			string line;
			string[] input;
			int counter = 0;
			using (StreamReader reader = new StreamReader(arquivo))
			{
				while ((line = reader.ReadLine()) != null)
				{
					input = line.Split(';');
					string[,] arquivoFinal = new string[counter, input.Length];
					string acao = input[0];
					int tamanhoLayout = 0;

					if (acao == "01" || acao == "02" || acao == "03" || acao == "04" || acao == "05" ||
						acao == "06" || acao == "07" || acao == "08" || acao == "09" || acao == "10")
					{
						tamanhoLayout = TamanhoLayout(layout, acao);

						if (input.Length == tamanhoLayout)
						{
							for (int i = 0; i < input.Length; i++)
							{


								arquivoFinal[counter, i] = input[i];
							}
							counter++;
						}
						else
						{

						}
					}
					else
					{
						MessageBox.Show("O valor do campo \"Ação\" na linha " + (counter + 1).ToString() + "não é válido.", "Erro =(",
								MessageBoxButtons.OK);
					}
				}
			}
		}

		public static int TamanhoLayout(string layout, string acao)
		{
			int layoutLength;

			switch (layout)
			{
				case "0100": return layoutLength = 24;
				case "0200":
					switch (acao)
					{
						case "01": return layoutLength = 25;
						case "04": return layoutLength = 8;
						case "05": return layoutLength = 7;
						case "06": return layoutLength = 7;
						case "07": return layoutLength = 6;
						case "08": return layoutLength = 6;
						case "09": return layoutLength = 6;
						case "10": return layoutLength = 7;
						default: return layoutLength = 0;
					}
				case "0210":
					switch (acao)
					{
						case "01": return layoutLength = 27;
						case "04": return layoutLength = 8;
						case "05": return layoutLength = 8;
						case "06": return layoutLength = 7;
						case "09": return layoutLength = 6;
						case "10": return layoutLength = 7;
						default: return layoutLength = 0;
					}
				case "0220":
					switch (acao)
					{
						case "01": return layoutLength = 22;
						case "04": return layoutLength = 8;
						case "05": return layoutLength = 7;
						case "06": return layoutLength = 7;
						case "09": return layoutLength = 6;
						case "10": return layoutLength = 7;
						default: return layoutLength = 0;
					}
				case "0300":
					switch (acao)
					{
						case "01": return layoutLength = 28;
						case "04": return layoutLength = 8;
						case "05": return layoutLength = 9;
						case "06": return layoutLength = 8;
						case "07": return layoutLength = 8;
						case "08": return layoutLength = 7;
						case "09": return layoutLength = 12;
						case "10": return layoutLength = 7;
						default: return layoutLength = 0;
					}
				case "0302":
					switch (acao)
					{
						case "01": return layoutLength = 28;
						case "03": return layoutLength = 8;
						case "04": return layoutLength = 8;
						case "05": return layoutLength = 9;
						case "06": return layoutLength = 8;
						case "07": return layoutLength = 8;
						case "08": return layoutLength = 7;
						case "09": return layoutLength = 12;
						case "10": return layoutLength = 8;
						default: return layoutLength = 0;
					}
				case "0310":
					switch (acao)
					{
						case "01": return layoutLength = 15;
						case "02": return layoutLength = 13;
						case "04": return layoutLength = 8;
						case "05": return layoutLength = 8;
						case "06": return layoutLength = 7;
						case "07": return layoutLength = 8;
						case "08": return layoutLength = 8;
						case "09": return layoutLength = 8;
						case "10": return layoutLength = 7;
						default: return layoutLength = 0;
					}
				case "0320":
					switch (acao)
					{
						case "01": return layoutLength = 17;
						case "02": return layoutLength = 14;
						case "04": return layoutLength = 10;
						case "05": return layoutLength = 9;
						case "06": return layoutLength = 8;
						case "07": return layoutLength = 9;
						case "08": return layoutLength = 9;
						case "09": return layoutLength = 10;
						case "10": return layoutLength = 7;
						default: return layoutLength = 0;
					}
				default: return layoutLength = 0;
			}
		}

		public static string[] ValidaDados(string[] input, string layout, string acao)
		{
			string[] inconsistencias = input;

			switch (layout)
			{
				case "0100":
					break;
				case "0200":
					switch (acao)
					{
						case "01":

							break;
						case "04":
							break;
						case "05":
							break;
						case "06":
							break;
						case "09":
							break;
						case "10":
							break;
						default:
							break;
					}
					break;
				case "0210":
					switch (acao)
					{
						case "01": return layoutLength = 27;
						case "04": return layoutLength = 8;
						case "05": return layoutLength = 8;
						case "06": return layoutLength = 7;
						case "09": return layoutLength = 6;
						case "10": return layoutLength = 7;
						default: return layoutLength = 0;
					}
				case "0220":
					switch (acao)
					{
						case "01": return layoutLength = 22;
						case "04": return layoutLength = 8;
						case "05": return layoutLength = 7;
						case "06": return layoutLength = 7;
						case "09": return layoutLength = 6;
						case "10": return layoutLength = 7;
						default: return layoutLength = 0;
					}
				case "0300":
					switch (acao)
					{
						case "01": return layoutLength = 28;
						case "04": return layoutLength = 8;
						case "05": return layoutLength = 9;
						case "06": return layoutLength = 8;
						case "07": return layoutLength = 8;
						case "08": return layoutLength = 7;
						case "09": return layoutLength = 12;
						case "10": return layoutLength = 7;
						default: return layoutLength = 0;
					}
				case "0302":
					switch (acao)
					{
						case "01": return layoutLength = 28;
						case "03": return layoutLength = 8;
						case "04": return layoutLength = 8;
						case "05": return layoutLength = 9;
						case "06": return layoutLength = 8;
						case "07": return layoutLength = 8;
						case "08": return layoutLength = 7;
						case "09": return layoutLength = 12;
						case "10": return layoutLength = 8;
						default: return layoutLength = 0;
					}
				case "0310":
					switch (acao)
					{
						case "01": return layoutLength = 15;
						case "02": return layoutLength = 13;
						case "04": return layoutLength = 8;
						case "05": return layoutLength = 8;
						case "06": return layoutLength = 7;
						case "07": return layoutLength = 8;
						case "08": return layoutLength = 8;
						case "09": return layoutLength = 8;
						case "10": return layoutLength = 7;
						default: return layoutLength = 0;
					}
				case "0320":
					switch (acao)
					{
						case "01": return layoutLength = 17;
						case "02": return layoutLength = 14;
						case "04": return layoutLength = 10;
						case "05": return layoutLength = 9;
						case "06": return layoutLength = 8;
						case "07": return layoutLength = 9;
						case "08": return layoutLength = 9;
						case "09": return layoutLength = 10;
						case "10": return layoutLength = 7;
						default: return layoutLength = 0;
					}
				default: return layoutLength = 0;
			}

			return inconsistencias;
		}
	}
}

