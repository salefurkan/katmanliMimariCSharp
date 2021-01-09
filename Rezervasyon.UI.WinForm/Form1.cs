using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Rezervasyon.BLL; // import ettim.


namespace Rezervasyon.UI.WinForm
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
        }

        private void listeleBtn_Click(object sender, EventArgs e) // Listele butonuna basılınca yapılacak olayı yazdım.
        {
            BiletBLL bll = new BiletBLL(); // ilişikilendirmiş olduğumuz BiletBLL sınıfı üzerinden yeni bir nesne tanımlaması yaptım.

            bilet_dataGridView.DataSource = bll.GetAllItems(); //  daha önce oluşturduğumuz bll nesnesi üzerinde GetAllItems methoduna ulaşarak.
                                                               //  dataGridView'ım veri kaynağınına gönderilecek olan verilerin tanımlanması yaptım.
            label1.Text = ""; // genel amaçlı tanımlamış olduğum bir Label

            listeleBtn.Enabled = false; // 1 kere yaptığı için 2. işleme gerek yok
        }

        private void btnKaydet_Click(object sender, EventArgs e) // Kaydet butonuna basılınca yapılacak olayı yazdım.
        {
            try //try catch yapısı kullanarak herhangi bir olumsuz durumu yakalamak istedim.
            {
                // belirtilen yerlerin boş olmaması için önlem getirdim.
                if (TxtId.Text == "" || Adi.Text == "" || Soyadi.Text == "" || Cinsiyeti_txt.Text == "" || Nereden_txt.Text == "" || Nereye_txt.Text == ""  || koltukTxt.Text=="" || ucretText.Text=="")
                {
                    MessageBox.Show("Bir veya Birden Fazla Kısım Boş Olamaz"); // hatanın sebebini belirttim.
                }
                else
                {
                    BiletBLL bll = new BiletBLL(); // BiletBLL sınıfına ulaşmak için nesne tanımlaması yaptım.

                    // AddNewItem için gerekli paramtereleri istenilen Veri Türünden gönderdim.
                    bll.AddNewItem(Convert.ToInt32(TxtId.Text), Adi.Text, Soyadi.Text, Cinsiyeti_txt.Text, Nereden_txt.Text,Nereye_txt.Text,
                        dateTimePicker1.Value.ToShortDateString(), dateTimePicker2.Value.ToShortTimeString(),Convert.ToInt32(koltukTxt.Text), ucretText.Text);

                    label1.Text = "               Başarıyla Kaydedildi Lütfen 'Listele' Tuşuna Basınız                  "; // genel amaçlı bilgilendirme mesajı.

                    listeleBtn.Enabled = true; // kayıtları görüntülemesi için listele butonunu aktifleştirdim.
                }
            }
            catch (Exception) // hata yakalaması durumdaki vereceği ikaz mesajı.
            {
                MessageBox.Show("Girdiğniz ID'yi veya Koltuk Numarasını Kontrol Ediniz");
             
            }
           
        }


        private void Form1_Load(object sender, EventArgs e) // Program çalıştırıldığında gerçekleşecek olayların yazılımı.
        {
           
            BiletBLL bll = new BiletBLL(); // BiletBLL sınıfından yeni bir nesne tanımlaması.
            bilet_dataGridView.DataSource = bll.GetAllItems(); // dataGridView'in Veri Kaynağının tanımlaması ve 
                                                               //BiletBLL sınıfından yaratılan nesne ile GetAllItems'ın geri döndereceğiz DataTable'ın ona atanma işlemi.

            listeleBtn.Enabled = false; // varsayılan olarak listeleme yapıldığı için Listele butonunu devre dışı bıraktım.
        }

        private void UpdateBtn_Click(object sender, EventArgs e) // Update Butonuna basıldığında olacak olayların yazılımı.
        {
            try //try catch yapısı kullanarak herhangi bir olumsuz durumu yakalamak istedim.
            {
                // belirtilen yerlerin boş olmaması için önlem getirdim.
                if (TxtId.Text == "" || Adi.Text == "" || Soyadi.Text == "" || Cinsiyeti_txt.Text == "" || Nereden_txt.Text == "" || Nereye_txt.Text == "" || koltukTxt.Text == "" || ucretText.Text == "")
                {
                    MessageBox.Show("Bir veya Birden Fazla Kısım Boş Olamaz"); // genel amaçlı bilgilendirme mesajı.
                }
                else {
                    BiletBLL bll = new BiletBLL();  // BiletBLL sınıfına ulaşmak için nesne tanımlaması yaptım.

                    // UpdateItem için gerekli paramtereleri istenilen Veri Türünden gönderdim.
                    bll.UpdateItem(Convert.ToInt32(TxtId.Text), Adi.Text, Soyadi.Text, Cinsiyeti_txt.Text, Nereden_txt.Text, Nereye_txt.Text, dateTimePicker1.Value.ToShortDateString() , dateTimePicker2.Value.ToShortTimeString(), Convert.ToInt32(koltukTxt.Text), ucretText.Text);
                    label1.Text = "               Başarıyla Güncellendi Lütfen 'Listele' Tuşuna Basınız                 "; // genel amaçlı bilgilendirme mesajı.

                    listeleBtn.Enabled = true; // güncellenen kayıtları görüntülemesi için listele butonunu aktifleştirdim.
                }
            }
            catch (Exception)  // hata yakalaması durumdaki vereceği ikaz mesajı.
            {
                MessageBox.Show("Olmayan Bir Bileti'yi Update Edemezsin"); // genel amaçlı bilgilendirme mesajı.
            }
            

        }

       
        private void btn_Sil_Click(object sender, EventArgs e) // Sil Butonuna basıldığında olacak olayların yazılımı.
        {
            try //try catch yapısı kullanarak herhangi bir olumsuz durumu yakalamak istedim.
            {
                BiletBLL bll = new BiletBLL(); // BiletBLL sınıfına ulaşmak için nesne tanımlaması yaptım.

                // DeleteItemById için gerekli paramtereyi istenilen Veri Türünden gönderdim.
                bll.DeleteItemById(Convert.ToInt32(TxtId.Text)); 
                label1.Text = "                    Başarıyla Silindi Lütfen 'Listele' Tuşuna Basınız                   "; // genel amaçlı bilgilendirme mesajı.

                listeleBtn.Enabled = true; // yeni listeyi görüntülemesi için listele butonunu aktifleştirdim.
            }
            catch (Exception)
            {
                if (TxtId.Text == "")
                {
                    MessageBox.Show("Bilet ID'si boş bırakalamaz."); // genel amaçlı bilgilendirme mesajı.
                }
                else
                MessageBox.Show("Olmayan Bir Bileti'yi Silemezsin"); // genel amaçlı bilgilendirme mesajı.
            }
            
        }

      

        private void TxtId_Click(object sender, EventArgs e) // ID yazmak isteyen birisi üstüne tıkladığında içindeki Text'i temizlemek için yazılmış Event.
        {
            TxtId.Clear();
        }

        private void Adi_Click(object sender, EventArgs e) // Adını yazmak isteyen birisi üstüne tıkladığında içindeki Text'i temizlemek için yazılmış Event.
        {
            Adi.Clear();
        }

        private void Soyadi_Click(object sender, EventArgs e) // Soyadını yazmak isteyen birisi üstüne tıkladığında içindeki Text'i temizlemek için yazılmış Event.
        {
            Soyadi.Clear();
        }

        private void Cinsiyeti_txt_Click(object sender, EventArgs e) // Cinsiyetini yazmak isteyen birisi üstüne tıkladığında içindeki Text'i temizlemek için yazılmış Event.
        {
            Cinsiyeti_txt.Clear();
        }

        private void Nereden_txt_Click(object sender, EventArgs e) // Nereden gittiğini yazmak isteyen birisi üstüne tıkladığında içindeki Text'i temizlemek için yazılmış Event.
        {
            Nereden_txt.Clear();
        }

        private void Nereye_txt_Click(object sender, EventArgs e) // Nereye gittiğini yazmak isteyen birisi üstüne tıkladığında içindeki Text'i temizlemek için yazılmış Event.
        {
            Nereye_txt.Clear();
        }


        private void koltukTxt_Click(object sender, EventArgs e) // Koltuk numarasını yazmak isteyen birisi üstüne tıkladığında içindeki Text'i temizlemek için yazılmış Event.
        {
            koltukTxt.Clear();
        }

        private void ucretText_Click(object sender, EventArgs e) // Ödeyeceği ücreti yazmak isteyen birisi üstüne tıkladığında içindeki Text'i temizlemek için yazılmış Event.
        {
            ucretText.Clear();
        }

        
    }
    }

