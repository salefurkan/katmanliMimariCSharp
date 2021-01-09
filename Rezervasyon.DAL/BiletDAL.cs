using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Data.OleDb;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Rezervasyon.DAL
{
    public class BiletDAL // diğer sınıflardan erişim sağlamak için public ifadesi ekliyoruz.
    {
        private DBConnection dBConnection; //Database bağlantı nesnesi oluşturulması.
                                           //Bir class'ın içerisinde yeni nesne tanımlaması olması profesyonel yazım kurallarına aykırı 
                                           // olduğu için contructor içerisinde yapmayı tercih ettim.
        public BiletDAL() // constructor oluşturup DBConnection tipinde yeni bir alan tanımlaması yapıyorum.
        {
            dBConnection = new DBConnection(); 
        }
        public DataTable GetAllItems() //Tüm verilerimi bana döndürecek olan DataTable tipindeki nesne tanımlamamı yapıyorum.
                  //Bu method tetiklendiğinde bütün veriler Bilgiler tablosundan alınıp DataTable içerisine yüklenmiş olucak.
        {
            OleDbCommand cmd = dBConnection.GetDbCommand();  // dbConnection nesnesinden bir tane dbCommand nesnesi aldım 
                                                    //ve bu nesneyi bir değişkene atadım. OleDbCommand bağlantısı hazırladım.

            cmd.CommandText = "select * from Bilgiler order by ID ASC"; // bağlantı komutunu azıyorum. 
            //bu komut sayesinde tablodaki verileri ID'ye göre sıralayarak sahip oluyorum.

            DataTable dt = new DataTable(); // DataTable tipinde nesne tanımlaması yapıyorum. 
            dt.Load(cmd.ExecuteReader()); // ExecuteReader Command'i çalıştırarak dt içerisine yükleme yaptım.
            return dt; // DataTable'ı geri döndürüyorum.
        }

        // Reservasyon Eklme İşlemi yapacağım alan tanımlaması yaptım
        // Tablodaki verilere paralel bir şekilde Veri Türü ve isim tanımlaması yaptım

        public void AddNewItem(int ID,string Ad, string Soyad,string Cinsiyet,string Nereden,string Nereye,string Tarih,
            string Saat,int Koltuk,string Ucret)
        {
            string cmdText  = "insert into Bilgiler (ID,Ad,Soyad,Cinsiyet,Nereden,Nereye,Tarih,Saat,Koltuk,Ucret)";
            cmdText += String.Format("Values('{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}','{8}','{9}')", ID,Ad,Soyad, 
                Cinsiyet, Nereden, Nereye, Tarih, Saat, Koltuk, Ucret); // Gerekli İnsert sorgumu yazdım ve atamaları yaptım.

            OleDbCommand cmd = dBConnection.GetDbCommand(); // dbConnection nesnesinden bir tane dbCommand nesnesi aldım 
                                                    //ve bu nesneyi bir değişkene atadım. OleDbCommand bağlantısı hazırladım.

            cmd.CommandText = cmdText; // CommmandText'e hazırlamış olduğum sorgu ataması yappıyorum
            cmd.ExecuteNonQuery(); // Komutun çalıştırılması için gerekli komutum.


        }

        // Rezervasyon Silme İşlemi yapacağım alan tanımlaması
        // Silme işlemi için ID yeterli olacağını için ID parametresi yeterli olucaktır.
        public void DeleteItemById(int ID)
        {
            OleDbCommand cmd = dBConnection.GetDbCommand(); //// dbConnection nesnesinden bir tane dbCommand nesnesi aldım 
                                                  //ve bu nesneyi bir değişkene atadım. OleDbCommand bağlantısı hazırladım.

            cmd.CommandText = String.Format("Delete From Bilgiler Where ID = {0}", ID); //Kodun okunurluğunu arttırmak için 
                                                                  //String.Format kullandım ve gerekli Delete sorgumu yazdım.

            cmd.ExecuteNonQuery(); // Komutun çalıştırılması için gerekli komutum.
        }

        // Reservasyon Güncelleme İşlemi yapacağım alan tanımlaması
        // Tablodaki verilere paralel bir şekilde Veri Türü ve isim tanımlaması yaptım
        public void UpdateItem(int ID, string Ad, string Soyad, string Cinsiyet, string Nereden, string Nereye,
            string Tarih, string Saat, int Koltuk, string Ucret)
        {
            string cmdText = "update Bilgiler set ID="+ID+",Ad='"+Ad+"',Soyad='"+Soyad+ "',Cinsiyet='" + Cinsiyet + "'," +
                "Nereden='" + Nereden + "',Nereye='" + Nereye + "',Tarih='" + Tarih + "',Saat='" + Saat + "',Koltuk=" + Koltuk + "," +
                "Ucret='" + Ucret + "' where ID=" + ID+"";    // // Gerekli Update sorgumu yazdım ve atamaları yaptım.
            OleDbCommand cmd = dBConnection.GetDbCommand(); // dbConnection nesnesinden bir tane dbCommand nesnesi aldım ve bu nesneyi bir değişkene 
                                                            // atadım. OleDbCommand bağlantısı hazırladım.
            cmd.CommandText = String.Format(cmdText);  // CommmandText'e hazırlamış olduğum sorgu ataması yappıyorum
            cmd.ExecuteNonQuery();                 // Komutun çalıştırılması için gerekli komutum.
        } 
    }
}

