using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CelularCTI.Model;
using Npgsql;

namespace CelularCTI.Desktop
{
    public partial class frmPrincipal : Form
    {
        private List<Aparelho> aparelhos = new List<Aparelho>();
        private List<Fabricante> fabricantes = new List<Fabricante>();
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            fabricantes = Servico.ListarFabricantes();
            cmbFabricante.DataSource = fabricantes;
            cmbFabricante.ValueMember = "id_fabricante";
            cmbFabricante.DisplayMember = "Nome";

            aparelhos = Servico.BuscarAparelho("");
            lstCelulares.DataSource = aparelhos;

        }

        private void btnPesquisarModelo_Click(object sender, EventArgs e)
        {
            aparelhos = Servico.BuscarAparelho(txtModelo.Text);
            lstCelulares.DataSource = aparelhos;
        }

        private void btnPesquisarPreco_Click(object sender, EventArgs e)
        {
            aparelhos = Servico.BuscarAparelho(numMinimo.Value, numMaximo.Value);
            lstCelulares.DataSource = aparelhos;
        }

        private void btnFabricante_Click(object sender, EventArgs e)
        {
            aparelhos = Servico.BuscarAparelhos(cmbFabricante.SelectedItem as Fabricante);
            lstCelulares.DataSource = aparelhos;
        }

        private void cmbFabricante_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void txtModelo_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }
    }
}
