using BarangKamuGUI;
using System;
using System.Windows.Forms;
using Newtonsoft.Json;
using System.IO;
using static BarangKamuGUI.FormHome;
using System.Data;

namespace BarangKamuDelete
{
    public partial class FormDelete : Form
    {
        private DataBarangManager dataBarangManager;
        private string filePath;
        private FormHome formHome;

        public FormDelete(DataBarangManager dataBarangManager, FormHome formHome)
        {
            InitializeComponent();
            this.dataBarangManager = dataBarangManager;
            this.formHome = formHome;
            filePath = "data.json";
            LoadData();
        }

        private void FormDelete_Load(object sender, EventArgs e)
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

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        
        private void button2_Click(object sender, EventArgs e)
        {
            // Menghapus data yang dipilih dari DataGridView1
            foreach (DataGridViewRow row in dataGridView1.SelectedRows)
            {
                dataGridView1.Rows.RemoveAt(row.Index);
            }
            MessageBox.Show("Data berhasil dihapus!!");
            //this.Hide();

            SaveData();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            // Menghapus semua data dari dataBarangManager
            dataBarangManager.DataBarang.Clear();

            // Memperbarui tampilan dataGridView1 berdasarkan perubahan pada dataBarangManager
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = dataBarangManager.DataBarang;

            // Menyimpan perubahan ke file JSON
            SaveData();

            MessageBox.Show("Data berhasil dihapus!");
        }


        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            // Logika tambahan yang mungkin perlu ditambahkan di sini
        }
    }
}