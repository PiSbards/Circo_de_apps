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
    public partial class FrmCalculoIMC : Form
    {
        public FrmCalculoIMC()
        {
            InitializeComponent();
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmCalculoIMC_Load(object sender, EventArgs e)
        {
            this.ActiveControl = txtPeso;
            txtPeso.Focus();
        }

        private void txtPeso_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)8 && e.KeyChar != (char)44)
            {
                e.Handled = true;
            }
        }

        private void txtAltura_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)8 && e.KeyChar != (char)44)
            {
                e.Handled = true;
            }
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            Double peso, altura, resultado;
            if (txtPeso.Text == "" || txtAltura.Text == "")
            {
                MessageBox.Show("NÃO HÁ CALCULO SEM VALORES! PREENCHA TODOS OS CAMPOS.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                altura = Convert.ToDouble(txtAltura.Text);
                peso = Convert.ToDouble(txtPeso.Text);
                resultado = (peso / (altura*altura))*10000;
                lblResultado.Text = resultado.ToString("F");
                txtAltura.Text = "";
                txtPeso.Text = "";
                if (resultado <=18)
                {
                    lblMensagem.Text = "MAGREZA";
                }
                else if(resultado <= 25)
                {
                    lblMensagem.Text = "NORMAL";
                }
                else if (resultado<=30)
                {
                    lblMensagem.Text = "SOBREPESO";
                }
                else if (resultado <= 40)
                {
                    lblMensagem.Text = "OBESO";
                }
                else
                {
                    lblMensagem.Text = "TA GORDÃO CRIA, TA MORRENDO JÁ!!";
                }
            }
        }
    }
}
