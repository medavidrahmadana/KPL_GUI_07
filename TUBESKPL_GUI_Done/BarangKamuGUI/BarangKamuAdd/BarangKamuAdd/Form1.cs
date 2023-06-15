namespace BarangKamuAdd
{
    public partial class Form1 : Form
    {
        private bool isMessageBoxShown = false; // variabel penanda
        public Form1()
        {
            InitializeComponent();
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
            // menerima inputan pada text box
            string inputnama = inputNama.Text;
            string inputjumlah = inputJumlah.Text;

            MessageBox.Show("Data berhasil ditambah!");
            isMessageBoxShown = true;

            // menambah data ke table data barang
            //dataBarang.Rows.Add(inputnama, inputjumlah);

            // menghapus isi text box
            inputNama.Text = "";
            inputJumlah.Text = "";
        }

        private void inputNama_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (!isMessageBoxShown) // cek penanda apakah MessageBox sudah muncul
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
                if (!isMessageBoxShown) // cek penanda apakah MessageBox sudah muncul
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
                isMessageBoxShown = false; // setelah MessageBox ditutup, mengatur penanda menjadi false
            }
        }
    }
}