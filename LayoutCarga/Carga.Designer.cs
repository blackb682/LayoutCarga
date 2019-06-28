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
			this.layout100 = new System.Windows.Forms.RadioButton();
			this.layout310 = new System.Windows.Forms.RadioButton();
			this.layout300 = new System.Windows.Forms.RadioButton();
			this.layout210 = new System.Windows.Forms.RadioButton();
			this.layout200 = new System.Windows.Forms.RadioButton();
			this.agregadorLabel = new System.Windows.Forms.Label();
			this.clienteLabel = new System.Windows.Forms.Label();
			this.beneficioLabel = new System.Windows.Forms.Label();
			this.agregadorTB = new System.Windows.Forms.TextBox();
			this.clienteTB = new System.Windows.Forms.TextBox();
			this.beneficioTB = new System.Windows.Forms.TextBox();
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
			// layout100
			// 
			this.layout100.AutoSize = true;
			this.layout100.Location = new System.Drawing.Point(130, 53);
			this.layout100.Name = "layout100";
			this.layout100.Size = new System.Drawing.Size(78, 17);
			this.layout100.TabIndex = 1;
			this.layout100.Text = "Layout 100";
			this.layout100.UseVisualStyleBackColor = true;
			this.layout100.CheckedChanged += new System.EventHandler(this.layout100_CheckedChanged);
			// 
			// layout310
			// 
			this.layout310.AutoSize = true;
			this.layout310.Location = new System.Drawing.Point(470, 53);
			this.layout310.Name = "layout310";
			this.layout310.Size = new System.Drawing.Size(78, 17);
			this.layout310.TabIndex = 4;
			this.layout310.Text = "Layout 310";
			this.layout310.UseVisualStyleBackColor = true;
			this.layout310.CheckedChanged += new System.EventHandler(this.layout310_CheckedChanged);
			// 
			// layout300
			// 
			this.layout300.AutoSize = true;
			this.layout300.Location = new System.Drawing.Point(385, 53);
			this.layout300.Name = "layout300";
			this.layout300.Size = new System.Drawing.Size(78, 17);
			this.layout300.TabIndex = 5;
			this.layout300.Text = "Layout 300";
			this.layout300.UseVisualStyleBackColor = true;
			this.layout300.CheckedChanged += new System.EventHandler(this.layout300_CheckedChanged);
			// 
			// layout210
			// 
			this.layout210.AutoSize = true;
			this.layout210.Location = new System.Drawing.Point(300, 53);
			this.layout210.Name = "layout210";
			this.layout210.Size = new System.Drawing.Size(78, 17);
			this.layout210.TabIndex = 6;
			this.layout210.Text = "Layout 210";
			this.layout210.UseVisualStyleBackColor = true;
			this.layout210.CheckedChanged += new System.EventHandler(this.layout210_CheckedChanged);
			// 
			// layout200
			// 
			this.layout200.AutoSize = true;
			this.layout200.Location = new System.Drawing.Point(215, 53);
			this.layout200.Name = "layout200";
			this.layout200.Size = new System.Drawing.Size(78, 17);
			this.layout200.TabIndex = 7;
			this.layout200.Text = "Layout 200";
			this.layout200.UseVisualStyleBackColor = true;
			this.layout200.CheckedChanged += new System.EventHandler(this.layout200_CheckedChanged);
			// 
			// agregadorLabel
			// 
			this.agregadorLabel.AutoSize = true;
			this.agregadorLabel.Location = new System.Drawing.Point(26, 98);
			this.agregadorLabel.Name = "agregadorLabel";
			this.agregadorLabel.Size = new System.Drawing.Size(59, 13);
			this.agregadorLabel.TabIndex = 8;
			this.agregadorLabel.Text = "Agregador:";
			// 
			// clienteLabel
			// 
			this.clienteLabel.AutoSize = true;
			this.clienteLabel.Location = new System.Drawing.Point(212, 98);
			this.clienteLabel.Name = "clienteLabel";
			this.clienteLabel.Size = new System.Drawing.Size(42, 13);
			this.clienteLabel.TabIndex = 9;
			this.clienteLabel.Text = "Cliente:";
			// 
			// beneficioLabel
			// 
			this.beneficioLabel.AutoSize = true;
			this.beneficioLabel.Location = new System.Drawing.Point(404, 98);
			this.beneficioLabel.Name = "beneficioLabel";
			this.beneficioLabel.Size = new System.Drawing.Size(56, 13);
			this.beneficioLabel.TabIndex = 10;
			this.beneficioLabel.Text = "Benefício:";
			// 
			// agregadorTB
			// 
			this.agregadorTB.Location = new System.Drawing.Point(26, 122);
			this.agregadorTB.Name = "agregadorTB";
			this.agregadorTB.Size = new System.Drawing.Size(158, 20);
			this.agregadorTB.TabIndex = 11;
			// 
			// clienteTB
			// 
			this.clienteTB.Location = new System.Drawing.Point(215, 122);
			this.clienteTB.Name = "clienteTB";
			this.clienteTB.Size = new System.Drawing.Size(158, 20);
			this.clienteTB.TabIndex = 12;
			// 
			// beneficioTB
			// 
			this.beneficioTB.Location = new System.Drawing.Point(404, 122);
			this.beneficioTB.Name = "beneficioTB";
			this.beneficioTB.Size = new System.Drawing.Size(158, 20);
			this.beneficioTB.TabIndex = 13;
			this.beneficioTB.TextChanged += new System.EventHandler(this.beneficioTB_TextChanged);
			// 
			// limite
			// 
			this.limite.AutoSize = true;
			this.limite.Location = new System.Drawing.Point(216, 8);
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
			this.demissao.Location = new System.Drawing.Point(301, 8);
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
			this.inclusao.Location = new System.Drawing.Point(131, 8);
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
			this.actionLabel.Location = new System.Drawing.Point(26, 10);
			this.actionLabel.Name = "actionLabel";
			this.actionLabel.Size = new System.Drawing.Size(93, 13);
			this.actionLabel.TabIndex = 14;
			this.actionLabel.Text = "Selecione a ação:";
			// 
			// arquivoLabel
			// 
			this.arquivoLabel.AutoSize = true;
			this.arquivoLabel.Location = new System.Drawing.Point(26, 216);
			this.arquivoLabel.Name = "arquivoLabel";
			this.arquivoLabel.Size = new System.Drawing.Size(183, 13);
			this.arquivoLabel.TabIndex = 18;
			this.arquivoLabel.Text = "Selecione o arquivo a ser convertido:";
			// 
			// arquivo
			// 
			this.arquivo.Location = new System.Drawing.Point(26, 241);
			this.arquivo.Name = "arquivo";
			this.arquivo.Size = new System.Drawing.Size(408, 20);
			this.arquivo.TabIndex = 19;
			// 
			// procurarButton
			// 
			this.procurarButton.Location = new System.Drawing.Point(460, 236);
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
			// panel1
			// 
			this.panel1.Controls.Add(this.inclusao);
			this.panel1.Controls.Add(this.limite);
			this.panel1.Controls.Add(this.demissao);
			this.panel1.Controls.Add(this.actionLabel);
			this.panel1.Location = new System.Drawing.Point(-1, 169);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(461, 31);
			this.panel1.TabIndex = 22;
			// 
			// Carga
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(588, 369);
			this.Controls.Add(this.converterButton);
			this.Controls.Add(this.procurarButton);
			this.Controls.Add(this.arquivo);
			this.Controls.Add(this.arquivoLabel);
			this.Controls.Add(this.beneficioTB);
			this.Controls.Add(this.clienteTB);
			this.Controls.Add(this.agregadorTB);
			this.Controls.Add(this.beneficioLabel);
			this.Controls.Add(this.clienteLabel);
			this.Controls.Add(this.agregadorLabel);
			this.Controls.Add(this.layout200);
			this.Controls.Add(this.layout210);
			this.Controls.Add(this.layout300);
			this.Controls.Add(this.layout310);
			this.Controls.Add(this.layout100);
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
		private System.Windows.Forms.RadioButton layout100;
		private System.Windows.Forms.RadioButton layout310;
		private System.Windows.Forms.RadioButton layout300;
		private System.Windows.Forms.RadioButton layout210;
		private System.Windows.Forms.RadioButton layout200;
		private System.Windows.Forms.Label agregadorLabel;
		private System.Windows.Forms.Label clienteLabel;
		private System.Windows.Forms.Label beneficioLabel;
		private System.Windows.Forms.TextBox agregadorTB;
		private System.Windows.Forms.TextBox clienteTB;
		private System.Windows.Forms.TextBox beneficioTB;
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
	}
}

