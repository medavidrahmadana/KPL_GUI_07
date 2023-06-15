using BarangKamuGUI;
using Newtonsoft.Json;
using System.Data;
using System.IO;
using System.Windows.Forms;
using static BarangKamuGUI.FormHome;

namespace BarangKamuUpdate
{
    public partial class FormUpdate : Form
    {
        private bool isMessageBoxShown = false; // variabel penanda
        private DataBarangManager dataBarangManager;
        private string filePath;
        private FormHome formHome;

        public FormUpdate(DataBarangManager dataBarangManager, FormHome formHome)
        {
            InitializeComponent();
            this.dataBarangManager = dataBarangManager;
            this.formHome = formHome;
            filePath = "data.json";
            LoadData();
        }

        private void FormUpdate_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void LoadData()
        {
            if (File.Exists(filePath))
            {
                string jsonData = File.ReadAllText(filePath);
                dataBarangManager.DataBarang = JsonConvert.DeserializeObject<DataTable>(jsonData);
                dataGridView1.DataSource = dataBarangManager.DataBarang;
            }
        }

        private void SaveData()
        {
            try
            {
                // Menyimpan data dari DataGridView ke dataBarangManager
                DataTable updatedData = (DataTable)dataGridView1.DataSource;
                dataBarangManager.DataBarang = updatedData;

                // Serialize DataTable menjadi JSON
                string json = JsonConvert.SerializeObject(dataBarangManager.DataBarang, Formatting.Indented);

                // Tulis JSON ke file
                File.WriteAllText(filePath, json);

                // Memperbarui DataGridView di FormHome
                formHome.LoadDataFromJson();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Terjadi kesalahan saat menyimpan data: " + ex.Message);
            }
        }

        private void edit_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedCells.Count > 0)
            {
                int selectedRowIndex = dataGridView1.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = dataGridView1.Rows[selectedRowIndex];

                // Mendapatkan nilai dari kolom yang dipilih
                string inputNamaValue = inputNama.Text;
                string inputJumlahValue = inputJumlah.Text;

                // Memperbarui nilai pada DataGridView
                selectedRow.Cells["Nama Barang"].Value = inputNamaValue;
                selectedRow.Cells["Jumlah Barang"].Value = inputJumlahValue;

                // Menyimpan perubahan data
                SaveData();

                MessageBox.Show("Data berhasil diubah.");
            }
            else
            {
                MessageBox.Show("Pilih baris terlebih dahulu.");
            }
        }

        private void back_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];

                // Mengisi textbox inputNama dengan data dari kolom "Nama Barang"
                inputNama.Text = row.Cells["Nama Barang"].Value.ToString();

                // Mengisi textbox inputJumlah dengan data dari kolom "Jumlah Barang"
                inputJumlah.Text = row.Cells["Jumlah Barang"].Value.ToString();
            }
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
                    edit.PerformClick();
                }
            }
            else if (e.KeyCode == Keys.Down)
            {
                e.Handled = true;

                // Cari index kontrol yang sedang fokus dalam urutan tab
                int index = this.GetNextControl(ActiveControl, true).TabIndex;

                // Fokus ke kontrol dengan index yang lebih tinggi (urutan tab yang berikutnya)
                Control nextControl = this.GetNextControl(this, true);
                while (nextControl != null && nextControl.TabIndex <= index)
                {
                    nextControl = this.GetNextControl(nextControl, true);
                }
                nextControl?.Focus();
            }
        }
    }
}
