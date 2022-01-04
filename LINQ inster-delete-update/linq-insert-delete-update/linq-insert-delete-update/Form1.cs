using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace linq_insert_delete_update
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        denemeDataContext veritabani = new denemeDataContext();
        private void vericek()
        {
            var sorgu = from kisi in veritabani.Kisilers
                        select kisi;
            dataGridView1.DataSource = sorgu;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            vericek();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Kisiler kisi = new Kisiler()
            {
                ad = textBox1.Text,
                soyad = textBox2.Text,
                dogumTarihi = dateTimePicker1.Value,
                il = comboBox1.GetItemText(comboBox1.SelectedItem),
                ilce = comboBox2.GetItemText(comboBox2.SelectedItem)
            };
            veritabani.Kisilers.InsertOnSubmit(kisi);
            veritabani.SubmitChanges();
            vericek();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Kisiler silinecek_kisi = veritabani.Kisilers.First(u => u.id == 11);
            veritabani.Kisilers.DeleteOnSubmit(silinecek_kisi);
            veritabani.SubmitChanges();
            vericek();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Kisiler guncellenecek_kisi = veritabani.Kisilers.First(u => u.id == 1004);
            guncellenecek_kisi.ad = "Metin";
            veritabani.SubmitChanges();
            vericek();
        }
    }
}
