using System;
using System.Windows.Forms;

namespace LayoutCarga
{
	public partial class Carga : Form
	{
		int colCount;
		string layout;
		string acao;
		char tipoCarga;
		public Carga()
		{
			InitializeComponent();
		}

		private void Carga_Load(object sender, EventArgs e)
		{
			HideComponents();
		}

		//Botões de Layout

		private void layout100_CheckedChanged(object sender, EventArgs e)
		{
			ShowClientTB();
			agregadorTB.ReadOnly = true;
			layout = "0100";
		}

		private void layout200_CheckedChanged(object sender, EventArgs e)
		{
			ShowClientTB();
			agregadorTB.ReadOnly = true;
			layout = "0200";
		}

		private void layout210_CheckedChanged(object sender, EventArgs e)
		{
			ShowClientTB();
			agregadorTB.ReadOnly = true;
			layout = "0210";
		}

		private void layout300_CheckedChanged(object sender, EventArgs e)
		{
			ShowClientTB();
			agregadorTB.ReadOnly = false;
			layout = "0300";
		}
		private void layout310_CheckedChanged(object sender, EventArgs e)
		{
			ShowClientTB();
			agregadorTB.ReadOnly = false;
			layout = "0310";
		}

		//Campos de texto com os dados de agregador, cliente e benefício

		private void beneficioTB_TextChanged(object sender, EventArgs e)
		{
			if ((agregadorTB.Text != "" && clienteTB.Text != "") ||
				(agregadorTB.ReadOnly = true && clienteTB.Text != ""))
			{
				ShowActionButtons();
			}
		}

		//Botões de ação

		private void inclusao_CheckedChanged(object sender, EventArgs e)
		{
			ShowFileSearch();
			acao = "01";
			ColunasInclusao();
		}

		private void limite_CheckedChanged(object sender, EventArgs e)
		{
			ShowFileSearch();
			acao = "04";
			colCount = 8; //Todos os layouts para limite tem 8 colunas
		}

		private void demissao_CheckedChanged(object sender, EventArgs e)
		{
			ShowFileSearch();
			acao = "06";
			ColunasDemissao();
		}

		public void ShowClientTB()
		{
			agregadorTB.Show();
			clienteTB.Show();
			beneficioTB.Show();

			agregadorLabel.Show();
			clienteLabel.Show();
			beneficioLabel.Show();
		}
		public void ShowActionButtons()
		{
			if (layout100.Checked)
			{
				inclusao.Show();
				actionLabel.Show();

				inclusao.Checked = true;
			}
			else
			{
				inclusao.Show();
				limite.Show();
				demissao.Show();

				actionLabel.Show();
			}
		}

		public void ShowFileSearch()
		{
			arquivo.Show();
			arquivoLabel.Show();

			procurarButton.Show();
			converterButton.Show();
		}

		public void HideComponents()
		{
			agregadorTB.Hide();
			clienteTB.Hide();
			beneficioTB.Hide();

			agregadorLabel.Hide();
			clienteLabel.Hide();
			beneficioLabel.Hide();

			inclusao.Hide();
			limite.Hide();
			demissao.Hide();

			actionLabel.Hide();

			arquivo.Hide();
			arquivoLabel.Hide();

			procurarButton.Hide();
			converterButton.Hide();
		}

		public void UncheckLayout()
		{
			layout100.Checked = false;
			layout200.Checked = false;
			layout210.Checked = false;
			layout300.Checked = false;
			layout310.Checked = false;
		}

		public void UncheckAction()
		{
			inclusao.Checked = false;
			limite.Checked = false;
			demissao.Checked = false;
		}

		private void groupBox1_Enter(object sender, EventArgs e)
		{

		}

		private void procurarButton_Click(object sender, EventArgs e)
		{
			SelecionaArquivo.ShowDialog();

			arquivo.Text = SelecionaArquivo.FileName;
		}

		private void converterButton_Click(object sender, EventArgs e)
		{

			LeituraGravacao leitura = new LeituraGravacao();
			SalvaLayout.ShowDialog();

			leitura.GravarArquivo(layout, Convert.ToInt32(agregadorTB.Text), acao, tipoCarga, arquivo.Text, SalvaLayout.FileName);


		}

		public int ColunasInclusao()
		{
			if (layout100.Checked)
			{
				colCount = 24;
			}
			else if (layout200.Checked)
			{
				colCount = 25;
			}
			else if (layout210.Checked)
			{
				colCount = 27;
			}
			else if (layout300.Checked)
			{
				colCount = 28;
			}
			else
			{
				colCount = 15;
			}

			return colCount;
		}


		public int ColunasDemissao()
		{

			if (layout200.Checked)
			{
				colCount = 7;
			}
			else if (layout210.Checked)
			{
				colCount = 7;
			}
			else if (layout300.Checked)
			{
				colCount = 8;
			}
			else
			{
				colCount = 7;
			}

			return colCount;
		}
	}
}
