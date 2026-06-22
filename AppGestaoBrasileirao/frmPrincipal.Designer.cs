namespace AppGestaoBrasileirao
{
    partial class frmPrincipal
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
            bandeiraPrincipal = new PictureBox();
            pictureBox2 = new PictureBox();
            textTelaPrincipal = new Label();
            textSistemaControleTimes = new Label();
            btnConsultar = new Button();
            btnAtualizar = new Button();
            ((System.ComponentModel.ISupportInitialize)bandeiraPrincipal).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // bandeiraPrincipal
            // 
            bandeiraPrincipal.BackColor = Color.AliceBlue;
            bandeiraPrincipal.Image = Properties.Resources.bandeiraBrasil;
            bandeiraPrincipal.Location = new Point(252, 102);
            bandeiraPrincipal.Name = "bandeiraPrincipal";
            bandeiraPrincipal.Size = new Size(453, 273);
            bandeiraPrincipal.SizeMode = PictureBoxSizeMode.StretchImage;
            bandeiraPrincipal.TabIndex = 0;
            bandeiraPrincipal.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.MediumBlue;
            pictureBox2.Location = new Point(0, -2);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(186, 456);
            pictureBox2.TabIndex = 1;
            pictureBox2.TabStop = false;
            // 
            // textTelaPrincipal
            // 
            textTelaPrincipal.AutoSize = true;
            textTelaPrincipal.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textTelaPrincipal.ForeColor = Color.MediumBlue;
            textTelaPrincipal.Location = new Point(405, 397);
            textTelaPrincipal.Name = "textTelaPrincipal";
            textTelaPrincipal.Size = new Size(167, 32);
            textTelaPrincipal.TabIndex = 2;
            textTelaPrincipal.Text = "Tela Principal";
            // 
            // textSistemaControleTimes
            // 
            textSistemaControleTimes.AutoSize = true;
            textSistemaControleTimes.BackColor = Color.Transparent;
            textSistemaControleTimes.FlatStyle = FlatStyle.Flat;
            textSistemaControleTimes.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textSistemaControleTimes.ForeColor = Color.MediumBlue;
            textSistemaControleTimes.Location = new Point(252, 29);
            textSistemaControleTimes.Name = "textSistemaControleTimes";
            textSistemaControleTimes.Size = new Size(464, 45);
            textSistemaControleTimes.TabIndex = 3;
            textSistemaControleTimes.Text = "Sistema de Controle de Times";
            // 
            // btnConsultar
            // 
            btnConsultar.BackColor = Color.Yellow;
            btnConsultar.FlatStyle = FlatStyle.Flat;
            btnConsultar.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnConsultar.ForeColor = Color.MediumBlue;
            btnConsultar.Location = new Point(32, 178);
            btnConsultar.Name = "btnConsultar";
            btnConsultar.Size = new Size(114, 50);
            btnConsultar.TabIndex = 4;
            btnConsultar.Text = "Consultar";
            btnConsultar.UseVisualStyleBackColor = false;
            // 
            // btnAtualizar
            // 
            btnAtualizar.BackColor = Color.Yellow;
            btnAtualizar.FlatStyle = FlatStyle.Flat;
            btnAtualizar.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAtualizar.ForeColor = Color.MediumBlue;
            btnAtualizar.Location = new Point(32, 234);
            btnAtualizar.Name = "btnAtualizar";
            btnAtualizar.Size = new Size(114, 47);
            btnAtualizar.TabIndex = 5;
            btnAtualizar.Text = "Atualizar";
            btnAtualizar.UseVisualStyleBackColor = false;
            // 
            // frmPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(800, 450);
            Controls.Add(btnAtualizar);
            Controls.Add(btnConsultar);
            Controls.Add(textSistemaControleTimes);
            Controls.Add(textTelaPrincipal);
            Controls.Add(pictureBox2);
            Controls.Add(bandeiraPrincipal);
            Name = "frmPrincipal";
            Text = "frmPrincipal";
            ((System.ComponentModel.ISupportInitialize)bandeiraPrincipal).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox bandeiraPrincipal;
        private PictureBox pictureBox2;
        private Label textTelaPrincipal;
        private Label textSistemaControleTimes;
        private Button btnConsultar;
        private Button btnAtualizar;
    }
}