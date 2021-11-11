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
    public partial class Relatorios : Form
    {
        public Relatorios()
        {
            InitializeComponent();
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            if (btnConsultar.Enabled)
                btnConsultar.Enabled = false;
            else
                btnConsultar.Enabled = true;
        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            if (btnAtualizar.Enabled)
                btnAtualizar.Enabled = false;
            else
                btnAtualizar.Enabled = true;
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            Dashboard janelaDash = new Dashboard();
            janelaDash.Show();
            this.Close();
        }
    }
}
