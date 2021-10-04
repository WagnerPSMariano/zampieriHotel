
namespace LoginHotel
{
    partial class FrmZamp
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
            this.lbIdentity = new System.Windows.Forms.Label();
            this.textId = new System.Windows.Forms.TextBox();
            this.textSenha = new System.Windows.Forms.TextBox();
            this.labelSenha = new System.Windows.Forms.Label();
            this.btnAcessar = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lbIdentity
            // 
            this.lbIdentity.AutoSize = true;
            this.lbIdentity.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbIdentity.Location = new System.Drawing.Point(27, 64);
            this.lbIdentity.Name = "lbIdentity";
            this.lbIdentity.Size = new System.Drawing.Size(21, 15);
            this.lbIdentity.TabIndex = 0;
            this.lbIdentity.Text = "ID";
            // 
            // textId
            // 
            this.textId.Location = new System.Drawing.Point(63, 61);
            this.textId.Name = "textId";
            this.textId.Size = new System.Drawing.Size(118, 20);
            this.textId.TabIndex = 1;
            // 
            // textSenha
            // 
            this.textSenha.Location = new System.Drawing.Point(63, 97);
            this.textSenha.Name = "textSenha";
            this.textSenha.Size = new System.Drawing.Size(118, 20);
            this.textSenha.TabIndex = 2;
            // 
            // labelSenha
            // 
            this.labelSenha.AutoSize = true;
            this.labelSenha.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSenha.Location = new System.Drawing.Point(12, 100);
            this.labelSenha.Name = "labelSenha";
            this.labelSenha.Size = new System.Drawing.Size(48, 15);
            this.labelSenha.TabIndex = 3;
            this.labelSenha.Text = "Senha";
            this.labelSenha.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnAcessar
            // 
            this.btnAcessar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAcessar.Location = new System.Drawing.Point(86, 134);
            this.btnAcessar.Name = "btnAcessar";
            this.btnAcessar.Size = new System.Drawing.Size(75, 23);
            this.btnAcessar.TabIndex = 4;
            this.btnAcessar.Text = "Acessar";
            this.btnAcessar.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::LoginHotel.Properties.Resources.Zampieri_logo_black_1;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(610, -1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(190, 118);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // FrmZamp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::LoginHotel.Properties.Resources.Av_Paulista__Paint_2;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnAcessar);
            this.Controls.Add(this.labelSenha);
            this.Controls.Add(this.textSenha);
            this.Controls.Add(this.textId);
            this.Controls.Add(this.lbIdentity);
            this.Name = "FrmZamp";
            this.Text = "Zampiere";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbIdentity;
        private System.Windows.Forms.TextBox textId;
        private System.Windows.Forms.TextBox textSenha;
        private System.Windows.Forms.Label labelSenha;
        private System.Windows.Forms.Button btnAcessar;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

