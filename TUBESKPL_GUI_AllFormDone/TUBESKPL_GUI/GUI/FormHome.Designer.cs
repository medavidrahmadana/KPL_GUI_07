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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormHome));
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
            tambah.Location = new Point(177, 243);
            tambah.Margin = new Padding(4, 3, 4, 3);
            tambah.Name = "tambah";
            tambah.Size = new Size(88, 27);
            tambah.TabIndex = 4;
            tambah.Text = "Tambah";
            tambah.UseVisualStyleBackColor = true;
            tambah.Click += button1_Click;
            // 
            // update
            // 
            update.Location = new Point(271, 243);
            update.Margin = new Padding(4, 3, 4, 3);
            update.Name = "update";
            update.Size = new Size(88, 27);
            update.TabIndex = 5;
            update.Text = "Update";
            update.UseVisualStyleBackColor = true;
            update.Click += button2_Click;
            // 
            // delete
            // 
            delete.Location = new Point(366, 243);
            delete.Margin = new Padding(4, 3, 4, 3);
            delete.Name = "delete";
            delete.Size = new Size(88, 27);
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
            label3.Location = new Point(97, 19);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(112, 24);
            label3.TabIndex = 11;
            label3.Text = "Data Barang";
            label3.Click += label3_Click;
            // 
            // dataBarang
            // 
            dataBarang.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataBarang.Location = new Point(190, 97);
            dataBarang.Margin = new Padding(4, 3, 4, 3);
            dataBarang.Name = "dataBarang";
            dataBarang.Size = new Size(251, 129);
            dataBarang.TabIndex = 7;
            dataBarang.CellContentClick += dataBarang_CellContentClick;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveCaptionText;
            panel1.Controls.Add(label3);
            panel1.Location = new Point(164, 51);
            panel1.Name = "panel1";
            panel1.Size = new Size(304, 256);
            panel1.TabIndex = 12;
            // 
            // FormHome
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(683, 364);
            Controls.Add(dataBarang);
            Controls.Add(delete);
            Controls.Add(update);
            Controls.Add(tambah);
            Controls.Add(panel1);
            Margin = new Padding(4, 3, 4, 3);
            Name = "FormHome";
            Text = "Form Home";
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

