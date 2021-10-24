
namespace LoginHotel
{
    partial class FormDashboard
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
            this.pictureLogo = new System.Windows.Forms.PictureBox();
            this.btnCliente = new System.Windows.Forms.Button();
            this.btnFuncionario = new System.Windows.Forms.Button();
            this.btnQuarto = new System.Windows.Forms.Button();
            this.btnRelatorio = new System.Windows.Forms.Button();
            this.btnConsultarCliente = new System.Windows.Forms.Button();
            this.btnConsultarFuncionario = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureLogo
            // 
            this.pictureLogo.BackgroundImage = global::LoginHotel.Properties.Resources.Zampieri_logo_black_1;
            this.pictureLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureLogo.Location = new System.Drawing.Point(453, 1);
            this.pictureLogo.Name = "pictureLogo";
            this.pictureLogo.Size = new System.Drawing.Size(139, 51);
            this.pictureLogo.TabIndex = 0;
            this.pictureLogo.TabStop = false;
            // 
            // btnCliente
            // 
            this.btnCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCliente.Location = new System.Drawing.Point(85, 125);
            this.btnCliente.Name = "btnCliente";
            this.btnCliente.Size = new System.Drawing.Size(117, 56);
            this.btnCliente.TabIndex = 1;
            this.btnCliente.Text = "Cadastrar Cliente";
            this.btnCliente.UseVisualStyleBackColor = true;
            // 
            // btnFuncionario
            // 
            this.btnFuncionario.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFuncionario.Location = new System.Drawing.Point(238, 125);
            this.btnFuncionario.Name = "btnFuncionario";
            this.btnFuncionario.Size = new System.Drawing.Size(117, 56);
            this.btnFuncionario.TabIndex = 2;
            this.btnFuncionario.Text = "Cadastrar Funcionário";
            this.btnFuncionario.UseVisualStyleBackColor = true;
            // 
            // btnQuarto
            // 
            this.btnQuarto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuarto.Location = new System.Drawing.Point(379, 125);
            this.btnQuarto.Name = "btnQuarto";
            this.btnQuarto.Size = new System.Drawing.Size(117, 56);
            this.btnQuarto.TabIndex = 3;
            this.btnQuarto.Text = "Reservar Quarto";
            this.btnQuarto.UseVisualStyleBackColor = true;
            // 
            // btnRelatorio
            // 
            this.btnRelatorio.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRelatorio.Location = new System.Drawing.Point(379, 203);
            this.btnRelatorio.Name = "btnRelatorio";
            this.btnRelatorio.Size = new System.Drawing.Size(117, 56);
            this.btnRelatorio.TabIndex = 4;
            this.btnRelatorio.Text = "Relatórios";
            this.btnRelatorio.UseVisualStyleBackColor = true;
            // 
            // btnConsultarCliente
            // 
            this.btnConsultarCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConsultarCliente.Location = new System.Drawing.Point(85, 203);
            this.btnConsultarCliente.Name = "btnConsultarCliente";
            this.btnConsultarCliente.Size = new System.Drawing.Size(117, 56);
            this.btnConsultarCliente.TabIndex = 5;
            this.btnConsultarCliente.Text = "Consultar Cliente";
            this.btnConsultarCliente.UseVisualStyleBackColor = true;
            // 
            // btnConsultarFuncionario
            // 
            this.btnConsultarFuncionario.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConsultarFuncionario.Location = new System.Drawing.Point(238, 203);
            this.btnConsultarFuncionario.Name = "btnConsultarFuncionario";
            this.btnConsultarFuncionario.Size = new System.Drawing.Size(117, 56);
            this.btnConsultarFuncionario.TabIndex = 6;
            this.btnConsultarFuncionario.Text = "Consultar Funcionário";
            this.btnConsultarFuncionario.UseVisualStyleBackColor = true;
            // 
            // FormDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(594, 395);
            this.Controls.Add(this.btnConsultarFuncionario);
            this.Controls.Add(this.btnConsultarCliente);
            this.Controls.Add(this.btnRelatorio);
            this.Controls.Add(this.btnQuarto);
            this.Controls.Add(this.btnFuncionario);
            this.Controls.Add(this.btnCliente);
            this.Controls.Add(this.pictureLogo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FormDashboard";
            this.Text = "Dashboard";
            ((System.ComponentModel.ISupportInitialize)(this.pictureLogo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureLogo;
        private System.Windows.Forms.Button btnCliente;
        private System.Windows.Forms.Button btnFuncionario;
        private System.Windows.Forms.Button btnQuarto;
        private System.Windows.Forms.Button btnRelatorio;
        private System.Windows.Forms.Button btnConsultarCliente;
        private System.Windows.Forms.Button btnConsultarFuncionario;
    }
}