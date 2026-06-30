namespace AppGestaoBrasileirao
{
    partial class frmTelaConsultar
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
            pictureBox2 = new PictureBox();
            pictureBox1 = new PictureBox();
            consultarTimes = new Label();
            textSerie = new Label();
            btnConsultar2 = new Button();
            cbSerie = new ComboBox();
            dgvConsultar = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvConsultar).BeginInit();
            SuspendLayout();
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.MediumBlue;
            pictureBox2.Location = new Point(-1, -2);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(186, 456);
            pictureBox2.TabIndex = 2;
            pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.jogador;
            pictureBox1.Location = new Point(505, -2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(295, 456);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // consultarTimes
            // 
            consultarTimes.AutoSize = true;
            consultarTimes.BackColor = Color.MediumBlue;
            consultarTimes.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            consultarTimes.ForeColor = Color.White;
            consultarTimes.Location = new Point(7, 6);
            consultarTimes.Name = "consultarTimes";
            consultarTimes.Size = new Size(170, 30);
            consultarTimes.TabIndex = 5;
            consultarTimes.Text = "Consultar Times";
            consultarTimes.TextAlign = ContentAlignment.BottomCenter;
            // 
            // textSerie
            // 
            textSerie.AutoSize = true;
            textSerie.BackColor = Color.MediumBlue;
            textSerie.ForeColor = Color.White;
            textSerie.Location = new Point(32, 205);
            textSerie.Name = "textSerie";
            textSerie.Size = new Size(35, 15);
            textSerie.TabIndex = 6;
            textSerie.Text = "Série:";
            // 
            // btnConsultar2
            // 
            btnConsultar2.BackColor = Color.GreenYellow;
            btnConsultar2.FlatStyle = FlatStyle.Flat;
            btnConsultar2.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnConsultar2.ForeColor = Color.MediumBlue;
            btnConsultar2.Location = new Point(32, 279);
            btnConsultar2.Name = "btnConsultar2";
            btnConsultar2.Size = new Size(108, 59);
            btnConsultar2.TabIndex = 9;
            btnConsultar2.Text = "Consultar";
            btnConsultar2.UseVisualStyleBackColor = false;
            btnConsultar2.Click += btnConsultar2_Click;
            // 
            // cbSerie
            // 
            cbSerie.DropDownStyle = ComboBoxStyle.DropDownList;
            cbSerie.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cbSerie.FormattingEnabled = true;
            cbSerie.Items.AddRange(new object[] { "Selecione uma série...", "A", "B", "C", "D" });
            cbSerie.Location = new Point(12, 233);
            cbSerie.Name = "cbSerie";
            cbSerie.Size = new Size(165, 26);
            cbSerie.TabIndex = 10;
            // 
            // dgvConsultar
            // 
            dgvConsultar.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvConsultar.Location = new Point(219, 137);
            dgvConsultar.Name = "dgvConsultar";
            dgvConsultar.Size = new Size(519, 259);
            dgvConsultar.TabIndex = 11;
            // 
            // frmTelaConsultar
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(800, 450);
            Controls.Add(dgvConsultar);
            Controls.Add(cbSerie);
            Controls.Add(btnConsultar2);
            Controls.Add(textSerie);
            Controls.Add(consultarTimes);
            Controls.Add(pictureBox1);
            Controls.Add(pictureBox2);
            Name = "frmTelaConsultar";
            Text = "frmTelaConsultar";
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvConsultar).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox2;
        private PictureBox pictureBox1;
        private Label consultarTimes;
        private Label textSerie;
        private Button btnConsultar2;
        private ComboBox cbSerie;
        private DataGridView dgvConsultar;
    }
}