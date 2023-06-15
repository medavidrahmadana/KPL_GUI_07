namespace BarangKamuAdd
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            label1 = new Label();
            panel1 = new Panel();
            back = new Button();
            tambah = new Button();
            inputJumlah = new TextBox();
            inputNama = new TextBox();
            label3 = new Label();
            label2 = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Cambria", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(82, 16);
            label1.Name = "label1";
            label1.Size = new Size(80, 17);
            label1.TabIndex = 0;
            label1.Text = "ADD DATA";
            label1.Click += label1_Click;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveCaptionText;
            panel1.Controls.Add(back);
            panel1.Controls.Add(tambah);
            panel1.Controls.Add(inputJumlah);
            panel1.Controls.Add(inputNama);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(149, 46);
            panel1.Name = "panel1";
            panel1.Size = new Size(244, 197);
            panel1.TabIndex = 1;
            panel1.Paint += panel1_Paint;
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
            // 
            // tambah
            // 
            tambah.Location = new Point(87, 157);
            tambah.Name = "tambah";
            tambah.Size = new Size(75, 23);
            tambah.TabIndex = 5;
            tambah.Text = "Tambah";
            tambah.UseVisualStyleBackColor = true;
            tambah.Click += button1_Click;
            // 
            // inputJumlah
            // 
            inputJumlah.BackColor = SystemColors.InactiveCaptionText;
            inputJumlah.Font = new Font("Cambria", 9F, FontStyle.Regular, GraphicsUnit.Point);
            inputJumlah.ForeColor = SystemColors.Window;
            inputJumlah.Location = new Point(36, 118);
            inputJumlah.Name = "inputJumlah";
            inputJumlah.Size = new Size(173, 22);
            inputJumlah.TabIndex = 4;
            inputJumlah.KeyUp += inputJumlah_KeyUp;
            // 
            // inputNama
            // 
            inputNama.BackColor = SystemColors.InactiveCaptionText;
            inputNama.Font = new Font("Cambria", 9F, FontStyle.Regular, GraphicsUnit.Point);
            inputNama.ForeColor = SystemColors.Window;
            inputNama.Location = new Point(36, 73);
            inputNama.Name = "inputNama";
            inputNama.Size = new Size(173, 22);
            inputNama.TabIndex = 3;
            inputNama.KeyDown += inputNama_KeyDown;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Cambria", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = SystemColors.ButtonHighlight;
            label3.Location = new Point(36, 101);
            label3.Name = "label3";
            label3.Size = new Size(84, 14);
            label3.TabIndex = 2;
            label3.Text = "Jumlah Barang";
            label3.Click += label3_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Cambria", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.ButtonHighlight;
            label2.Location = new Point(36, 53);
            label2.Name = "label2";
            label2.Size = new Size(77, 14);
            label2.TabIndex = 1;
            label2.Text = "Nama Barang";
            label2.Click += label2_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(535, 281);
            Controls.Add(panel1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private Panel panel1;
        private Label label2;
        private Label label3;
        private Button button2;
        private Button tambah;
        private TextBox inputJumlah;
        private TextBox inputNama;
        private Button back;
    }
}