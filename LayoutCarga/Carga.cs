using System;
using System.ComponentModel;
using System.Threading;
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

			agregadorLabel.Show();

		}

		public void ShowTypeRButtons()
		{
			tpCargaLabel.Show();
			controladaRB.Show();
			totalRB.Show();
		}

		public void ShowActionButtons()
		{
			if (layoutCB.Text == "Layout 100")
			{
				inclusao.Show();
				actionLabel.Show();
				limite.Hide();
				demissao.Hide();

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
			agregadorLabel.Hide();

			inclusao.Hide();
			limite.Hide();
			demissao.Hide();

			actionLabel.Hide();

			arquivo.Hide();
			arquivoLabel.Hide();

			procurarButton.Hide();
			converterButton.Hide();

			tpCargaLabel.Hide();
			controladaRB.Hide();
			totalRB.Hide();
		}

		//public void UncheckLayout()
		//{
		//	layout100.Checked = false;
		//	layout200.Checked = false;
		//	layout210.Checked = false;
		//	layout300.Checked = false;
		//	layout310.Checked = false;
		//}

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

			leitura.GravarArquivo(layout, Convert.ToInt32(agregadorTB.Text), acao,
				tipoCarga, arquivo.Text, SalvaLayout.FileName);

			MessageBox.Show("O arquivo foi salvo com sucesso!", "Processo concluído");
		}

		public int ColunasInclusao()
		{
			if (layoutCB.Text == "Layout 100")
			{
				colCount = 24;
			}
			else if (layoutCB.Text == "Layout 200")
			{
				colCount = 25;
			}
			else if (layoutCB.Text == "Layout 210")
			{
				colCount = 27;
			}
			else if (layoutCB.Text == "Layout 300")
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

			if (layoutCB.Text == "Layout 200")
			{
				colCount = 7;
			}
			else if (layoutCB.Text == "Layout 210")
			{
				colCount = 7;
			}
			else if (layoutCB.Text == "Layout 300")
			{
				colCount = 8;
			}
			else
			{
				colCount = 7;
			}

			return colCount;
		}

		private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (layoutCB.Text == "Layout 100")
			{
				if (tpCargaLabel.Visible)
				{
					ShowActionButtons();
				}
				else
				{
					ShowClientTB();
					layout = "0100";
					agregadorLabel.Text = "Cliente:";
				}
			}
			else if (layoutCB.Text == "Layout 200")
			{
				if (tpCargaLabel.Visible)
				{
					ShowActionButtons();
				}
				else
				{
					ShowClientTB();
					layout = "0200";
					agregadorLabel.Text = "Cliente:";
				}
			}
			else if (layoutCB.Text == "Layout 210")
			{
				if (tpCargaLabel.Visible)
				{
					ShowActionButtons();
				}
				else
				{
					ShowClientTB();
					layout = "0210";
					agregadorLabel.Text = "Cliente:";
				}
			}
			else if (layoutCB.Text == "Layout 300")
			{
				if (tpCargaLabel.Visible)
				{
					ShowActionButtons();
				}
				else
				{
					ShowClientTB();
					layout = "0300";
					agregadorLabel.Text = "Agregador:";
				}
			}
			else
			{
				if (tpCargaLabel.Visible)
				{
					ShowActionButtons();
				}
				else
				{
					ShowClientTB();
					layout = "0310";
					agregadorLabel.Text = "Agregador:";
				}
			}
		}

		private void agregadorTB_TextChanged(object sender, EventArgs e)
		{
			ShowTypeRButtons();
		}

		private void controladaRB_CheckedChanged(object sender, EventArgs e)
		{
			ShowActionButtons();
			tipoCarga = 'C';
		}

		private void totalRB_CheckedChanged(object sender, EventArgs e)
		{
			ShowActionButtons();
			tipoCarga = 'T';
		}

		private void progressBar1_Click(object sender, EventArgs e)
		{

		}

	}
}
