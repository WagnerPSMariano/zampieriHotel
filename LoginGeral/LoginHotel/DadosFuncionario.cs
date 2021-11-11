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
    public partial class DadosFuncionario : Form
    {
        public DadosFuncionario()
        {
            InitializeComponent();

            txtFuncNome.Enabled = true;
            txtFuncEmail.Enabled = true;
            txtFuncEnd.Enabled = true;
            txtFuncID.Enabled = true;
            mskDataNasc.Enabled = true;
            mskTel.Enabled = true;
            mskCPF.Enabled = true;
        }

        private void DadosFuncionario_Load(object sender, EventArgs e)
        {

        }

        private void btnCadastrarFunc_Click(object sender, EventArgs e)
        {
            txtFuncNome.Enabled = true;
            txtFuncEmail.Enabled = true;
            txtFuncEnd.Enabled = true;
            txtFuncID.Enabled = true;
            mskDataNasc.Enabled = true;
            mskTel.Enabled = true;
            mskCPF.Enabled = true;

            if (btnCadastrarFunc.Enabled)
                btnCadastrarFunc.Enabled = false;
            else
                btnCadastrarFunc.Enabled = true;
        }

        private void btnEditarFunc_Click(object sender, EventArgs e)
        {
            txtFuncNome.Enabled = true;
            txtFuncEmail.Enabled = true;
            txtFuncEnd.Enabled = true;
            txtFuncID.Enabled = true;
            mskDataNasc.Enabled = true;
            mskTel.Enabled = true;
            mskCPF.Enabled = true;

            if (btnEditarFunc.Enabled)
                btnEditarFunc.Enabled = false;
            else
                btnEditarFunc.Enabled = true;
        }

        private void btnListarFunc_Click(object sender, EventArgs e)
        {
            txtFuncNome.Enabled = true;
            txtFuncEmail.Enabled = true;
            txtFuncEnd.Enabled = true;
            txtFuncID.Enabled = true;
            mskDataNasc.Enabled = true;
            mskTel.Enabled = true;
            mskCPF.Enabled = true;

            if (btnListarFunc.Enabled)
                btnListarFunc.Enabled = false;
            else
                btnListarFunc.Enabled = true;
        }

        private void btnExcluirFunc_Click(object sender, EventArgs e)
        {
            txtFuncNome.Enabled = true;
            txtFuncEmail.Enabled = true;
            txtFuncEnd.Enabled = true;
            txtFuncID.Enabled = true;
            mskDataNasc.Enabled = true;
            mskTel.Enabled = true;
            mskCPF.Enabled = true;

            if (btnExcluirFunc.Enabled)
                btnExcluirFunc.Enabled = false;
            else
                btnExcluirFunc.Enabled = true;
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            Dashboard janelaDash = new Dashboard();
            janelaDash.Show();
            this.Close();
        }
    }
}
