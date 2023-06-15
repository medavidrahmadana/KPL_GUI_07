namespace BarangKamuGUI
{
    partial class FormHome
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
            tambah = new Button();
            update = new Button();
            delete = new Button();
            label3 = new Label();
            dataBarang = new DataGridView();
            panel1 = new Panel();
            ((System.ComponentModel.ISupportInitialize)dataBarang).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // tambah
            // 
            tambah.Location = new Point(152, 333);
            tambah.Margin = new Padding(5, 4, 5, 4);
            tambah.Name = "tambah";
            tambah.Size = new Size(101, 36);
            tambah.TabIndex = 4;
            tambah.Text = "Tambah";
            tambah.UseVisualStyleBackColor = true;
            tambah.Click += button1_Click;
            // 
            // update
            // 
            update.Location = new Point(259, 333);
            update.Margin = new Padding(5, 4, 5, 4);
            update.Name = "update";
            update.Size = new Size(101, 36);
            update.TabIndex = 5;
            update.Text = "Update";
            update.UseVisualStyleBackColor = true;
            update.Click += button2_Click;
            // 
            // delete
            // 
            delete.Location = new Point(368, 333);
            delete.Margin = new Padding(5, 4, 5, 4);
            delete.Name = "delete";
            delete.Size = new Size(101, 36);
            delete.TabIndex = 6;
            delete.Text = "Delete";
            delete.UseVisualStyleBackColor = true;
            delete.Click += button3_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = SystemColors.ActiveCaptionText;
            label3.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = SystemColors.ButtonFace;
            label3.Location = new Point(111, 25);
            label3.Margin = new Padding(5, 0, 5, 0);
            label3.Name = "label3";
            label3.Size = new Size(145, 29);
            label3.TabIndex = 11;
            label3.Text = "Data Barang";
            label3.Click += label3_Click;
            // 
            // dataBarang
            // 
            dataBarang.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataBarang.Location = new Point(167, 139);
            dataBarang.Margin = new Padding(5, 4, 5, 4);
            dataBarang.Name = "dataBarang";
            dataBarang.RowHeadersWidth = 51;
            dataBarang.Size = new Size(287, 172);
            dataBarang.TabIndex = 7;
            dataBarang.CellContentClick += dataBarang_CellContentClick;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveCaptionText;
            panel1.Controls.Add(label3);
            panel1.Location = new Point(137, 77);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(347, 341);
            panel1.TabIndex = 12;
            panel1.Paint += panel1_Paint;
            // 
            // FormHome
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(589, 556);
            Controls.Add(dataBarang);
            Controls.Add(delete);
            Controls.Add(update);
            Controls.Add(tambah);
            Controls.Add(panel1);
            Margin = new Padding(5, 4, 5, 4);
            Name = "FormHome";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dataBarang).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private System.Windows.Forms.Button tambah;
        private System.Windows.Forms.Button update;
        private System.Windows.Forms.Button delete;
        private System.Windows.Forms.Label label3;
        private DataGridViewTextBoxColumn JumlahBarang;
        private DataGridViewTextBoxColumn NamaBarang;
        private DataGridView dataBarang;
        private Panel panel1;
    }
}

