using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntityLayer;
using
using Microsoft.Data.SqlClient;
using System.Data;

namespace DataAccessLayer
{
    public class DALOgrenci
    {
        public static int OgrenciEkle(EntityOgrenci parametre)
        {
            SqlCommand komut1 = new SqlCommand("insert into TblOgrenci (OgrAd,OgrSoyad,OgrNumara,OgrMail," +
                "OgrSifre) values (@p1,@p2,@p3,@p4,@p5", Connection.bgl);
            if (komut1.Connection.State != ConnectionState.Open)
            {
                // komut kapalıysa açılır 
                komut1.Connection.Open();
            }
            // parametrelere değer ataması yap
            komut1.Parameters.AddWithValue("p2", parametre.SOYAD);
            komut1.Parameters.AddWithValue("p3", parametre.NUMARA);
            komut1.Parameters.AddWithValue("p4", parametre.MAIL);
            komut1.Parameters.AddWithValue("p5", parametre.SIFRE);
            komut1.Parameters.AddWithValue("@p1", parametre.AD);
        }
    }
}
