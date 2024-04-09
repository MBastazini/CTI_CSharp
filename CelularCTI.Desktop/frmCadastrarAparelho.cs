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
        public frmCadastrarAparelho()
        {
            InitializeComponent();
        }


        private void btnSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                Aparelho ap = new Aparelho();
                ap.Modelo = txtModelo.Text;
                ap.Fabricante = cmbFabricante.SelectedItem as Fabricante;
                ap.Largura = (double) numLargura.Value;
                ap.Altura = (double) numAltura.Value;
                ap.Espessura = (double)numEspessura.Value;
                ap.Peso = (double)numPeso.Value;
                ap.Quantidade = (long)numQuantidade.Value;
                ap.Preco = numPreco.Value;
                ap.Desconto = numDesconto.Value;

                Servico.Salvar(ap);
                MessageBox.Show("Aparelho salvo com sucesso", Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao salvar aparelho: " + ex.Message, Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void frmCadastrarAparelho_Load(object sender, EventArgs e)
        {
            try
            {
                List<Fabricante> fabricantes = Servico.ListarFabricantes();
                cmbFabricante.DataSource = fabricantes;
                cmbFabricante.ValueMember = "id_fabricante";
                cmbFabricante.DisplayMember = "Nome";
                cmbFabricante.SelectedIndex = -1;
            } catch (Exception ex)
            {
                MessageBox.Show("Erro ao carregar fabricantes: " + ex.Message);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
