namespace BarangKamuDelete
{
    partial class FormDelete
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            dataGridView1 = new DataGridView();
            NamaBarang = new DataGridViewTextBoxColumn();
            JumlahBarang = new DataGridViewTextBoxColumn();
            checkbox = new DataGridViewCheckBoxColumn();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            panel1 = new Panel();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(100, 23);
            label1.TabIndex = 5;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { NamaBarang, JumlahBarang, checkbox });
            dataGridView1.Location = new Point(199, 109);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(340, 185);
            dataGridView1.TabIndex = 1;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // NamaBarang
            // 
            NamaBarang.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            NamaBarang.HeaderText = "Nama Barang";
            NamaBarang.MinimumWidth = 6;
            NamaBarang.Name = "NamaBarang";
            // 
            // JumlahBarang
            // 
            JumlahBarang.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            JumlahBarang.HeaderText = "Jumlah Barang";
            JumlahBarang.MinimumWidth = 6;
            JumlahBarang.Name = "JumlahBarang";
            // 
            // checkbox
            // 
            checkbox.HeaderText = "check";
            checkbox.MinimumWidth = 6;
            checkbox.Name = "checkbox";
            checkbox.Width = 125;
            // 
            // button1
            // 
            button1.Location = new Point(199, 314);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 2;
            button1.Text = "Selesai";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(324, 314);
            button2.Name = "button2";
            button2.Size = new Size(94, 29);
            button2.TabIndex = 3;
            button2.Text = "Delete";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(445, 314);
            button3.Name = "button3";
            button3.Size = new Size(94, 29);
            button3.TabIndex = 4;
            button3.Text = "Delete all";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // panel1
            // 
            panel1.BackgroundImage = Properties.Resources._4m3nGAlz_wallha_com;
            panel1.BackgroundImageLayout = ImageLayout.Center;
            panel1.Location = new Point(168, 48);
            panel1.Name = "panel1";
            panel1.Size = new Size(404, 314);
            panel1.TabIndex = 5;
            panel1.Paint += panel1_Paint;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(dataGridView1);
            Controls.Add(label1);
            Controls.Add(panel1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private DataGridView dataGridView1;
        private Button button1;
        private Button button2;
        private Button button3;
        private Panel panel1;
        private DataGridViewTextBoxColumn NamaBarang;
        private DataGridViewTextBoxColumn JumlahBarang;
        private DataGridViewCheckBoxColumn checkbox;
    }
}