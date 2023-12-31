using BarangKamuGUI;
using System.Data;
using static BarangKamuGUI.FormHome;

namespace BarangKamuAdd
{
    public partial class FormAdd : Form
    {
        private bool isMessageBoxShown = false;
        private DataBarangManager dataBarangManager;
        private FormHome formHome;

        public FormAdd(DataBarangManager dataBarangManager, FormHome formHome)
        {
            InitializeComponent();
            this.dataBarangManager = dataBarangManager;
            this.formHome = formHome;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            inputNama.KeyDown += inputNama_KeyDown;
            inputJumlah.KeyUp += inputJumlah_KeyUp;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string inputNamaValue = inputNama.Text.Trim();
            string inputJumlahValue = inputJumlah.Text.Trim();

            if (!string.IsNullOrWhiteSpace(inputNamaValue) && !string.IsNullOrWhiteSpace(inputJumlahValue))
            {
                if (IsNumeric(inputJumlahValue))
                {
                    formHome.saveInputAndData(inputNamaValue, int.Parse(inputJumlahValue));

                    MessageBox.Show("Data berhasil ditambah!");
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Jumlah barang harus angka!");
                }
            }
            else
            {
                MessageBox.Show("Mohon isi semua field input!");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void inputNama_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (!isMessageBoxShown)
                {
                    if (string.IsNullOrWhiteSpace(inputNama.Text) || string.IsNullOrWhiteSpace(inputJumlah.Text))
                    {
                        MessageBox.Show("Data tidak boleh kosong!");
                        isMessageBoxShown = true;
                        return;
                    }

                    e.Handled = true;
                    tambah.PerformClick();
                }
            }
            else if (e.KeyCode == Keys.Down)
            {
                inputJumlah.Focus();
                e.Handled = true;
            }
        }

        private void inputJumlah_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (!isMessageBoxShown)
                {
                    if (string.IsNullOrWhiteSpace(inputNama.Text) || string.IsNullOrWhiteSpace(inputJumlah.Text))
                    {
                        MessageBox.Show("Data tidak boleh kosong!");
                        isMessageBoxShown = true;
                        return;
                    }

                    e.Handled = true;
                    tambah.PerformClick();
                }
            }
            else if (e.KeyCode == Keys.Up)
            {
                inputNama.Focus();
                e.Handled = true;
            }
            else
            {
                isMessageBoxShown = false;
            }
        }

        private bool IsNumeric(string value)
        {
            return int.TryParse(value, out _);
        }
    }
}