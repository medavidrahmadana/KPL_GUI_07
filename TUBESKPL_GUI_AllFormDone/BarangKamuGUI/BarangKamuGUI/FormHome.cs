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
        public class DataBarang
        {
            public string NamaBarang { get; set; }
            public int JumlahBarang { get; set; }
        }

        public FormHome()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        //Tambah data barang
        private void button1_Click(object sender, EventArgs e)
        {
            // menerima inputan pada text box
            string inputnama = inputNama.Text;
            string inputjumlah = inputJumlah.Text;

            // menambah data ke table data barang
            dataBarang.Rows.Add(inputnama, inputjumlah);
            
            // menghapus isi text box
            inputNama.Text = "";
            inputJumlah.Text = "";
            SaveData();
        }

        //Delete data barang
        private void button3_Click(object sender, EventArgs e)
        {
            // Get the current selected row index
            int rowIndex = dataBarang.CurrentRow.Index;

            // Remove the row from the data grid view
            dataBarang.Rows.RemoveAt(rowIndex);
            //SaveDataToXml();
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
            // Get the input text from the text boxes
            string inputnama = inputNama.Text;
            string inputjumlah = inputJumlah.Text;

            // Get the current selected row index
            int rowIndex = dataBarang.CurrentRow.Index;

            // Update the values of the cells in the selected row
            dataBarang.Rows[rowIndex].Cells[0].Value = inputnama;
            dataBarang.Rows[rowIndex].Cells[1].Value = inputjumlah;

            // Clear the text boxes
            inputNama.Text = "";
            inputJumlah.Text = "";
            SaveData();
        }

        //Table yang berfungsi menerima nama barang dan jumlah barang colum 1 = NamaBarang, colum 2 = JummlahBarang
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
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
            string path = "data_barang.json";
            string json = System.Text.Json.JsonSerializer.Serialize(dataBarang, new JsonSerializerOptions
            {
                WriteIndented = true
            });
            File.WriteAllText(path, json);
        }

        // Load data barang dari file XML
        private void LoadDataFromJson()
        {
            // Clear all the rows from the data grid view
            dataBarang.Rows.Clear();

            // Read the JSON file
            string json = File.ReadAllText("data_barang.json");

            // Deserialize the JSON into a list of objects
            List<DataBarang> dataBarangList = JsonConvert.DeserializeObject<List<DataBarang>>(json);

            // Add each object in the list to the data grid view
            foreach (DataBarang dataBarang1 in dataBarangList)
            {
                string namaBarang = dataBarang1.NamaBarang;
                string jumlahBarang = dataBarang1.JumlahBarang.ToString();
                dataBarang.Rows.Add(namaBarang, jumlahBarang);
            }
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            LoadDataFromJson();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
