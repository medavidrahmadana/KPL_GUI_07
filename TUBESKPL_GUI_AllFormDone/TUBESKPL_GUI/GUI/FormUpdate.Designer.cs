namespace BarangKamuUpdate
{
    partial class FormUpdate
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
            panel1 = new Panel();
            dataGridView1 = new DataGridView();
            NamaBarang = new DataGridViewTextBoxColumn();
            JumlahBarang = new DataGridViewTextBoxColumn();
            back = new Button();
            edit = new Button();
            inputJumlah = new TextBox();
            inputNama = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveCaptionText;
            panel1.Controls.Add(dataGridView1);
            panel1.Controls.Add(back);
            panel1.Controls.Add(edit);
            panel1.Controls.Add(inputJumlah);
            panel1.Controls.Add(inputNama);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(67, 39);
            panel1.Name = "panel1";
            panel1.Size = new Size(367, 354);
            panel1.TabIndex = 2;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { NamaBarang, JumlahBarang });
            dataGridView1.Location = new Point(47, 48);
            dataGridView1.Margin = new Padding(3, 2, 3, 2);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(277, 139);
            dataGridView1.TabIndex = 7;
            dataGridView1.CellClick += new DataGridViewCellEventHandler(dataGridView1_CellClick);

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
            // back
            // 
            back.Font = new Font("Cambria", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            back.Location = new Point(11, 11);
            back.Name = "back";
            back.Size = new Size(15, 20);
            back.TabIndex = 6;
            back.Text = "<";
            back.UseVisualStyleBackColor = true;
            back.Click += back_Click;
            // 
            // edit
            // 
            edit.Location = new Point(146, 306);
            edit.Name = "edit";
            edit.Size = new Size(75, 23);
            edit.TabIndex = 5;
            edit.Text = "Update";
            edit.UseVisualStyleBackColor = true;
            edit.Click += edit_Click;
            // 
            // inputJumlah
            // 
            inputJumlah.BackColor = SystemColors.InactiveCaptionText;
            inputJumlah.Font = new Font("Cambria", 9F, FontStyle.Regular, GraphicsUnit.Point);
            inputJumlah.ForeColor = SystemColors.Window;
            inputJumlah.Location = new Point(95, 267);
            inputJumlah.Name = "inputJumlah";
            inputJumlah.Size = new Size(173, 22);
            inputJumlah.TabIndex = 4;
            // 
            // inputNama
            // 
            inputNama.BackColor = SystemColors.InactiveCaptionText;
            inputNama.Font = new Font("Cambria", 9F, FontStyle.Regular, GraphicsUnit.Point);
            inputNama.ForeColor = SystemColors.Window;
            inputNama.Location = new Point(95, 222);
            inputNama.Name = "inputNama";
            inputNama.Size = new Size(173, 22);
            inputNama.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Cambria", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = SystemColors.ButtonHighlight;
            label3.Location = new Point(95, 250);
            label3.Name = "label3";
            label3.Size = new Size(84, 14);
            label3.TabIndex = 2;
            label3.Text = "Jumlah Barang";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Cambria", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.ButtonHighlight;
            label2.Location = new Point(95, 202);
            label2.Name = "label2";
            label2.Size = new Size(77, 14);
            label2.TabIndex = 1;
            label2.Text = "Nama Barang";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Cambria", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(128, 14);
            label1.Name = "label1";
            label1.Size = new Size(105, 17);
            label1.TabIndex = 0;
            label1.Text = "UPDATE DATA";
            label1.Click += label1_Click;
            // 
            // FormUpdate
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(515, 455);
            Controls.Add(panel1);
            Name = "FormUpdate";
            Text = "Form1";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button back;
        private Button edit;
        private TextBox inputJumlah;
        private TextBox inputNama;
        private Label label3;
        private Label label2;
        private Label label1;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn NamaBarang;
        private DataGridViewTextBoxColumn JumlahBarang;
    }
}