namespace LayoutCarga
{
	partial class Carga
	{
		/// <summary>
		/// Variável de designer necessária.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Limpar os recursos que estão sendo usados.
		/// </summary>
		/// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Código gerado pelo Windows Form Designer

		/// <summary>
		/// Método necessário para suporte ao Designer - não modifique 
		/// o conteúdo deste método com o editor de código.
		/// </summary>
		private void InitializeComponent()
		{
			this.layoutLabel = new System.Windows.Forms.Label();
			this.agregadorLabel = new System.Windows.Forms.Label();
			this.agregadorTB = new System.Windows.Forms.TextBox();
			this.limite = new System.Windows.Forms.RadioButton();
			this.demissao = new System.Windows.Forms.RadioButton();
			this.inclusao = new System.Windows.Forms.RadioButton();
			this.actionLabel = new System.Windows.Forms.Label();
			this.arquivoLabel = new System.Windows.Forms.Label();
			this.SelecionaArquivo = new System.Windows.Forms.OpenFileDialog();
			this.arquivo = new System.Windows.Forms.TextBox();
			this.procurarButton = new System.Windows.Forms.Button();
			this.converterButton = new System.Windows.Forms.Button();
			this.SalvaLayout = new System.Windows.Forms.SaveFileDialog();
			this.panel1 = new System.Windows.Forms.Panel();
			this.layoutCB = new System.Windows.Forms.ComboBox();
			this.tpCargaLabel = new System.Windows.Forms.Label();
			this.controladaRB = new System.Windows.Forms.RadioButton();
			this.totalRB = new System.Windows.Forms.RadioButton();
			this.panel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// layoutLabel
			// 
			this.layoutLabel.AutoSize = true;
			this.layoutLabel.Location = new System.Drawing.Point(26, 55);
			this.layoutLabel.Name = "layoutLabel";
			this.layoutLabel.Size = new System.Drawing.Size(97, 13);
			this.layoutLabel.TabIndex = 0;
			this.layoutLabel.Text = "Selecione o layout:";
			// 
			// agregadorLabel
			// 
			this.agregadorLabel.AutoSize = true;
			this.agregadorLabel.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.agregadorLabel.Location = new System.Drawing.Point(64, 101);
			this.agregadorLabel.Name = "agregadorLabel";
			this.agregadorLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.agregadorLabel.Size = new System.Drawing.Size(59, 13);
			this.agregadorLabel.TabIndex = 8;
			this.agregadorLabel.Text = "Agregador:";
			this.agregadorLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// agregadorTB
			// 
			this.agregadorTB.Location = new System.Drawing.Point(132, 98);
			this.agregadorTB.Name = "agregadorTB";
			this.agregadorTB.Size = new System.Drawing.Size(241, 20);
			this.agregadorTB.TabIndex = 11;
			this.agregadorTB.TextChanged += new System.EventHandler(this.agregadorTB_TextChanged);
			// 
			// limite
			// 
			this.limite.AutoSize = true;
			this.limite.Location = new System.Drawing.Point(219, 15);
			this.limite.Name = "limite";
			this.limite.Size = new System.Drawing.Size(52, 17);
			this.limite.TabIndex = 17;
			this.limite.TabStop = true;
			this.limite.Text = "Limite";
			this.limite.UseVisualStyleBackColor = true;
			this.limite.CheckedChanged += new System.EventHandler(this.limite_CheckedChanged);
			// 
			// demissao
			// 
			this.demissao.AutoSize = true;
			this.demissao.Location = new System.Drawing.Point(304, 15);
			this.demissao.Name = "demissao";
			this.demissao.Size = new System.Drawing.Size(71, 17);
			this.demissao.TabIndex = 16;
			this.demissao.TabStop = true;
			this.demissao.Text = "Demissão";
			this.demissao.UseVisualStyleBackColor = true;
			this.demissao.CheckedChanged += new System.EventHandler(this.demissao_CheckedChanged);
			// 
			// inclusao
			// 
			this.inclusao.AutoSize = true;
			this.inclusao.Location = new System.Drawing.Point(134, 15);
			this.inclusao.Name = "inclusao";
			this.inclusao.Size = new System.Drawing.Size(65, 17);
			this.inclusao.TabIndex = 15;
			this.inclusao.TabStop = true;
			this.inclusao.Text = "Inclusão";
			this.inclusao.UseVisualStyleBackColor = true;
			this.inclusao.CheckedChanged += new System.EventHandler(this.inclusao_CheckedChanged);
			// 
			// actionLabel
			// 
			this.actionLabel.AutoSize = true;
			this.actionLabel.Location = new System.Drawing.Point(29, 17);
			this.actionLabel.Name = "actionLabel";
			this.actionLabel.Size = new System.Drawing.Size(93, 13);
			this.actionLabel.TabIndex = 14;
			this.actionLabel.Text = "Selecione a ação:";
			// 
			// arquivoLabel
			// 
			this.arquivoLabel.AutoSize = true;
			this.arquivoLabel.Location = new System.Drawing.Point(26, 235);
			this.arquivoLabel.Name = "arquivoLabel";
			this.arquivoLabel.Size = new System.Drawing.Size(183, 13);
			this.arquivoLabel.TabIndex = 18;
			this.arquivoLabel.Text = "Selecione o arquivo a ser convertido:";
			// 
			// arquivo
			// 
			this.arquivo.Location = new System.Drawing.Point(26, 260);
			this.arquivo.Name = "arquivo";
			this.arquivo.Size = new System.Drawing.Size(408, 20);
			this.arquivo.TabIndex = 19;
			// 
			// procurarButton
			// 
			this.procurarButton.Location = new System.Drawing.Point(460, 255);
			this.procurarButton.Name = "procurarButton";
			this.procurarButton.Size = new System.Drawing.Size(102, 30);
			this.procurarButton.TabIndex = 20;
			this.procurarButton.Text = "Procurar";
			this.procurarButton.UseVisualStyleBackColor = true;
			this.procurarButton.Click += new System.EventHandler(this.procurarButton_Click);
			// 
			// converterButton
			// 
			this.converterButton.Location = new System.Drawing.Point(246, 311);
			this.converterButton.Name = "converterButton";
			this.converterButton.Size = new System.Drawing.Size(102, 30);
			this.converterButton.TabIndex = 21;
			this.converterButton.Text = "Converter";
			this.converterButton.UseVisualStyleBackColor = true;
			this.converterButton.Click += new System.EventHandler(this.converterButton_Click);
			// 
			// SalvaLayout
			// 
			this.SalvaLayout.Filter = "Arquivos de Texto (.txt)|*.txt";
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.inclusao);
			this.panel1.Controls.Add(this.limite);
			this.panel1.Controls.Add(this.demissao);
			this.panel1.Controls.Add(this.actionLabel);
			this.panel1.Location = new System.Drawing.Point(2, 176);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(461, 31);
			this.panel1.TabIndex = 22;
			// 
			// layoutCB
			// 
			this.layoutCB.FormattingEnabled = true;
			this.layoutCB.Items.AddRange(new object[] {
            "Layout 100",
            "Layout 200",
            "Layout 210",
            "Layout 300",
            "Layout 310"});
			this.layoutCB.Location = new System.Drawing.Point(132, 52);
			this.layoutCB.Name = "layoutCB";
			this.layoutCB.Size = new System.Drawing.Size(241, 21);
			this.layoutCB.TabIndex = 23;
			this.layoutCB.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
			// 
			// tpCargaLabel
			// 
			this.tpCargaLabel.AutoSize = true;
			this.tpCargaLabel.Location = new System.Drawing.Point(47, 144);
			this.tpCargaLabel.Name = "tpCargaLabel";
			this.tpCargaLabel.Size = new System.Drawing.Size(76, 13);
			this.tpCargaLabel.TabIndex = 24;
			this.tpCargaLabel.Text = "Tipo de carga:";
			// 
			// controladaRB
			// 
			this.controladaRB.AutoSize = true;
			this.controladaRB.Location = new System.Drawing.Point(136, 142);
			this.controladaRB.Name = "controladaRB";
			this.controladaRB.Size = new System.Drawing.Size(76, 17);
			this.controladaRB.TabIndex = 18;
			this.controladaRB.TabStop = true;
			this.controladaRB.Text = "Controlada";
			this.controladaRB.UseVisualStyleBackColor = true;
			this.controladaRB.CheckedChanged += new System.EventHandler(this.controladaRB_CheckedChanged);
			// 
			// totalRB
			// 
			this.totalRB.AutoSize = true;
			this.totalRB.Location = new System.Drawing.Point(221, 142);
			this.totalRB.Name = "totalRB";
			this.totalRB.Size = new System.Drawing.Size(49, 17);
			this.totalRB.TabIndex = 19;
			this.totalRB.TabStop = true;
			this.totalRB.Text = "Total";
			this.totalRB.UseVisualStyleBackColor = true;
			this.totalRB.CheckedChanged += new System.EventHandler(this.totalRB_CheckedChanged);
			// 
			// Carga
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(588, 369);
			this.Controls.Add(this.controladaRB);
			this.Controls.Add(this.tpCargaLabel);
			this.Controls.Add(this.totalRB);
			this.Controls.Add(this.layoutCB);
			this.Controls.Add(this.converterButton);
			this.Controls.Add(this.procurarButton);
			this.Controls.Add(this.arquivo);
			this.Controls.Add(this.arquivoLabel);
			this.Controls.Add(this.agregadorTB);
			this.Controls.Add(this.agregadorLabel);
			this.Controls.Add(this.layoutLabel);
			this.Controls.Add(this.panel1);
			this.MaximumSize = new System.Drawing.Size(604, 408);
			this.MinimumSize = new System.Drawing.Size(604, 408);
			this.Name = "Carga";
			this.Text = "Layout de Carga";
			this.Load += new System.EventHandler(this.Carga_Load);
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label layoutLabel;
		private System.Windows.Forms.Label agregadorLabel;
		private System.Windows.Forms.TextBox agregadorTB;
		private System.Windows.Forms.RadioButton limite;
		private System.Windows.Forms.RadioButton demissao;
		private System.Windows.Forms.RadioButton inclusao;
		private System.Windows.Forms.Label actionLabel;
		private System.Windows.Forms.Label arquivoLabel;
		private System.Windows.Forms.OpenFileDialog SelecionaArquivo;
		private System.Windows.Forms.TextBox arquivo;
		private System.Windows.Forms.Button procurarButton;
		private System.Windows.Forms.Button converterButton;
		private System.Windows.Forms.SaveFileDialog SalvaLayout;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.ComboBox layoutCB;
		private System.Windows.Forms.Label tpCargaLabel;
		private System.Windows.Forms.RadioButton controladaRB;
		private System.Windows.Forms.RadioButton totalRB;
	}
}

