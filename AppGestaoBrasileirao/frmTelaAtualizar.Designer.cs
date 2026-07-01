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
            textSerie2 = new Label();
            dgvAtualizar = new DataGridView();
            cbSerieAtt = new ComboBox();
            pictureBox3 = new PictureBox();
            btnInserir = new Button();
            btnAtualizar = new Button();
            btnApagar = new Button();
            lblNomeTime = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            textBox5 = new TextBox();
            textBox6 = new TextBox();
            textBox7 = new TextBox();
            textBox8 = new TextBox();
            this.lblNomeTime2 = new Label();
            this.lblNomeTime3 = new Label();
            this.lblNomeTime4 = new Label();
            this.lblNomeTime5 = new Label();
            this.lblNomeTime6 = new Label();
            lblNomeTime7 = new Label();
            lblNomeTime8 = new Label();
            lblNomeTime9 = new Label();
            lblPosicao = new Label();
            rtbNomeTime = new RichTextBox();
            rtbPosicao = new RichTextBox();
            dataGridView1 = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvAtualizar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.escudoCBF;
            pictureBox1.Location = new Point(142, -59);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(910, 512);
            pictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.MediumBlue;
            pictureBox2.Location = new Point(-1, -3);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(172, 456);
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
            // textSerie2
            // 
            textSerie2.AutoSize = true;
            textSerie2.BackColor = Color.MediumBlue;
            textSerie2.ForeColor = Color.White;
            textSerie2.Location = new Point(24, 112);
            textSerie2.Name = "textSerie2";
            textSerie2.Size = new Size(35, 15);
            textSerie2.TabIndex = 9;
            textSerie2.Text = "Série:";
            // 
            // dgvAtualizar
            // 
            dgvAtualizar.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvAtualizar.Location = new Point(193, 261);
            dgvAtualizar.Name = "dgvAtualizar";
            dgvAtualizar.Size = new Size(578, 132);
            dgvAtualizar.TabIndex = 14;
            // 
            // cbSerieAtt
            // 
            cbSerieAtt.DropDownStyle = ComboBoxStyle.DropDownList;
            cbSerieAtt.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cbSerieAtt.FormattingEnabled = true;
            cbSerieAtt.Items.AddRange(new object[] { "Selecione uma série...", "A", "B", "C", "D" });
            cbSerieAtt.Location = new Point(24, 130);
            cbSerieAtt.Name = "cbSerieAtt";
            cbSerieAtt.Size = new Size(98, 26);
            cbSerieAtt.TabIndex = 15;
            // 
            // pictureBox3
            // 
            pictureBox3.BackColor = Color.White;
            pictureBox3.Location = new Point(142, 378);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(660, 75);
            pictureBox3.TabIndex = 16;
            pictureBox3.TabStop = false;
            // 
            // btnInserir
            // 
            btnInserir.BackColor = Color.SpringGreen;
            btnInserir.FlatStyle = FlatStyle.Flat;
            btnInserir.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnInserir.ForeColor = Color.MediumBlue;
            btnInserir.Location = new Point(24, 180);
            btnInserir.Name = "btnInserir";
            btnInserir.Size = new Size(98, 49);
            btnInserir.TabIndex = 17;
            btnInserir.Text = "Inserir";
            btnInserir.UseVisualStyleBackColor = false;
            // 
            // btnAtualizar
            // 
            btnAtualizar.BackColor = Color.DeepSkyBlue;
            btnAtualizar.FlatStyle = FlatStyle.Flat;
            btnAtualizar.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAtualizar.ForeColor = Color.MediumBlue;
            btnAtualizar.Location = new Point(24, 248);
            btnAtualizar.Name = "btnAtualizar";
            btnAtualizar.Size = new Size(98, 48);
            btnAtualizar.TabIndex = 18;
            btnAtualizar.Text = "Atualizar";
            btnAtualizar.UseVisualStyleBackColor = false;
            // 
            // btnApagar
            // 
            btnApagar.BackColor = Color.Red;
            btnApagar.FlatStyle = FlatStyle.Flat;
            btnApagar.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnApagar.ForeColor = Color.MediumBlue;
            btnApagar.Location = new Point(24, 315);
            btnApagar.Name = "btnApagar";
            btnApagar.Size = new Size(98, 52);
            btnApagar.TabIndex = 19;
            btnApagar.Text = "Apagar";
            btnApagar.UseVisualStyleBackColor = false;
            // 
            // lblNomeTime
            // 
            lblNomeTime.AutoSize = true;
            lblNomeTime.BackColor = Color.RoyalBlue;
            lblNomeTime.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblNomeTime.ForeColor = Color.White;
            lblNomeTime.Location = new Point(193, 9);
            lblNomeTime.Name = "lblNomeTime";
            lblNomeTime.Size = new Size(92, 15);
            lblNomeTime.TabIndex = 20;
            lblNomeTime.Text = "Nome do Time:";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(193, 37);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(258, 23);
            textBox1.TabIndex = 28;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(513, 37);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(258, 23);
            textBox2.TabIndex = 29;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(193, 231);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(258, 23);
            textBox3.TabIndex = 30;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(513, 231);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(258, 23);
            textBox4.TabIndex = 31;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(513, 167);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(258, 23);
            textBox5.TabIndex = 32;
            // 
            // textBox6
            // 
            textBox6.Location = new Point(513, 104);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(258, 23);
            textBox6.TabIndex = 33;
            // 
            // textBox7
            // 
            textBox7.Location = new Point(193, 167);
            textBox7.Name = "textBox7";
            textBox7.Size = new Size(258, 23);
            textBox7.TabIndex = 34;
            // 
            // textBox8
            // 
            textBox8.Location = new Point(193, 104);
            textBox8.Name = "textBox8";
            textBox8.Size = new Size(258, 23);
            textBox8.TabIndex = 35;
            // 
            // lblNomeTime2
            // 
            this.lblNomeTime2.AutoSize = true;
            this.lblNomeTime2.BackColor = Color.RoyalBlue;
            this.lblNomeTime2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            this.lblNomeTime2.ForeColor = Color.White;
            this.lblNomeTime2.Location = new Point(193, 77);
            this.lblNomeTime2.Name = "lblNomeTime2";
            this.lblNomeTime2.Size = new Size(92, 15);
            this.lblNomeTime2.TabIndex = 36;
            this.lblNomeTime2.Text = "Nome do Time:";
            // 
            // lblNomeTime3
            // 
            this.lblNomeTime3.AutoSize = true;
            this.lblNomeTime3.BackColor = Color.RoyalBlue;
            this.lblNomeTime3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            this.lblNomeTime3.ForeColor = Color.White;
            this.lblNomeTime3.Location = new Point(193, 141);
            this.lblNomeTime3.Name = "lblNomeTime3";
            this.lblNomeTime3.Size = new Size(92, 15);
            this.lblNomeTime3.TabIndex = 37;
            this.lblNomeTime3.Text = "Nome do Time:";
            // 
            // lblNomeTime4
            // 
            this.lblNomeTime4.AutoSize = true;
            this.lblNomeTime4.BackColor = Color.RoyalBlue;
            this.lblNomeTime4.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            this.lblNomeTime4.ForeColor = Color.White;
            this.lblNomeTime4.Location = new Point(193, 199);
            this.lblNomeTime4.Name = "lblNomeTime4";
            this.lblNomeTime4.Size = new Size(92, 15);
            this.lblNomeTime4.TabIndex = 38;
            this.lblNomeTime4.Text = "Nome do Time:";
            // 
            // lblNomeTime5
            // 
            this.lblNomeTime5.AutoSize = true;
            this.lblNomeTime5.BackColor = Color.RoyalBlue;
            this.lblNomeTime5.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            this.lblNomeTime5.ForeColor = Color.White;
            this.lblNomeTime5.Location = new Point(513, 9);
            this.lblNomeTime5.Name = "lblNomeTime5";
            this.lblNomeTime5.Size = new Size(92, 15);
            this.lblNomeTime5.TabIndex = 39;
            this.lblNomeTime5.Text = "Nome do Time:";
            // 
            // lblNomeTime6
            // 
            this.lblNomeTime6.AutoSize = true;
            this.lblNomeTime6.BackColor = Color.RoyalBlue;
            this.lblNomeTime6.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            this.lblNomeTime6.ForeColor = Color.White;
            this.lblNomeTime6.Location = new Point(513, 77);
            this.lblNomeTime6.Name = "lblNomeTime6";
            this.lblNomeTime6.Size = new Size(92, 15);
            this.lblNomeTime6.TabIndex = 40;
            this.lblNomeTime6.Text = "Nome do Time:";
            // 
            // lblNomeTime7
            // 
            lblNomeTime7.AutoSize = true;
            lblNomeTime7.BackColor = Color.RoyalBlue;
            lblNomeTime7.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblNomeTime7.ForeColor = Color.White;
            lblNomeTime7.Location = new Point(513, 141);
            lblNomeTime7.Name = "lblNomeTime7";
            lblNomeTime7.Size = new Size(92, 15);
            lblNomeTime7.TabIndex = 41;
            lblNomeTime7.Text = "Nome do Time:";
            // 
            // lblNomeTime8
            // 
            lblNomeTime8.AutoSize = true;
            lblNomeTime8.BackColor = Color.RoyalBlue;
            lblNomeTime8.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblNomeTime8.ForeColor = Color.White;
            lblNomeTime8.Location = new Point(513, 199);
            lblNomeTime8.Name = "lblNomeTime8";
            lblNomeTime8.Size = new Size(92, 15);
            lblNomeTime8.TabIndex = 42;
            lblNomeTime8.Text = "Nome do Time:";
            // 
            // lblNomeTime9
            // 
            lblNomeTime9.AutoSize = true;
            lblNomeTime9.BackColor = Color.White;
            lblNomeTime9.Location = new Point(203, 412);
            lblNomeTime9.Name = "lblNomeTime9";
            lblNomeTime9.Size = new Size(90, 15);
            lblNomeTime9.TabIndex = 43;
            lblNomeTime9.Text = "Nome do Time:";
            // 
            // lblPosicao
            // 
            lblPosicao.AutoSize = true;
            lblPosicao.BackColor = Color.White;
            lblPosicao.Location = new Point(351, 414);
            lblPosicao.Name = "lblPosicao";
            lblPosicao.Size = new Size(48, 15);
            lblPosicao.TabIndex = 44;
            lblPosicao.Text = "Posição";
            // 
            // rtbNomeTime
            // 
            rtbNomeTime.BorderStyle = BorderStyle.FixedSingle;
            rtbNomeTime.Location = new Point(177, 411);
            rtbNomeTime.Name = "rtbNomeTime";
            rtbNomeTime.Size = new Size(20, 16);
            rtbNomeTime.TabIndex = 45;
            rtbNomeTime.Text = "";
            // 
            // rtbPosicao
            // 
            rtbPosicao.BorderStyle = BorderStyle.FixedSingle;
            rtbPosicao.Location = new Point(325, 414);
            rtbPosicao.Name = "rtbPosicao";
            rtbPosicao.Size = new Size(20, 16);
            rtbPosicao.TabIndex = 46;
            rtbPosicao.Text = "";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(531, 401);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(240, 29);
            dataGridView1.TabIndex = 47;
            // 
            // frmTelaAtualizar
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dataGridView1);
            Controls.Add(rtbPosicao);
            Controls.Add(rtbNomeTime);
            Controls.Add(lblPosicao);
            Controls.Add(lblNomeTime9);
            Controls.Add(lblNomeTime8);
            Controls.Add(lblNomeTime7);
            Controls.Add(this.lblNomeTime6);
            Controls.Add(this.lblNomeTime5);
            Controls.Add(this.lblNomeTime4);
            Controls.Add(this.lblNomeTime3);
            Controls.Add(this.lblNomeTime2);
            Controls.Add(textBox8);
            Controls.Add(textBox7);
            Controls.Add(textBox6);
            Controls.Add(textBox5);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(lblNomeTime);
            Controls.Add(btnApagar);
            Controls.Add(btnAtualizar);
            Controls.Add(btnInserir);
            Controls.Add(dgvAtualizar);
            Controls.Add(cbSerieAtt);
            Controls.Add(textSerie2);
            Controls.Add(btnAtualizarTimes);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox1);
            Name = "frmTelaAtualizar";
            Text = "frmTelaConsultar";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvAtualizar).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private Label btnAtualizarTimes;
        private Label textSerie2;
        private DataGridView dgvAtualizar;
        private ComboBox cbSerieAtt;
        private PictureBox pictureBox3;
        private Button btnInserir;
        private Button btnAtualizar;
        private Button btnApagar;
        private Label lblNomeTime;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private TextBox textBox5;
        private TextBox textBox6;
        private TextBox textBox7;
        private TextBox textBox8;
        private Label label8;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label lblNomeTime7;
        private Label lblNomeTime8;
        private Label lblNomeTime9;
        private Label lblPosicao;
        private RichTextBox rtbNomeTime;
        private RichTextBox rtbPosicao;
        private DataGridView dataGridView1;
    }
}