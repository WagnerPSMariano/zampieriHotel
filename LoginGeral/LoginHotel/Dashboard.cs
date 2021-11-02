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
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
        }

        private void btnCliente_Click(object sender, EventArgs e)
        {
            DadosCliente janelaCiente = new DadosCliente();
            janelaCiente.Show();
            this.Close();
        }

        private void btnFuncionario_Click(object sender, EventArgs e)
        {
            DadosFuncionario janelaFuncionario = new DadosFuncionario();
            janelaFuncionario.Show();
            this.Close();
        }

        private void btnQuarto_Click(object sender, EventArgs e)
        {
            Quartos janelaQuarto = new Quartos();
            janelaQuarto.Show();
            this.Close();
        }

        private void btnRelatório_Click(object sender, EventArgs e)
        {
            Relatorios janelaRelatorio = new Relatorios();
            janelaRelatorio.Show();
            this.Close();
        }
    }
}
