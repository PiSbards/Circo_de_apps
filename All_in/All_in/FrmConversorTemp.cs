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
    public partial class FrmConversorTemp : Form
    {
        public FrmConversorTemp()
        {
            InitializeComponent();
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            double temp, temperatura;
            if (cbxDe.Text == cbxPara.Text)
            {
                MessageBox.Show("IMPOSSÍVEL REALIZAR CÁLCULO, POR FAVOR ARRUME OS CAMPOS");
            }
            else if (cbxDe.Text == "Celsius" && cbxPara.Text == "Kelvin")
            {
                temp = Convert.ToDouble(txtTemperatura.Text);
                temperatura = temp + 273.15;
                lblResultado.Text = temperatura.ToString("F")+"°K";
            }
            else if (cbxDe.Text == "Celsius" && cbxPara.Text == "Fahrenheit")
            {
                temp = Convert.ToDouble(txtTemperatura.Text);
                temperatura = (temp * 9 / 5) + 32;
                lblResultado.Text = temperatura.ToString("F")+"°F";
            }
            else if (cbxDe.Text == "Kelvin" && cbxPara.Text == "Celsius")
            {
                temp = Convert.ToDouble(txtTemperatura.Text);
                temperatura = temp - 273.15;
                lblResultado.Text = temperatura.ToString("F")+"°C";
            }
            else if (cbxDe.Text == "Kelvin" && cbxPara.Text == "Fahrenheit")
            {
                temp = Convert.ToDouble(txtTemperatura.Text);
                temperatura = (temp - 273.15) * 9 / 5 + 32;
                lblResultado.Text = temperatura.ToString("F")+"°F";
            }
            else if (cbxDe.Text == "Fahrenheit" && cbxPara.Text == "Kelvin")
            {
                temp = Convert.ToDouble(txtTemperatura.Text);
                temperatura = (temp - 32) * 5 / 9 + 273.15;
                lblResultado.Text = temperatura.ToString("F")+"°K";
            }
            else if (cbxDe.Text == "Fahrenheit" && cbxPara.Text == "Celsius")
            {
                temp = Convert.ToDouble(txtTemperatura.Text);
                temperatura = (temp - 32)* 5 / 9;
                lblResultado.Text = temperatura.ToString("F")+"°C";
            }
        }

    }
}
