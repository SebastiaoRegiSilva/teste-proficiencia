using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace testeproficiencia
{
	public partial class Form1 : Form
    {
		public Form1()
		{
			InitializeComponent();
			LimparDadosInseridos();
			textBoxNomeAluno.Focus();
		}

		private void Button1_Click(object sender, EventArgs e)
		{
			if (textBoxNomeAluno.Text != "")
			{
				// Obter valores dos controles
				string nome = textBoxNomeAluno.Text;
				int aptFisica = (int)numericUpDown1.Value;
				int profEscrita = (int)numericUpDown2.Value;
				int profOral = (int)numericUpDown3.Value;
				// string idioma = comboBoxIdioma.Text; 

				// Adicionar uma nova linha no DataGridView.
				dataGridView1.Rows.Add(nome, aptFisica, profEscrita, profOral, /*idioma,*/ VericarAptidao(aptFisica, profEscrita, profOral));

				LimparDadosInseridos();
			}
			else
				MessageBox.Show("Preencha os dados, por favor!");
		}

		#region Verificações
		/// <summary>
		/// Verificará a média das três matérias, junto com o resultado da proficiência dos idiomas. 
		/// </summary>
		/// <param name="aptFis">Valor da aptidão física.</param>
		/// <param name="profEsc">Valor da proficiência escrita.</param>
		/// <param name="profOral">Valor da proficiência oral.</param>
		/// <returns>Aprovação ou Reprovação do estudante.</returns>
		private string VericarAptidao(int aptFis, int profEsc, int profOral)
		{
			string resultado = "Reprovado!";
			if (VerificarProficienciaIdioma())
			{
				double media = (aptFis + profEsc + profOral) / 3.0;

				// Obter uma média arredondada em duas casas decimal. 
				double mediaArredo = Math.Round(media, 2);
				if (mediaArredo >= 10)
					resultado = "Aprovado!";
			}
				

			return resultado;
		}

		private bool VerificarProficienciaIdioma()
		{
			var linguasSeleccionadas = new List<string>();

			if (checkedListBox1.CheckedItems != null)
			{
				foreach (var item in checkedListBox1.CheckedItems)
					linguasSeleccionadas.Add(item.ToString());
			}
			
			return linguasSeleccionadas.Count() >= 2;
		}
		#endregion
		#region Limpeza
		private void LimparDadosInseridos()
		{
			textBoxNomeAluno.ResetText();
			numericUpDown1.ResetText();
			numericUpDown2.ResetText();
			numericUpDown3.ResetText();
			
			for (int i = 0; i < checkedListBox1.Items.Count; i++)
				checkedListBox1.SetItemChecked(i, false);
        }

		private void Button2_Click(object sender, EventArgs e)
		{
			// Limpar o DataGrid.
			dataGridView1.Rows.Clear();
		}
		#endregion
	}
}
