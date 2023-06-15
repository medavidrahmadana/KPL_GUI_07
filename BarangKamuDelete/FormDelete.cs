using System;
using System.Windows.Forms;
using Newtonsoft.Json;
using System.IO;

namespace BarangKamuDelete
{
    public partial class FormDelete : Form
    {
        private string jsonFilePath = "data_barang.json";

        public FormDelete()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadData();

            // Tambahkan DataGridViewCheckBoxColumn ke DataGridView
            DataGridViewCheckBoxColumn checkboxColumn = new DataGridViewCheckBoxColumn();
            checkboxColumn.HeaderText = "Pilih";
            checkboxColumn.Name = "checkboxColumn";
            dataGridView1.Columns.Insert(0, checkboxColumn);
        }

        private void LoadData()
        {
            if (File.Exists(filePath))
            {
                string jsonData = File.ReadAllText(filePath);
                dataBarangManager.DataBarang = JsonConvert.DeserializeObject<DataTable>(jsonData);
                dataGridView1.DataSource = dataBarangManager.DataBarang;
            }
            else
            {
                // Handle jika file tidak ditemukan
                MessageBox.Show("File data tidak ditemukan!");
            }
        }

        private void SaveData()
        {
            string jsonData = JsonConvert.SerializeObject(dataGridView1.DataSource, Formatting.Indented);
            File.WriteAllText(jsonFilePath, jsonData);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            LoadData(); // Mengembalikan data yang sudah terhapus sebelumnya
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Menghapus data yang dipilih dari DataGridView1
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                DataGridViewCheckBoxCell checkbox = (DataGridViewCheckBoxCell)row.Cells["checkboxColumn"];
                if (checkbox.Value != null && (bool)checkbox.Value)
                {
                    dataGridView1.Rows.RemoveAt(row.Index);
                }
            }

            SaveData();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            // Menghapus semua data pada DataGridView1
            dataGridView1.Rows.Clear();
            SaveData();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dataGridView1.Columns["checkbox"].Index)
            {
                DataGridViewCheckBoxCell checkbox = (DataGridViewCheckBoxCell)dataGridView1.Rows[e.RowIndex].Cells["checkbox"];
                checkbox.Value = !Convert.ToBoolean(checkbox.Value);
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            // Logika tambahan yang mungkin perlu ditambahkan di sini
        }


    }
}
