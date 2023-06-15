namespace TUBESKPL_GUI
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
            panel1 = new Panel();
            Masuk = new Button();
            PasswordBox = new TextBox();
            Password = new Label();
            UsernameBox = new TextBox();
            Username = new Label();
            label1 = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(Masuk);
            panel1.Controls.Add(PasswordBox);
            panel1.Controls.Add(Password);
            panel1.Controls.Add(UsernameBox);
            panel1.Controls.Add(Username);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(168, 88);
            panel1.Name = "panel1";
            panel1.Size = new Size(279, 263);
            panel1.TabIndex = 0;
            // 
            // Masuk
            // 
            Masuk.Location = new Point(94, 210);
            Masuk.Name = "Masuk";
            Masuk.Size = new Size(94, 29);
            Masuk.TabIndex = 5;
            Masuk.Text = "Masuk";
            Masuk.UseVisualStyleBackColor = true;
            Masuk.Click += Masuk_Click;
            // 
            // PasswordBox
            // 
            PasswordBox.BackColor = SystemColors.InfoText;
            PasswordBox.ForeColor = SystemColors.Window;
            PasswordBox.Location = new Point(25, 162);
            PasswordBox.Name = "PasswordBox";
            PasswordBox.Size = new Size(234, 27);
            PasswordBox.TabIndex = 4;
            PasswordBox.TextChanged += textBox1_TextChanged;
            // 
            // Password
            // 
            Password.AutoSize = true;
            Password.ForeColor = SystemColors.ButtonHighlight;
            Password.Location = new Point(21, 141);
            Password.Name = "Password";
            Password.Size = new Size(70, 20);
            Password.TabIndex = 3;
            Password.Text = "Password";
            // 
            // UsernameBox
            // 
            UsernameBox.BackColor = SystemColors.MenuText;
            UsernameBox.ForeColor = SystemColors.Menu;
            UsernameBox.Location = new Point(25, 98);
            UsernameBox.Name = "UsernameBox";
            UsernameBox.Size = new Size(234, 27);
            UsernameBox.TabIndex = 2;
            UsernameBox.TextChanged += UsernameBox_TextChanged;
            // 
            // Username
            // 
            Username.AutoSize = true;
            Username.ForeColor = SystemColors.ButtonHighlight;
            Username.Location = new Point(22, 75);
            Username.Name = "Username";
            Username.Size = new Size(75, 20);
            Username.TabIndex = 1;
            Username.Text = "Username";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Cooper Black", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(22, 29);
            label1.Name = "label1";
            label1.Size = new Size(237, 23);
            label1.TabIndex = 0;
            label1.Text = "Halo Selamat Datang!!!";
            label1.Click += label1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(611, 375);
            Controls.Add(panel1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Button Masuk;
        private TextBox PasswordBox;
        private Label Password;
        private TextBox UsernameBox;
        private Label Username;
    }
}