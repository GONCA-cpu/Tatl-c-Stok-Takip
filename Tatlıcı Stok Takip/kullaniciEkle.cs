﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace Tatlıcı_Stok_Takip
{
    public partial class kullaniciEkle : Form
    {
        OleDbConnection baglanti = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=\"C:\\Users\\gonca\\Stok Takipp.mdb\"");
        public kullaniciEkle()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            OleDbCommand kullaniciEkleKomutu = new OleDbCommand("insert into kullanicibilgi (id,sifre,adsoyad,gorevi)" + "  values('"+textBox1.Text+"','"+textBox2.Text+"','"+textBox3.Text+"','"+textBox4.Text+"')",baglanti);
            kullaniciEkleKomutu.ExecuteNonQuery();
            baglanti.Close();
            label5.Text = textBox3.Text + " başarıyla kaydedildi";

            textBox1.Clear();
            textBox2.Clear();

            textBox3.Clear();
            textBox4.Clear();


        }
    }
}
