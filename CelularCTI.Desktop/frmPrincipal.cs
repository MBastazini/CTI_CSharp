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

namespace CelularCTI.Desktop
{
    public partial class frmPrincipal : Form
    {
        private List<Aparelho> aparelhos = new List<Aparelho>();
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {

        }

    }
}
