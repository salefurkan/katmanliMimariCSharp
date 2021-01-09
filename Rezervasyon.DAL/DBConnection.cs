using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb; // OleDb kütüphanesini import ediyoruz.
using System.Data.SqlClient;
using System.Data;

namespace Rezervasyon.DAL
{
    public class DBConnection // diğer sınıflardan erişim sağlamak için public ifadesi ekliyoruz.
    {
        private readonly string _connectionString; // Connection String nesnemin tanımlanmasını yapıyorum.

        public DBConnection() // conctructor tanımlaması
        {
            _connectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\\Users\\Furkan\\source\\repos\\BiletRezervasyon\\BiletRezervasyon.mdb";
        } // MS Acces bağlantı'sı için Connection String tanımlaması yapıldı
        
        private OleDbConnection GetAccesConnection() // dışarıdan erişlemeyecek OleDbConnection tipinde bir method oluşturdum
        {
            OleDbConnection cnn = new OleDbConnection(_connectionString); //OleDbConnection sınıfın cnn adında constructor'ına
            //"_connectionString" gönderdim.

            // Connected mimarisi kullanacağım için tek bir connection ayaktayken aktif bir read işleminde başka bir connection
            //aktif olarak tekrar aynı tool üzerinden okuma işlemi gerçekleştiremez.
            if (cnn.State == ConnectionState.Open) //Yukarıda belirttiğim ifadeler doğrultusunda Connection durumunu kontrol ettim
            {
                cnn.Close(); // Açıksa kapatma işlemi yaptım bir hata ile karşılaşmamak için
                cnn.Open(); // hatayı giderdikten sonra tekrar açıyorum.
            }
            else
            {
                cnn.Open(); // diğer durumların hepsine açmasını istedim.
            }
            return cnn; //cnn nesnesini geri gönderdim.
        }

        public OleDbCommand GetDbCommand() // diğer classlardan ulaşabileceğim 
                               //OleDbComman nesnesi dönderen method tanımlaması yaptım.
        {
            OleDbCommand cmd = new OleDbCommand(); //OleDbCommand sınıfından yeni 
                                                   //bir nesne yarattım.
            cmd.Connection = GetAccesConnection(); //yarattığım nesneyi MS Acces 
                                                   //veritabanımla bağladım.
            return cmd; //nesneyi geri döndürdüm.
        }
    }
}
