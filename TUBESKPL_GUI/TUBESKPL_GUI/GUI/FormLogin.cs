using BarangKamuAdd;
using BarangKamuGUI;
namespace TUBESKPL_GUI
{
    public partial class FormLogin : Form
    {
        private bool isMessageBoxShown = false; // variabel penanda
        private enum state
        {
            idle,
            usernameinput,
            Passwordinput,
            LoginSuccessful,
            LoginFailed
        }
        private state currentState;

        public FormLogin()
        {
            InitializeComponent();
            currentState = state.idle;

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            UsernameBox.KeyDown += UsernameBox_KeyDown;
            PasswordBox.KeyUp += PasswordBox_KeyUp;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void UsernameBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Masuk_Click(object sender, EventArgs e)
        {
            switch (currentState)
            {
                case state.idle:
                    if (!string.IsNullOrWhiteSpace(UsernameBox.Text))
                    {
                        currentState = state.usernameinput;
                        //MessageBox.Show("Masukkan Password", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Masukkan Username", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    break;

                case state.usernameinput:
                    if (!string.IsNullOrWhiteSpace(PasswordBox.Text))
                    {
                        currentState = state.Passwordinput;
                        //MessageBox.Show("tunggu sedang loading", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        PengecekanLogin();
                        FormHome barangKamu = new FormHome();
                        barangKamu.Show();
                        //this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Masukkan Password", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    break;
                default:
                    MessageBox.Show("invalid", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;
            }
        }


        private void PengecekanLogin()
        {
            string username = UsernameBox.Text;
            string password = PasswordBox.Text;

            if (username == "admin" && password == "admin")
            {
                currentState = state.LoginSuccessful;
                MessageBox.Show("Login Berhasil kamu akan diarahkan ke dashboard", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //method buat ke dashboard
            }
            else
            {
                currentState = state.LoginFailed;
                MessageBox.Show("Login gagal periksa lagi Username dan Password yang dimasukkan sudah benar", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void UsernameBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (!isMessageBoxShown) // cek penanda apakah MessageBox sudah muncul
                {
                    if (string.IsNullOrWhiteSpace(UsernameBox.Text) || string.IsNullOrWhiteSpace(PasswordBox.Text))
                    {
                        MessageBox.Show("Data tidak boleh kosong!");
                        isMessageBoxShown = true;
                        return;
                    }

                    e.Handled = true;
                    Masuk.PerformClick();
                }
            }
            else if (e.KeyCode == Keys.Down)
            {
                PasswordBox.Focus();
                e.Handled = true;
            }
        }

        private void PasswordBox_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (!isMessageBoxShown) // cek penanda apakah MessageBox sudah muncul
                {
                    if (string.IsNullOrWhiteSpace(UsernameBox.Text) || string.IsNullOrWhiteSpace(PasswordBox.Text))
                    {
                        MessageBox.Show("Data tidak boleh kosong!");
                        isMessageBoxShown = true;
                        return;
                    }

                    e.Handled = true;
                    Masuk.PerformClick();
                }
            }
            else if (e.KeyCode == Keys.Up)
            {
                UsernameBox.Focus();
                e.Handled = true;
            }
            else
            {
                isMessageBoxShown = false; // setelah MessageBox ditutup, mengatur penanda menjadi false
            }
        }

    }
}