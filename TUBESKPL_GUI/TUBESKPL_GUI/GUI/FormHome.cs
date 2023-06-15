using BarangKamuAdd;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Newtonsoft.Json;
using static BarangKamuGUI.FormHome;
using System.Text.Json;

namespace BarangKamuGUI
{
    public partial class FormHome : Form
    {
        private string folderPath;
        private string filePath;

        public class DataBarang
        {
            [JsonProperty("Nama Barang")]
            public string NamaBarang { get; set; }

            [JsonProperty("Jumlah Barang")]
            public string JumlahBarang { get; set; }
        }


        public class DataBarangManager
        {
            public DataTable DataBarang { get; set; }

            public DataBarangManager()
            {
                DataBarang = new DataTable();
                DataBarang.Columns.Add("Nama Barang", typeof(string));
                DataBarang.Columns.Add("Jumlah Barang", typeof(string));
            }
        }

        private DataBarangManager dataBarangManager;
        private FormAdd formAdd;

        public FormHome()
        {
            InitializeComponent();
            filePath =( "data.json");
            dataBarangManager = new DataBarangManager();

            LoadDataFromJson();
        }

        private void OpenFormAdd()
        {
            formAdd = new FormAdd(dataBarangManager, this); // Simpan instance FormAdd ke field formAdd
            formAdd.Owner = this; // Mengatur FormHome sebagai pemilik FormAdd
            formAdd.Show();
        }


        private void label1_Click(object sender, EventArgs e)
        {

        }

        //Tambah data barang
        private void button1_Click(object sender, EventArgs e)
        {
            OpenFormAdd();
        }

        //Delete data barang
        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        //inputNama
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        //inputJumlah
        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        //Update data barang
        private void button2_Click(object sender, EventArgs e)
        {

        }

        //Delete all data barang
        private void deleteAll_Click(object sender, EventArgs e)
        {
            // Clear all the rows from the data grid view
            dataBarang.Rows.Clear();
        }
        // Menyimpan data ke file XML
        public void SaveData()
        {
            try
            {
                // Buat list baru untuk menyimpan data barang
                List<DataBarang> dataBarangList = new List<DataBarang>();

                // Loop melalui setiap baris dalam DataTable dan tambahkan ke list dataBarangList
                foreach (DataRow row in dataBarangManager.DataBarang.Rows)
                {
                    string namaBarang = row["Nama barang"].ToString().Trim();
                    string jumlahBarang = row["Jumlah Barang"].ToString().Trim();

                    // Jika namaBarang dan jumlahBarang tidak kosong, tambahkan ke list dataBarangList
                    if (!string.IsNullOrWhiteSpace(namaBarang) && !string.IsNullOrWhiteSpace(jumlahBarang))
                    {
                        DataBarang dataBarang = new DataBarang
                        {
                            NamaBarang = namaBarang,
                            JumlahBarang = jumlahBarang
                        };

                        dataBarangList.Add(dataBarang);
                    }
                }

                // Serialize list dataBarangList menjadi JSON
                string json = JsonConvert.SerializeObject(dataBarangList, Formatting.Indented);

                // Tulis JSON ke file
                File.WriteAllText(filePath, json);

                MessageBox.Show("Data berhasil disimpan!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Terjadi kesalahan saat menyimpan data: " + ex.Message);
            }
        }

        public void saveInputAndData(string nama, int jumlah)
        {
            // Tambahkan row baru ke DataTable
            DataRow newRow = dataBarangManager.DataBarang.NewRow();
            newRow["Nama Barang"] = nama;
            newRow["Jumlah Barang"] = jumlah;
            dataBarangManager.DataBarang.Rows.Add(newRow);

            // Menyimpan data ke file JSON
            SaveData();
        }

        // Load data barang dari file XML
        public void LoadDataFromJson()
        {
            try
            {
                if (File.Exists(filePath))
                {
                    // Membaca teks dari file
                    string json = File.ReadAllText(filePath);

                    // Mengkonversi JSON menjadi List<DataBarang>
                    List<DataBarang> dataBarangList = JsonConvert.DeserializeObject<List<DataBarang>>(json);

                    if (dataBarangList != null && dataBarangList.Any()) // Check if dataBarangList is not empty
                    {
                        // Memperbarui dataBarangManager.DataBarang
                        dataBarangManager.DataBarang.Clear();
                        dataBarang.DataSource = dataBarangManager.DataBarang.DefaultView;
                        foreach (DataBarang dataBarang in dataBarangList)
                        {
                            DataRow newRow = dataBarangManager.DataBarang.NewRow();
                            newRow["Nama Barang"] = dataBarang.NamaBarang; // Modified column name
                            newRow["Jumlah Barang"] = dataBarang.JumlahBarang;
                            dataBarangManager.DataBarang.Rows.Add(newRow);
                        }
                    }
                    else
                    {
                        // Handle the case when there is no data in the JSON file
                        dataBarangManager.DataBarang.Clear();
                        dataBarang.DataSource = dataBarangManager.DataBarang.DefaultView;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Terjadi kesalahan saat memuat data: " + ex.Message);
            }

        }


        private void Form1_Load(object sender, EventArgs e)
        {
            LoadDataFromJson();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void dataBarang_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
