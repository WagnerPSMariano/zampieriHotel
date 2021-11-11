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
    public partial class DadosCliente : Form
    {
        //public Form janelaDadosClientes = null;
        public DadosCliente()
        {
            InitializeComponent();

            txtClienteNome.Enabled = true;
            txtClienteEmail.Enabled = true;
            txtClienteEnd.Enabled = true;
            mskCEP.Enabled = true;
            mskDataNascClient.Enabled = true;
            mskTelClient.Enabled = true;
            mskCPFClient.Enabled = true;
        }

        private void DadosCliente_Load(object sender, EventArgs e)
        {
            
            
        }

        private void btnCadastrarCliente_Click(object sender, EventArgs e)
        {
            txtClienteNome.Enabled = true;
            txtClienteEmail.Enabled = true;
            txtClienteEnd.Enabled = true;
            mskCEP.Enabled = true;
            mskDataNascClient.Enabled = true;
            mskTelClient.Enabled = true;
            mskCPFClient.Enabled = true;

            if (btnCadastrarCliente.Enabled)
                btnCadastrarCliente.Enabled = false;
            else
                btnCadastrarCliente.Enabled = true;
        }

        private void btnEditarCliente_Click(object sender, EventArgs e)
        {
            txtClienteNome.Enabled = true;
            txtClienteEmail.Enabled = true;
            txtClienteEnd.Enabled = true;
            mskCEP.Enabled = true;
            mskDataNascClient.Enabled = true;
            mskTelClient.Enabled = true;
            mskCPFClient.Enabled = true;

            if (btnEditarCliente.Enabled)
                btnEditarCliente.Enabled = false;
            else
                btnEditarCliente.Enabled = true;
        }

        private void btnListarCliente_Click(object sender, EventArgs e)
        {
            txtClienteNome.Enabled = true;
            txtClienteEmail.Enabled = true;
            txtClienteEnd.Enabled = true;
            mskCEP.Enabled = true;
            mskDataNascClient.Enabled = true;
            mskTelClient.Enabled = true;
            mskCPFClient.Enabled = true;

            if (btnListarCliente.Enabled)
                btnListarCliente.Enabled = false;
            else
                btnListarCliente.Enabled = true;
        }

        private void btnExcluirCliente_Click(object sender, EventArgs e)
        {
            txtClienteNome.Enabled = true;
            txtClienteEmail.Enabled = true;
            txtClienteEnd.Enabled = true;
            mskCEP.Enabled = true;
            mskDataNascClient.Enabled = true;
            mskTelClient.Enabled = true;
            mskCPFClient.Enabled = true;

            if (btnExcluirCliente.Enabled)
                btnExcluirCliente.Enabled = false;
            else
                btnExcluirCliente.Enabled = true;
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            Dashboard janelaDash = new Dashboard();
            janelaDash.Show();
            this.Close();
        }
    }
}
