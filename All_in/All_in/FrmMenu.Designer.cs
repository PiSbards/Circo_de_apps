namespace All_in
{
    partial class FrmMenu
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMenu));
            this.PbxBuscaCEP = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.PbxImpostoRenda = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.PbxIMC = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.pbxConTemperatura = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.PbxMediaConsumo = new System.Windows.Forms.PictureBox();
            this.btnFechar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.PbxBuscaCEP)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbxImpostoRenda)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbxIMC)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxConTemperatura)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbxMediaConsumo)).BeginInit();
            this.SuspendLayout();
            // 
            // PbxBuscaCEP
            // 
            this.PbxBuscaCEP.Image = global::All_in.Properties.Resources.cep1;
            this.PbxBuscaCEP.Location = new System.Drawing.Point(24, 12);
            this.PbxBuscaCEP.Name = "PbxBuscaCEP";
            this.PbxBuscaCEP.Size = new System.Drawing.Size(255, 215);
            this.PbxBuscaCEP.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PbxBuscaCEP.TabIndex = 0;
            this.PbxBuscaCEP.TabStop = false;
            this.PbxBuscaCEP.Click += new System.EventHandler(this.PbxBuscaCEP_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Schoolbook", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(88, 240);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 23);
            this.label1.TabIndex = 1;
            this.label1.Text = "Busca CEP";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Schoolbook", 14.25F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.Blue;
            this.label2.Location = new System.Drawing.Point(390, 240);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(189, 23);
            this.label2.TabIndex = 3;
            this.label2.Text = "Imposto de Renda";
            // 
            // PbxImpostoRenda
            // 
            this.PbxImpostoRenda.Image = global::All_in.Properties.Resources.IP;
            this.PbxImpostoRenda.Location = new System.Drawing.Point(352, 12);
            this.PbxImpostoRenda.Name = "PbxImpostoRenda";
            this.PbxImpostoRenda.Size = new System.Drawing.Size(255, 215);
            this.PbxImpostoRenda.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PbxImpostoRenda.TabIndex = 2;
            this.PbxImpostoRenda.TabStop = false;
            this.PbxImpostoRenda.Click += new System.EventHandler(this.PbxImpostoRenda_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Schoolbook", 14.25F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.Blue;
            this.label3.Location = new System.Drawing.Point(774, 240);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 23);
            this.label3.TabIndex = 5;
            this.label3.Text = "IMC";
            // 
            // PbxIMC
            // 
            this.PbxIMC.Image = global::All_in.Properties.Resources.imc;
            this.PbxIMC.Location = new System.Drawing.Point(663, 12);
            this.PbxIMC.Name = "PbxIMC";
            this.PbxIMC.Size = new System.Drawing.Size(255, 215);
            this.PbxIMC.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PbxIMC.TabIndex = 4;
            this.PbxIMC.TabStop = false;
            this.PbxIMC.Click += new System.EventHandler(this.PbxIMC_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Schoolbook", 14.25F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.Blue;
            this.label4.Location = new System.Drawing.Point(163, 542);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(281, 23);
            this.label4.TabIndex = 7;
            this.label4.Text = "Conversor de Temperatura";
            // 
            // pbxConTemperatura
            // 
            this.pbxConTemperatura.Image = global::All_in.Properties.Resources.temperatura;
            this.pbxConTemperatura.Location = new System.Drawing.Point(176, 304);
            this.pbxConTemperatura.Name = "pbxConTemperatura";
            this.pbxConTemperatura.Size = new System.Drawing.Size(255, 215);
            this.pbxConTemperatura.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxConTemperatura.TabIndex = 6;
            this.pbxConTemperatura.TabStop = false;
            this.pbxConTemperatura.Click += new System.EventHandler(this.pbxConTemperatura_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Schoolbook", 14.25F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.Color.Blue;
            this.label5.Location = new System.Drawing.Point(559, 532);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(199, 46);
            this.label5.TabIndex = 9;
            this.label5.Text = "Média de Consumo\r\n   de Combustível\r\n";
            // 
            // PbxMediaConsumo
            // 
            this.PbxMediaConsumo.Image = global::All_in.Properties.Resources.consumo;
            this.PbxMediaConsumo.Location = new System.Drawing.Point(531, 304);
            this.PbxMediaConsumo.Name = "PbxMediaConsumo";
            this.PbxMediaConsumo.Size = new System.Drawing.Size(255, 215);
            this.PbxMediaConsumo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PbxMediaConsumo.TabIndex = 8;
            this.PbxMediaConsumo.TabStop = false;
            this.PbxMediaConsumo.Click += new System.EventHandler(this.PbxMediaConsumo_Click);
            // 
            // btnFechar
            // 
            this.btnFechar.BackColor = System.Drawing.Color.Crimson;
            this.btnFechar.FlatAppearance.BorderSize = 0;
            this.btnFechar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFechar.ForeColor = System.Drawing.Color.White;
            this.btnFechar.Location = new System.Drawing.Point(830, 529);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(112, 36);
            this.btnFechar.TabIndex = 10;
            this.btnFechar.Text = "FECHAR";
            this.btnFechar.UseVisualStyleBackColor = false;
            this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);
            // 
            // FrmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(964, 603);
            this.Controls.Add(this.btnFechar);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.PbxMediaConsumo);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.pbxConTemperatura);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.PbxIMC);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.PbxImpostoRenda);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.PbxBuscaCEP);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Muilti Apps";
            ((System.ComponentModel.ISupportInitialize)(this.PbxBuscaCEP)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbxImpostoRenda)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbxIMC)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxConTemperatura)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbxMediaConsumo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox PbxBuscaCEP;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox PbxImpostoRenda;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox PbxIMC;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pbxConTemperatura;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox PbxMediaConsumo;
        private System.Windows.Forms.Button btnFechar;
    }
}

