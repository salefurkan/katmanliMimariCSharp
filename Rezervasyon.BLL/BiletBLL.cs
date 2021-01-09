using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Rezervasyon.DAL; // import edildi.

namespace Rezervasyon.BLL
{
    public class BiletBLL // diğer sınıflardan erişim sağlamak için public ifadesi ekliyoruz.+
    {
        private BiletDAL biletDal;//BiletDAL ilişki nesnesi oluşturulması.
                                  //Bir class'ın içerisinde yeni nesne tanımlaması olması profesyonel yazım kurallarına aykırı 
                                  // olduğu için contructor içerisinde yapmayı tercih ettim.
        public BiletBLL() // atama yapıldı
        {
            biletDal = new BiletDAL();
        }
        public DataTable GetAllItems() // DataAccesLayer'a (BiletDAL.cs'ye) gidicek ve 
                                       // oradaki GetAllItems methodunu tetikleyecek.
                                       
        {  
            return biletDal.GetAllItems(); 
        }

        // DataAccesLayer'a (BiletDAL.cs'ye) gidicek ve 
        // oradaki AddNewItem methodunu tetikleyecek.
        public void AddNewItem(int ID, string Ad, string Soyad, string Cinsiyet, string Nereden, string Nereye,
            string Tarih, string Saat, int Koltuk, string Ucret)
        {
            biletDal.AddNewItem( ID, Ad,  Soyad, Cinsiyet, Nereden, Nereye, Tarih, Saat,  Koltuk,  Ucret);
            
        }

        // DataAccesLayer'a (BiletDAL.cs'ye) gidicek ve 
        // oradaki DeleteItemById methodunu tetikleyecek.
        public void DeleteItemById(int ID)
        {
            biletDal.DeleteItemById(ID);
        }

        // DataAccesLayer'a (BiletDAL.cs'ye) gidicek ve 
        // oradaki UpdateItem methodunu tetikleyecek.
        public void UpdateItem(int ID, string Ad, string Soyad, string Cinsiyet, string Nereden, 
            string Nereye, string Tarih, string Saat, int Koltuk, string Ucret)
        {
            biletDal.UpdateItem(ID, Ad, Soyad, Cinsiyet, Nereden, Nereye, Tarih, Saat, Koltuk, Ucret);
        }
    }
}
