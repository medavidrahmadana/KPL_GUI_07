namespace TUBESKPL_GUI
{
    public partial class Form1 : Form
    {
        private enum state
        {
            idle,
            usernameinput,
            Passwordinput,
            LoginSuccessful,
            LoginFailed
        }
        private state currentState;

        public Form1()
        {
            InitializeComponent();
            currentState = state.idle;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

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


    }
}