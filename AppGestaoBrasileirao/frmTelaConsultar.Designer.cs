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
            pictureBox3 = new PictureBox();
            consultarTimes = new Label();
            textSerie = new Label();
            listView1 = new ListView();
            btnConsultar2 = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
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
            // pictureBox3
            // 
            pictureBox3.BackColor = SystemColors.ActiveBorder;
            pictureBox3.Location = new Point(222, 111);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(472, 227);
            pictureBox3.TabIndex = 4;
            pictureBox3.TabStop = false;
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
            // listView1
            // 
            listView1.BackColor = SystemColors.ActiveBorder;
            listView1.Location = new Point(32, 223);
            listView1.Name = "listView1";
            listView1.Size = new Size(108, 28);
            listView1.TabIndex = 8;
            listView1.UseCompatibleStateImageBehavior = false;
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
            // 
            // frmTelaConsultar
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(800, 450);
            Controls.Add(btnConsultar2);
            Controls.Add(listView1);
            Controls.Add(textSerie);
            Controls.Add(consultarTimes);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox1);
            Controls.Add(pictureBox2);
            Name = "frmTelaConsultar";
            Text = "frmTelaConsultar";
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox2;
        private PictureBox pictureBox1;
        private PictureBox pictureBox3;
        private Label consultarTimes;
        private Label textSerie;
        private ListView listView1;
        private Button btnConsultar2;
    }
}