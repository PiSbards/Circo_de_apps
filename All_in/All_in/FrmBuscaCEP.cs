using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.Net;
using System.IO;

namespace All_in
{
    public partial class FrmBuscaCEP : Form
    {
        public FrmBuscaCEP()
        {
            InitializeComponent();
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create("https://viacep.com.br/ws/"+txtCEP.Text+"/json/");
            request.AllowAutoRedirect = false;
            HttpWebResponse ChecaServidor = (HttpWebResponse)request.GetResponse();
            if (ChecaServidor.StatusCode != HttpStatusCode.OK)
            {
                MessageBox.Show("Servidor Indisponível!");
                return;
            }
            using (Stream webstream = ChecaServidor.GetResponseStream())
            {
                if (webstream != null)
                {
                    using(StreamReader responseReader = new StreamReader(webstream))
                    {
                        string response = responseReader.ReadToEnd();
                        response = Regex.Replace(response, "[{},]", string.Empty); //colchete serve para conseguir substituir mais de um simbolo de uma vez;
                        response = response.Replace("\"", ""); //replace normal consegue tirar aspas duplas, utilizando "\";
                        string[] substrings = response.Split('\n');
                        int cont = 0;
                        foreach (var substring in substrings)
                        {
                            if (cont ==1)
                            {
                                string[] valor = substring.Split(":".ToCharArray());
                                if(valor[0] == "erro")
                                {
                                    MessageBox.Show("CEP não encontrado!");
                                    txtCEP.Focus();
                                    return;
                                }
                            }
                            if(cont == 2)
                            {
                                string[] valor = substring.Split(":".ToCharArray());
                                lblEndereco.Text = valor[1];
                            }
                            if (cont == 3)
                            {
                                string[] valor = substring.Split(":".ToCharArray());
                                lblComplemento.Text = valor[1];
                            }
                            if (cont == 4)
                            {
                                string[] valor = substring.Split(":".ToCharArray());
                                lblBairro.Text = valor[1];
                            }
                            if (cont == 5)
                            {
                                string[] valor = substring.Split(":".ToCharArray());
                                lblCidade.Text = valor[1];
                            }
                            if (cont == 6)
                            {
                                string[] valor = substring.Split(":".ToCharArray());
                                lblUF.Text = valor[1];
                            }
                            cont++;
                        }
                    }
                }
            }
        }
    }
}
