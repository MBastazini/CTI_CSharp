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


        private void btnNovo_Click(object sender, EventArgs e)
        {
            frmCadastrarAparelho frm = new frmCadastrarAparelho();
            frm.ShowDialog();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnComprar_Click(object sender, EventArgs e)
        {
            //Abrir um popup perguntando se deseja comprar o aparelho selecionado (na ListBox)
            //Se sim, reduzir 1 na quantidad em estoque e salvar no banco
            //Se não, não fazer nada
            Aparelho ap = lstCelulares.SelectedItem as Aparelho;

            if (ap == null)
            {
                MessageBox.Show("Selecione um aparelho para comprar", Text, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else
            {
                DialogResult dr = MessageBox.Show("Deseja comprar o aparelho " + ap.Modelo + "?", Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dr == DialogResult.Yes)
                {
                    ap.Quantidade -= 1;
                    Servico.Salvar(ap);
                    MessageBox.Show("Aparelho comprado com sucesso", Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    aparelhos = Servico.BuscarAparelho("");
                    lstCelulares.DataSource = aparelhos;
                }
                else
                {
                    MessageBox.Show("Compra cancelada", Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }


        }

        private void btnRecarregar_Click(object sender, EventArgs e)
        {
            aparelhos = Servico.BuscarAparelho("");
            lstCelulares.DataSource = aparelhos;
        }
    }
}
