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
    public partial class FrmImpostoRenda : Form
    {
        public FrmImpostoRenda()
        {
            InitializeComponent();
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)8 && e.KeyChar != (char)44)
            {
                e.Handled = true;
            }
        }

        private void FrmImpostoRenda_Load(object sender, EventArgs e)
        {
            this.ActiveControl = txtSalario;
            txtSalario.Focus();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            Double salario,resultado;
            if (txtSalario.Text == "")
            {
                MessageBox.Show("SEU PUTO!!NÃO HÁ CALCULO SEM VALORES! PREENCHA TODOS OS CAMPOS.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                salario=Convert.ToDouble(txtSalario.Text);
                txtSalario.Text = "";
                if (salario <= 2112)
                {
                    lblAliquota.Text = "Isento, não há necessidade";
                    lblDesconto.Text = "N/A";
                    
                }else if (salario >= 2112.01 && salario <= 2826.65)
                {
                    resultado= Convert.ToDouble(salario*0.075);
                    lblAliquota.Text = "7,5%";
                    lblDesconto.Text = resultado.ToString("F");
                    
                }else if(salario >=2826.66 && salario <= 3751.05)
                {
                    resultado = Convert.ToDouble(salario * 0.15);
                    lblAliquota.Text = "15%";
                    lblDesconto.Text = resultado.ToString("F");

                }
                else if(salario >= 3751.06 && salario <= 4664.68)
                {
                    resultado = Convert.ToDouble(salario * 0.225);
                    lblAliquota.Text = "22,6%";
                    lblDesconto.Text = resultado.ToString("F");

                }
                else if(salario >= 4664.68)
                {
                    resultado = Convert.ToDouble(salario * 0.275);
                    lblAliquota.Text = "27,5%";
                    lblDesconto.Text = resultado.ToString("F");

                }
            }
        }
    }
}
