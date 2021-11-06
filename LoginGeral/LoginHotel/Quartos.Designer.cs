﻿
namespace LoginHotel
{
    partial class Quartos
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.mskQuartoID = new System.Windows.Forms.MaskedTextBox();
            this.mskDataEnt = new System.Windows.Forms.MaskedTextBox();
            this.mskDataSaida = new System.Windows.Forms.MaskedTextBox();
            this.txtNomeResp = new System.Windows.Forms.TextBox();
            this.txtHospedes = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtFormaPagto = new System.Windows.Forms.TextBox();
            this.btnPagar = new System.Windows.Forms.Button();
            this.btnCheckIn = new System.Windows.Forms.Button();
            this.btnCheckOut = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnReservar = new System.Windows.Forms.Button();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(187, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID Quarto";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(89, 112);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(179, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nome do Responsável";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(187, 145);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 18);
            this.label3.TabIndex = 2;
            this.label3.Text = "Hóspedes";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(141, 217);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(127, 18);
            this.label4.TabIndex = 3;
            this.label4.Text = "Data de entrada";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(157, 252);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(111, 18);
            this.label5.TabIndex = 4;
            this.label5.Text = "Data de saída";
            // 
            // mskQuartoID
            // 
            this.mskQuartoID.Location = new System.Drawing.Point(297, 78);
            this.mskQuartoID.Mask = "00000000";
            this.mskQuartoID.Name = "mskQuartoID";
            this.mskQuartoID.Size = new System.Drawing.Size(64, 20);
            this.mskQuartoID.TabIndex = 5;
            this.mskQuartoID.ValidatingType = typeof(int);
            // 
            // mskDataEnt
            // 
            this.mskDataEnt.Location = new System.Drawing.Point(297, 218);
            this.mskDataEnt.Mask = "00/00/0000";
            this.mskDataEnt.Name = "mskDataEnt";
            this.mskDataEnt.Size = new System.Drawing.Size(72, 20);
            this.mskDataEnt.TabIndex = 6;
            this.mskDataEnt.ValidatingType = typeof(System.DateTime);
            // 
            // mskDataSaida
            // 
            this.mskDataSaida.Location = new System.Drawing.Point(297, 253);
            this.mskDataSaida.Mask = "00/00/0000";
            this.mskDataSaida.Name = "mskDataSaida";
            this.mskDataSaida.Size = new System.Drawing.Size(72, 20);
            this.mskDataSaida.TabIndex = 7;
            this.mskDataSaida.ValidatingType = typeof(System.DateTime);
            // 
            // txtNomeResp
            // 
            this.txtNomeResp.Location = new System.Drawing.Point(297, 110);
            this.txtNomeResp.Name = "txtNomeResp";
            this.txtNomeResp.Size = new System.Drawing.Size(294, 20);
            this.txtNomeResp.TabIndex = 8;
            // 
            // txtHospedes
            // 
            this.txtHospedes.Location = new System.Drawing.Point(297, 145);
            this.txtHospedes.Name = "txtHospedes";
            this.txtHospedes.Size = new System.Drawing.Size(182, 20);
            this.txtHospedes.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(100, 183);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(168, 18);
            this.label6.TabIndex = 10;
            this.label6.Text = "Forma de pagamento";
            // 
            // txtFormaPagto
            // 
            this.txtFormaPagto.Location = new System.Drawing.Point(297, 181);
            this.txtFormaPagto.Name = "txtFormaPagto";
            this.txtFormaPagto.Size = new System.Drawing.Size(182, 20);
            this.txtFormaPagto.TabIndex = 11;
            // 
            // btnPagar
            // 
            this.btnPagar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPagar.Location = new System.Drawing.Point(175, 340);
            this.btnPagar.Name = "btnPagar";
            this.btnPagar.Size = new System.Drawing.Size(96, 59);
            this.btnPagar.TabIndex = 12;
            this.btnPagar.Text = "Efetuar pagamento";
            this.btnPagar.UseVisualStyleBackColor = true;
            this.btnPagar.Click += new System.EventHandler(this.btnPagar_Click);
            // 
            // btnCheckIn
            // 
            this.btnCheckIn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCheckIn.Location = new System.Drawing.Point(290, 340);
            this.btnCheckIn.Name = "btnCheckIn";
            this.btnCheckIn.Size = new System.Drawing.Size(96, 59);
            this.btnCheckIn.TabIndex = 13;
            this.btnCheckIn.Text = "Check-In";
            this.btnCheckIn.UseVisualStyleBackColor = true;
            this.btnCheckIn.Click += new System.EventHandler(this.btnCheckIn_Click);
            // 
            // btnCheckOut
            // 
            this.btnCheckOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCheckOut.Location = new System.Drawing.Point(404, 340);
            this.btnCheckOut.Name = "btnCheckOut";
            this.btnCheckOut.Size = new System.Drawing.Size(96, 59);
            this.btnCheckOut.TabIndex = 14;
            this.btnCheckOut.Text = "Check-Out";
            this.btnCheckOut.UseVisualStyleBackColor = true;
            this.btnCheckOut.Click += new System.EventHandler(this.btnCheckOut_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.Location = new System.Drawing.Point(525, 340);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(96, 59);
            this.btnCancelar.TabIndex = 15;
            this.btnCancelar.Text = "Cancelar ";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnReservar
            // 
            this.btnReservar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReservar.Location = new System.Drawing.Point(59, 340);
            this.btnReservar.Name = "btnReservar";
            this.btnReservar.Size = new System.Drawing.Size(96, 59);
            this.btnReservar.TabIndex = 16;
            this.btnReservar.Text = "Reservar";
            this.btnReservar.UseVisualStyleBackColor = true;
            this.btnReservar.Click += new System.EventHandler(this.btnReservar_Click);
            // 
            // btnVoltar
            // 
            this.btnVoltar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVoltar.Location = new System.Drawing.Point(648, 340);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(96, 59);
            this.btnVoltar.TabIndex = 17;
            this.btnVoltar.Text = "Voltar";
            this.btnVoltar.UseVisualStyleBackColor = true;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // Quartos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.btnReservar);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnCheckOut);
            this.Controls.Add(this.btnCheckIn);
            this.Controls.Add(this.btnPagar);
            this.Controls.Add(this.txtFormaPagto);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtHospedes);
            this.Controls.Add(this.txtNomeResp);
            this.Controls.Add(this.mskDataSaida);
            this.Controls.Add(this.mskDataEnt);
            this.Controls.Add(this.mskQuartoID);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Quartos";
            this.Text = "Quartos";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.MaskedTextBox mskQuartoID;
        private System.Windows.Forms.MaskedTextBox mskDataEnt;
        private System.Windows.Forms.MaskedTextBox mskDataSaida;
        private System.Windows.Forms.TextBox txtNomeResp;
        private System.Windows.Forms.TextBox txtHospedes;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtFormaPagto;
        private System.Windows.Forms.Button btnPagar;
        private System.Windows.Forms.Button btnCheckIn;
        private System.Windows.Forms.Button btnCheckOut;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnReservar;
        private System.Windows.Forms.Button btnVoltar;
    }
}