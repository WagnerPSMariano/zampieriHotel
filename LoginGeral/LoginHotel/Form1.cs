using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LoginHotel
{
    public partial class FrmZamp : Form
    {
        public FrmZamp()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnAcessar_Click(object sender, EventArgs e)
        {
            string id, senha;
            id = txtId.Text;
            senha = txtSenha.Text;

            if (id == "171171" && senha == "Zampieri")
            {
                Dashboard novo = new Dashboard();
                novo.Show();
                this.Visible = false;
            }
        }
    }
}
