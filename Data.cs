using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Siparis_Otomasyon
{
    public static class Data
    {

        public static void DataGridViewDoldur(string catalog, string sorgu, DataGridView dgw)
        {
            dgw.Columns.Clear();
            dgw.DataSource =  VeriCek(catalog, sorgu);
            dgw.ReadOnly = true;
        }
        public static DataTable VeriCek(string catalog, string sorgu)
        {
            SqlConnection baglanti = new SqlConnection("Data Source=AbraA5V1584;Initial Catalog=" + catalog + ";Integrated Security=True");
            baglanti.Open();
            SqlDataAdapter da = new SqlDataAdapter(sorgu, baglanti);
            DataTable dt = new DataTable();
            da.Fill(dt);
            baglanti.Close();
            baglanti.Dispose();
            return dt;
        }

        public static void VeriSil(string catalog, string sorgu, string degisken, object oge)
        {
            SqlConnection baglanti = new SqlConnection("Data Source=AbraA5V1584;Initial Catalog=" + catalog + ";Integrated Security=True");
            SqlCommand komut = new SqlCommand(sorgu, baglanti);
            komut.Parameters.AddWithValue(degisken,oge);
            baglanti.Open();
            komut.ExecuteNonQuery();
            baglanti.Close();
            baglanti.Dispose();
        }

        public static void TabloOlustur(string siparisid)
        {
            SqlConnection baglanti = new SqlConnection(
                "Data Source=AbraA5V1584;Initial Catalog=Siparisler;Integrated Security=True");
            baglanti.Open();
            string sorgu = "Create Table " + siparisid +
                " (Kod int , Kategori nvarchar(40), Ad nvarchar(30), Agirlik int, Fiyat float, Adet int)";
            SqlCommand komut = new SqlCommand(sorgu, baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
            baglanti.Dispose();
        }

        public static void TabloSil(string siparisid)
        {
            SqlConnection baglanti = new SqlConnection(
                "Data Source=AbraA5V1584;Initial Catalog=Siparisler;Integrated Security=True");
            baglanti.Open();
            SqlCommand komut = new SqlCommand(string.Format("DROP TABLE {0}", siparisid), baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
            baglanti.Dispose();
        }

        public static void VeriEkle(params object[] parametreler)
        {
            SqlConnection baglanti = new SqlConnection(
                "Data Source=AbraA5V1584;Initial Catalog=" + Convert.ToString(parametreler[0]) + ";Integrated Security=True");
            baglanti.Open();
            SqlCommand komut = new SqlCommand(Convert.ToString(parametreler[1]), baglanti);
            for (int i = 2; i < parametreler.Length; i += 2)
            {
                komut.Parameters.AddWithValue(Convert.ToString(parametreler[i]), parametreler[i + 1]);
            }
            komut.ExecuteNonQuery();
            baglanti.Close();
            baglanti.Dispose();
        }

        public static int IDKontrol(string catalog, string sorgu, string degisken)
        {
            SqlConnection baglanti = new SqlConnection(
            "Data Source=AbraA5V1584;Initial Catalog="+catalog+";Integrated Security=True");
            int id;
            SqlCommand komut;
            SqlDataReader dr;
            do
            {
                Random rastgele = new Random();
                id = rastgele.Next(1000);
                komut = new SqlCommand(sorgu, baglanti);
                komut.Parameters.AddWithValue(degisken, id);
                baglanti.Open();
                dr = komut.ExecuteReader();
            } while(dr.Read());
            baglanti.Close();
            baglanti.Dispose();
            return id;
        }
    }
}
