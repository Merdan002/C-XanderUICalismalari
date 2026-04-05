using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace C_XanderUICalismalari
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
          bilgilerEntities bilgi = new bilgilerEntities();
        private void xuıFormDesign1_WorkingArea_Paint(object sender, PaintEventArgs e)
        {
           //dataGridView1.DataSource = bilgi.student.ToList();
        }

        private void xuıSuperButton1_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = bilgi.student.ToList();
        }

        private void xuıButton1_Click(object sender, EventArgs e)
        { 
            student st = new student();
            st.Ad = materialTxtAd.Text;
            st.Soyad = materialTxtSoyad.Text;
            st.Telefon = materialTxtTel.Text;
            st.Eposta = materialTxtEposta.Text;
            bilgi.student.Add(st);
            bilgi.SaveChanges();
            MessageBox.Show("Kayıt Başarılı");
            dataGridView1.DataSource = bilgi.student.ToList();
            materialTxtAd.Clear();
            materialTxtSoyad.Clear();
            materialTxtTel.Clear();
            materialTxtEposta.Clear();

        }

        private void xuıButton2_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt16(materialTextBox1.Text);
            student st = bilgi.student.First(x => x.id == id);
            bilgi.student.Remove(st);
            bilgi.SaveChanges();
            MessageBox.Show("Personel Silindi");
            dataGridView1.DataSource = bilgi.student.ToList();
            materialTextBox1.Clear();
        }

        private void xuıButton3_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt16(materialTextBox1.Text);
            student st = bilgi.student.First(x => x.id == id);
            st.Ad = materialTxtAd.Text;
            st.Soyad = materialTxtSoyad.Text;
            st.Telefon = materialTxtTel.Text;
            st.Eposta = materialTxtEposta.Text;
            bilgi.SaveChanges();
            MessageBox.Show("Personel Güncellendi");
            dataGridView1.DataSource = bilgi.student.ToList();
            materialTxtAd.Clear();
            materialTxtSoyad.Clear();
            materialTxtTel.Clear();
            materialTxtEposta.Clear();

        }
    }
}
