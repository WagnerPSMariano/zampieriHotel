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
    public partial class Quartos : Form
    {
        public Quartos()
        {
            InitializeComponent();

            mskQuartoID.Enabled = true;
            txtNomeResp.Enabled = true;
            cbHospedes.Enabled = true;
            txtFormaPagto.Enabled = true;
            mskDataEnt.Enabled = true;
            mskDataSaida.Enabled = true;
        }

        private void btnReservar_Click(object sender, EventArgs e)
        {
            mskQuartoID.Enabled = true;
            txtNomeResp.Enabled = true;
            cbHospedes.Enabled = true;
            txtFormaPagto.Enabled = true;
            mskDataEnt.Enabled = true;
            mskDataSaida.Enabled = true;

            if (btnReservar.Enabled)
                btnReservar.Enabled = false;
            else
                btnReservar.Enabled = true;
        }

        /*private void btnPagar_Click(object sender, EventArgs e)
        {
            mskQuartoID.Enabled = true;
            txtNomeResp.Enabled = true;
            cbHospedes.Enabled = true;
            txtFormaPagto.Enabled = true;
            mskDataEnt.Enabled = true;
            mskDataSaida.Enabled = true;
        }*/

        private void btnCheckIn_Click(object sender, EventArgs e)
        {
            mskQuartoID.Enabled = true;
            txtNomeResp.Enabled = true;
            cbHospedes.Enabled = true;
            txtFormaPagto.Enabled = true;
            mskDataEnt.Enabled = true;
            mskDataSaida.Enabled = true;

            if (btnCheckIn.Enabled)
                btnCheckIn.Enabled = false;
            else
                btnCheckIn.Enabled = true;
        }

        private void btnCheckOut_Click(object sender, EventArgs e)
        {
            mskQuartoID.Enabled = true;
            txtNomeResp.Enabled = true;
            cbHospedes.Enabled = true;
            txtFormaPagto.Enabled = true;
            mskDataEnt.Enabled = true;
            mskDataSaida.Enabled = true;

            if (btnCheckOut.Enabled)
                btnCheckOut.Enabled = false;
            else
                btnCheckOut.Enabled = true;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            mskQuartoID.Enabled = true;
            txtNomeResp.Enabled = true;
            cbHospedes.Enabled = true;
            txtFormaPagto.Enabled = true;
            mskDataEnt.Enabled = true;
            mskDataSaida.Enabled = true;

            if (btnCancelar.Enabled)
                btnCancelar.Enabled = false;
            else
                btnCancelar.Enabled = true;
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            Dashboard janelaDash = new Dashboard();
            janelaDash.Show();
            this.Close();
        }
    }
}
