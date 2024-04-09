using CelularCTI.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CelularCTI.Desktop
{
	public partial class frmCadastrarAparelho : Form
	{
		private List<Fabricante> fabricantes = new List<Fabricante>();

		public frmCadastrarAparelho()
		{
			InitializeComponent();
		}

		private void frmCadastrarAparelho_Load(object sender, EventArgs e)
		{
			fabricantes = Servico.ListarFabricantes();
			cmbFabricante.DataSource = fabricantes;
			cmbFabricante.DisplayMember = "Nome";
			cmbFabricante.ValueMember = "id_fabricante";
			cmbFabricante.SelectedIndex = -1;
		}

		private void btnSalvar_Click(object sender, EventArgs e)
		{
			try
			{
				//Teste de consistência de dados - Validação Regras de Negócio
				if (cmbFabricante.SelectedIndex == -1)
				{
					MessageBox.Show("Selecione um fabricante para o aparelho!", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
					cmbFabricante.Focus();
					return;
				}
				Aparelho ap = new Aparelho();
				ap.Fabricante = fabricantes[cmbFabricante.SelectedIndex];
				ap.Modelo = txtModelo.Text;
				ap.Largura = Convert.ToDouble(numLargura.Value);
				ap.Altura = Convert.ToDouble(numAltura.Value);
				ap.Espessura = Convert.ToDouble(numEspessura.Value);
				ap.Peso = Convert.ToDouble(numPeso.Value);
				ap.Quantidade = Convert.ToInt64(numQuantidade.Value);
				ap.Preco = Convert.ToDecimal(numPreco.Value);
				ap.Desconto = Convert.ToDecimal(numDesconto.Value);

				Servico.Salvar(ap);

				MessageBox.Show("O aparelho" + txtModelo + "foi registrado com sucesso!", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
			}
			catch (Exception ex)
			{
				MessageBox.Show("Ocorreu um erro ao cadastrar o aparelho" + "\n\nMais detalhes:" + ex.Message, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);

				this.Close();
			}
		}

		private void btnCancelar_Click(object sender, EventArgs e)
		{
			DialogResult resposta;
			resposta = MessageBox.Show("Deseja realmente cancelar o cadastro deste aparelho?",
				this.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
			if (resposta == DialogResult.Yes)
				this.Close();
		}
	}
}
