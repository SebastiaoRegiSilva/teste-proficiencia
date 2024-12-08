using System;
using System.Linq;
using System.Windows.Forms;

namespace testeproficiencia
{
	public partial class Form1 : Form
    {
		public Form1()
		{
			InitializeComponent();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			// Obter valores dos controles
			string nome = textBoxNomeAluno.Text;
			int aptFisica = (int)numericUpDown1.Value;
			int profEscrita = (int)numericUpDown2.Value;
			int profOral = (int)numericUpDown3.Value;
			string idioma = groupBox_profIdioma.Controls.OfType<RadioButton>()
								.FirstOrDefault(r => r.Checked)?.Text ?? "Nenhum";

			// Adicionar uma nova linha no DataGridView
			dataGridView1.Rows.Add(nome, aptFisica, profEscrita, profOral, idioma, "Sim/Não");
		}
	}
}
