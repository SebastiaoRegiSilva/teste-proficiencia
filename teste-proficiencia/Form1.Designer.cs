namespace testeproficiencia
{
	partial class Form1
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
			this.labelAptFis = new System.Windows.Forms.Label();
			this.labelProfEsc = new System.Windows.Forms.Label();
			this.Button1 = new System.Windows.Forms.Button();
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.nomeAluno = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.AptFis = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.ProfEsc = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.ProfOra = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Idiomas = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Aprovado = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
			this.numericUpDown2 = new System.Windows.Forms.NumericUpDown();
			this.labelProfOra = new System.Windows.Forms.Label();
			this.numericUpDown3 = new System.Windows.Forms.NumericUpDown();
			this.groupBoxProf = new System.Windows.Forms.GroupBox();
			this.groupBoxIdiomas = new System.Windows.Forms.GroupBox();
			this.textBoxNomeAluno = new System.Windows.Forms.TextBox();
			this.labelNomeAluno = new System.Windows.Forms.Label();
			this.Button2 = new System.Windows.Forms.Button();
			this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
			this.groupBox_profIdioma = new System.Windows.Forms.GroupBox();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDown3)).BeginInit();
			this.groupBoxProf.SuspendLayout();
			this.groupBoxIdiomas.SuspendLayout();
			this.groupBox_profIdioma.SuspendLayout();
			this.SuspendLayout();
			// 
			// labelAptFis
			// 
			this.labelAptFis.AutoSize = true;
			this.labelAptFis.Location = new System.Drawing.Point(6, 31);
			this.labelAptFis.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.labelAptFis.Name = "labelAptFis";
			this.labelAptFis.Size = new System.Drawing.Size(82, 16);
			this.labelAptFis.TabIndex = 0;
			this.labelAptFis.Text = "Aptidão Física";
			// 
			// labelProfEsc
			// 
			this.labelProfEsc.AutoSize = true;
			this.labelProfEsc.Location = new System.Drawing.Point(6, 62);
			this.labelProfEsc.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.labelProfEsc.Name = "labelProfEsc";
			this.labelProfEsc.Size = new System.Drawing.Size(111, 16);
			this.labelProfEsc.TabIndex = 2;
			this.labelProfEsc.Text = "Proficiência Escrita";
			// 
			// Button1
			// 
			this.Button1.BackColor = System.Drawing.Color.MediumSeaGreen;
			this.Button1.Location = new System.Drawing.Point(302, 387);
			this.Button1.Margin = new System.Windows.Forms.Padding(2);
			this.Button1.Name = "Button1";
			this.Button1.Size = new System.Drawing.Size(58, 38);
			this.Button1.TabIndex = 8;
			this.Button1.Text = "Inserir";
			this.Button1.UseVisualStyleBackColor = false;
			this.Button1.Click += new System.EventHandler(this.Button1_Click);
			// 
			// dataGridView1
			// 
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nomeAluno,
            this.AptFis,
            this.ProfEsc,
            this.ProfOra,
            this.Idiomas,
            this.Aprovado});
			this.dataGridView1.Location = new System.Drawing.Point(302, 12);
			this.dataGridView1.Margin = new System.Windows.Forms.Padding(2);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.RowHeadersWidth = 62;
			this.dataGridView1.RowTemplate.Height = 28;
			this.dataGridView1.Size = new System.Drawing.Size(886, 199);
			this.dataGridView1.TabIndex = 8;
			// 
			// nomeAluno
			// 
			this.nomeAluno.Frozen = true;
			this.nomeAluno.HeaderText = "Nome";
			this.nomeAluno.Name = "nomeAluno";
			this.nomeAluno.ReadOnly = true;
			// 
			// AptFis
			// 
			this.AptFis.Frozen = true;
			this.AptFis.HeaderText = "Aptidão Física";
			this.AptFis.MinimumWidth = 8;
			this.AptFis.Name = "AptFis";
			this.AptFis.Width = 150;
			// 
			// ProfEsc
			// 
			this.ProfEsc.HeaderText = "Proficiência Escrita";
			this.ProfEsc.MinimumWidth = 8;
			this.ProfEsc.Name = "ProfEsc";
			this.ProfEsc.Width = 150;
			// 
			// ProfOra
			// 
			this.ProfOra.HeaderText = "Proficiência Oral";
			this.ProfOra.MinimumWidth = 8;
			this.ProfOra.Name = "ProfOra";
			this.ProfOra.Width = 150;
			// 
			// Idiomas
			// 
			this.Idiomas.HeaderText = "Idiomas";
			this.Idiomas.MinimumWidth = 8;
			this.Idiomas.Name = "Idiomas";
			this.Idiomas.Width = 150;
			// 
			// Aprovado
			// 
			this.Aprovado.HeaderText = "Aprovado";
			this.Aprovado.MinimumWidth = 8;
			this.Aprovado.Name = "Aprovado";
			this.Aprovado.Width = 150;
			// 
			// numericUpDown1
			// 
			this.numericUpDown1.Location = new System.Drawing.Point(127, 22);
			this.numericUpDown1.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
			this.numericUpDown1.Name = "numericUpDown1";
			this.numericUpDown1.Size = new System.Drawing.Size(63, 23);
			this.numericUpDown1.TabIndex = 2;
			// 
			// numericUpDown2
			// 
			this.numericUpDown2.Location = new System.Drawing.Point(127, 55);
			this.numericUpDown2.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
			this.numericUpDown2.Name = "numericUpDown2";
			this.numericUpDown2.Size = new System.Drawing.Size(63, 23);
			this.numericUpDown2.TabIndex = 3;
			// 
			// labelProfOra
			// 
			this.labelProfOra.AutoSize = true;
			this.labelProfOra.Location = new System.Drawing.Point(6, 91);
			this.labelProfOra.Name = "labelProfOra";
			this.labelProfOra.Size = new System.Drawing.Size(97, 16);
			this.labelProfOra.TabIndex = 11;
			this.labelProfOra.Text = "Proficiência Oral";
			// 
			// numericUpDown3
			// 
			this.numericUpDown3.Location = new System.Drawing.Point(127, 84);
			this.numericUpDown3.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
			this.numericUpDown3.Name = "numericUpDown3";
			this.numericUpDown3.Size = new System.Drawing.Size(63, 23);
			this.numericUpDown3.TabIndex = 4;
			// 
			// groupBoxProf
			// 
			this.groupBoxProf.Controls.Add(this.numericUpDown3);
			this.groupBoxProf.Controls.Add(this.labelProfOra);
			this.groupBoxProf.Controls.Add(this.numericUpDown2);
			this.groupBoxProf.Controls.Add(this.numericUpDown1);
			this.groupBoxProf.Controls.Add(this.labelProfEsc);
			this.groupBoxProf.Controls.Add(this.labelAptFis);
			this.groupBoxProf.Location = new System.Drawing.Point(41, 84);
			this.groupBoxProf.Name = "groupBoxProf";
			this.groupBoxProf.Size = new System.Drawing.Size(227, 127);
			this.groupBoxProf.TabIndex = 13;
			this.groupBoxProf.TabStop = false;
			this.groupBoxProf.Text = "Númericas";
			// 
			// groupBoxIdiomas
			// 
			this.groupBoxIdiomas.Controls.Add(this.groupBox_profIdioma);
			this.groupBoxIdiomas.Location = new System.Drawing.Point(41, 247);
			this.groupBoxIdiomas.Name = "groupBoxIdiomas";
			this.groupBoxIdiomas.Size = new System.Drawing.Size(227, 178);
			this.groupBoxIdiomas.TabIndex = 5;
			this.groupBoxIdiomas.TabStop = false;
			this.groupBoxIdiomas.Text = "Idiomas";
			// 
			// textBoxNomeAluno
			// 
			this.textBoxNomeAluno.Location = new System.Drawing.Point(144, 39);
			this.textBoxNomeAluno.Name = "textBoxNomeAluno";
			this.textBoxNomeAluno.Size = new System.Drawing.Size(124, 23);
			this.textBoxNomeAluno.TabIndex = 1;
			// 
			// labelNomeAluno
			// 
			this.labelNomeAluno.AutoSize = true;
			this.labelNomeAluno.Location = new System.Drawing.Point(47, 42);
			this.labelNomeAluno.Name = "labelNomeAluno";
			this.labelNomeAluno.Size = new System.Drawing.Size(91, 16);
			this.labelNomeAluno.TabIndex = 0;
			this.labelNomeAluno.Text = "Nome do aluno:";
			// 
			// Button2
			// 
			this.Button2.BackColor = System.Drawing.Color.IndianRed;
			this.Button2.Location = new System.Drawing.Point(364, 387);
			this.Button2.Margin = new System.Windows.Forms.Padding(2);
			this.Button2.Name = "Button2";
			this.Button2.Size = new System.Drawing.Size(58, 38);
			this.Button2.TabIndex = 9;
			this.Button2.Text = "Limpar";
			this.Button2.UseVisualStyleBackColor = false;
			this.Button2.Click += new System.EventHandler(this.Button2_Click);
			// 
			// checkedListBox1
			// 
			this.checkedListBox1.FormattingEnabled = true;
			this.checkedListBox1.Items.AddRange(new object[] {
            "Alemão",
            "Espanhol",
            "Grego",
            "Hebraico",
            "Inglês",
            "Português"});
			this.checkedListBox1.Location = new System.Drawing.Point(5, 21);
			this.checkedListBox1.Name = "checkedListBox1";
			this.checkedListBox1.Size = new System.Drawing.Size(120, 112);
			this.checkedListBox1.TabIndex = 7;
			// 
			// groupBox_profIdioma
			// 
			this.groupBox_profIdioma.Controls.Add(this.checkedListBox1);
			this.groupBox_profIdioma.Location = new System.Drawing.Point(9, 21);
			this.groupBox_profIdioma.Margin = new System.Windows.Forms.Padding(2);
			this.groupBox_profIdioma.Name = "groupBox_profIdioma";
			this.groupBox_profIdioma.Padding = new System.Windows.Forms.Padding(2);
			this.groupBox_profIdioma.Size = new System.Drawing.Size(155, 147);
			this.groupBox_profIdioma.TabIndex = 6;
			this.groupBox_profIdioma.TabStop = false;
			this.groupBox_profIdioma.Text = "Proficiente";
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.ButtonFace;
			this.ClientSize = new System.Drawing.Size(1213, 486);
			this.Controls.Add(this.textBoxNomeAluno);
			this.Controls.Add(this.Button2);
			this.Controls.Add(this.labelNomeAluno);
			this.Controls.Add(this.groupBoxIdiomas);
			this.Controls.Add(this.groupBoxProf);
			this.Controls.Add(this.dataGridView1);
			this.Controls.Add(this.Button1);
			this.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Margin = new System.Windows.Forms.Padding(2);
			this.Name = "Form1";
			this.Text = "Página Principal - Teste Proficência";
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDown3)).EndInit();
			this.groupBoxProf.ResumeLayout(false);
			this.groupBoxProf.PerformLayout();
			this.groupBoxIdiomas.ResumeLayout(false);
			this.groupBox_profIdioma.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label labelAptFis;
		private System.Windows.Forms.Label labelProfEsc;
		private System.Windows.Forms.Button Button1;
		private System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.NumericUpDown numericUpDown1;
		private System.Windows.Forms.NumericUpDown numericUpDown2;
		private System.Windows.Forms.Label labelProfOra;
		private System.Windows.Forms.NumericUpDown numericUpDown3;
		private System.Windows.Forms.GroupBox groupBoxProf;
		private System.Windows.Forms.GroupBox groupBoxIdiomas;
		private System.Windows.Forms.TextBox textBoxNomeAluno;
		private System.Windows.Forms.Label labelNomeAluno;
		private System.Windows.Forms.DataGridViewTextBoxColumn nomeAluno;
		private System.Windows.Forms.DataGridViewTextBoxColumn AptFis;
		private System.Windows.Forms.DataGridViewTextBoxColumn ProfEsc;
		private System.Windows.Forms.DataGridViewTextBoxColumn ProfOra;
		private System.Windows.Forms.DataGridViewTextBoxColumn Idiomas;
		private System.Windows.Forms.DataGridViewTextBoxColumn Aprovado;
		private System.Windows.Forms.GroupBox groupBox_profIdioma;
		private System.Windows.Forms.CheckedListBox checkedListBox1;
		private System.Windows.Forms.Button Button2;
	}
}

