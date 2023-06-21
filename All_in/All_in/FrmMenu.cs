using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace All_in
{
    public partial class FrmMenu : Form
    {
        public FrmMenu()
        {
            InitializeComponent();
            FrmSplash splash = new FrmSplash();
            splash.Show();
            Application.DoEvents();
            Thread.Sleep(3000);
            splash.Close();
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void PbxBuscaCEP_Click(object sender, EventArgs e)
        {
            FrmBuscaCEP buscaCEP = new FrmBuscaCEP();
            buscaCEP.Show();
        }

        private void PbxImpostoRenda_Click(object sender, EventArgs e)
        {
            FrmImpostoRenda IR = new FrmImpostoRenda();
            IR.Show();
        }

        private void PbxIMC_Click(object sender, EventArgs e)
        {
            FrmCalculoIMC IMC = new FrmCalculoIMC();
            IMC.Show();
        }

        private void pbxConTemperatura_Click(object sender, EventArgs e)
        {
            FrmConversorTemp temperatura = new FrmConversorTemp();
            temperatura.Show();
        }

        private void PbxMediaConsumo_Click(object sender, EventArgs e)
        {
            FrmMediaConsumo consumo = new FrmMediaConsumo();
            consumo.Show();
        }
    }
}
