using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace All_in
{
    public partial class FrmMediaConsumo : Form
    {
        public FrmMediaConsumo()
        {
            InitializeComponent();
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            double km, litros, resultado,total;
            km=Convert.ToDouble(txtKM.Text);
            litros=Convert.ToDouble(txtLitros.Text);
            resultado = km/litros;
            lblMedia.Text = resultado.ToString("F")+"KM/L";
            if(cbxCombustivel.Text == "Etanol")
            {
                total = 4.39 * litros;
                lblTotal.Text = Convert.ToString("R$" + total);
            }
            else if (cbxCombustivel.Text == "Gasolina")
            {
                total = 5.21 * litros;
                lblTotal.Text=Convert.ToString("R$" + total);
            }
            else if(cbxCombustivel.Text == "Diesel")
            {
                total = 5.16 * litros;
                lblTotal.Text = Convert.ToString("R$" + total);
            }
        }
    }
}
