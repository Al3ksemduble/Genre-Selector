using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Seletor_de_Genero
{
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private void btnConfir_Click(object sender, EventArgs e)
        {
            if (rbHomem.Checked)
            {
                txtbox1.Text = "Homem selecionado.";
            }
            else if (rbMulher.Checked)
            {
                txtbox1.Text = "Mulher selecionada.";
            }
            else
            {
                txtbox1.Text = "Prefere não informar.";
            }
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
