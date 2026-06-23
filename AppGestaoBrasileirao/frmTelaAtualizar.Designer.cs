namespace AppGestaoBrasileirao
{
    partial class frmTelaAtualizar
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
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            btnAtualizarTimes = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.escudoCBF;
            pictureBox1.Location = new Point(182, -37);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(625, 490);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.MediumBlue;
            pictureBox2.Location = new Point(-1, -3);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(186, 456);
            pictureBox2.TabIndex = 3;
            pictureBox2.TabStop = false;
            // 
            // btnAtualizarTimes
            // 
            btnAtualizarTimes.AllowDrop = true;
            btnAtualizarTimes.AutoSize = true;
            btnAtualizarTimes.BackColor = Color.MediumBlue;
            btnAtualizarTimes.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAtualizarTimes.ForeColor = Color.White;
            btnAtualizarTimes.Location = new Point(7, 5);
            btnAtualizarTimes.Name = "btnAtualizarTimes";
            btnAtualizarTimes.Size = new Size(164, 30);
            btnAtualizarTimes.TabIndex = 4;
            btnAtualizarTimes.Text = "Atualizar Times";
            // 
            // frmTelaAtualizar
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnAtualizarTimes);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Name = "frmTelaAtualizar";
            Text = "frmTelaConsultar";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private Label btnAtualizarTimes;
    }
}