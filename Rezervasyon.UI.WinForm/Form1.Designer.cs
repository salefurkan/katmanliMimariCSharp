namespace Rezervasyon.UI.WinForm
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.bilet_dataGridView = new System.Windows.Forms.DataGridView();
            this.listeleBtn = new System.Windows.Forms.Button();
            this.Adi = new System.Windows.Forms.TextBox();
            this.Soyadi = new System.Windows.Forms.TextBox();
            this.Cinsiyeti_txt = new System.Windows.Forms.TextBox();
            this.Nereden_txt = new System.Windows.Forms.TextBox();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.TxtId = new System.Windows.Forms.TextBox();
            this.UpdateBtn = new System.Windows.Forms.Button();
            this.btn_Sil = new System.Windows.Forms.Button();
            this.Nereye_txt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ucretText = new System.Windows.Forms.TextBox();
            this.koltukTxt = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.bilet_dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // bilet_dataGridView
            // 
            this.bilet_dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.bilet_dataGridView.Location = new System.Drawing.Point(5, 12);
            this.bilet_dataGridView.Name = "bilet_dataGridView";
            this.bilet_dataGridView.Size = new System.Drawing.Size(1022, 366);
            this.bilet_dataGridView.TabIndex = 0;
            // 
            // listeleBtn
            // 
            this.listeleBtn.Location = new System.Drawing.Point(1032, 12);
            this.listeleBtn.Name = "listeleBtn";
            this.listeleBtn.Size = new System.Drawing.Size(177, 42);
            this.listeleBtn.TabIndex = 1;
            this.listeleBtn.Text = "Listele";
            this.listeleBtn.UseVisualStyleBackColor = true;
            this.listeleBtn.Click += new System.EventHandler(this.listeleBtn_Click);
            // 
            // Adi
            // 
            this.Adi.Location = new System.Drawing.Point(1032, 141);
            this.Adi.Name = "Adi";
            this.Adi.Size = new System.Drawing.Size(177, 20);
            this.Adi.TabIndex = 2;
            this.Adi.Text = "Adı";
            this.Adi.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Adi.Click += new System.EventHandler(this.Adi_Click);
            // 
            // Soyadi
            // 
            this.Soyadi.Location = new System.Drawing.Point(1030, 167);
            this.Soyadi.Name = "Soyadi";
            this.Soyadi.Size = new System.Drawing.Size(177, 20);
            this.Soyadi.TabIndex = 3;
            this.Soyadi.Text = "Soyadı";
            this.Soyadi.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Soyadi.Click += new System.EventHandler(this.Soyadi_Click);
            // 
            // Cinsiyeti_txt
            // 
            this.Cinsiyeti_txt.Location = new System.Drawing.Point(1033, 193);
            this.Cinsiyeti_txt.Name = "Cinsiyeti_txt";
            this.Cinsiyeti_txt.Size = new System.Drawing.Size(177, 20);
            this.Cinsiyeti_txt.TabIndex = 4;
            this.Cinsiyeti_txt.Text = "Cinsiyet";
            this.Cinsiyeti_txt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Cinsiyeti_txt.Click += new System.EventHandler(this.Cinsiyeti_txt_Click);
            // 
            // Nereden_txt
            // 
            this.Nereden_txt.Location = new System.Drawing.Point(1032, 219);
            this.Nereden_txt.Name = "Nereden_txt";
            this.Nereden_txt.Size = new System.Drawing.Size(177, 20);
            this.Nereden_txt.TabIndex = 5;
            this.Nereden_txt.Text = "Nereden";
            this.Nereden_txt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Nereden_txt.Click += new System.EventHandler(this.Nereden_txt_Click);
            // 
            // btnKaydet
            // 
            this.btnKaydet.Location = new System.Drawing.Point(1033, 336);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(86, 42);
            this.btnKaydet.TabIndex = 6;
            this.btnKaydet.Text = "Kaydet";
            this.btnKaydet.UseVisualStyleBackColor = true;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // TxtId
            // 
            this.TxtId.Location = new System.Drawing.Point(1032, 115);
            this.TxtId.Name = "TxtId";
            this.TxtId.Size = new System.Drawing.Size(177, 20);
            this.TxtId.TabIndex = 7;
            this.TxtId.Text = "ID";
            this.TxtId.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TxtId.Click += new System.EventHandler(this.TxtId_Click);
            // 
            // UpdateBtn
            // 
            this.UpdateBtn.Location = new System.Drawing.Point(1127, 336);
            this.UpdateBtn.Name = "UpdateBtn";
            this.UpdateBtn.Size = new System.Drawing.Size(83, 42);
            this.UpdateBtn.TabIndex = 8;
            this.UpdateBtn.Text = "Güncelle";
            this.UpdateBtn.UseVisualStyleBackColor = true;
            this.UpdateBtn.Click += new System.EventHandler(this.UpdateBtn_Click);
            // 
            // btn_Sil
            // 
            this.btn_Sil.Location = new System.Drawing.Point(1032, 60);
            this.btn_Sil.Name = "btn_Sil";
            this.btn_Sil.Size = new System.Drawing.Size(177, 40);
            this.btn_Sil.TabIndex = 9;
            this.btn_Sil.Text = "Sil";
            this.btn_Sil.UseVisualStyleBackColor = true;
            this.btn_Sil.Click += new System.EventHandler(this.btn_Sil_Click);
            // 
            // Nereye_txt
            // 
            this.Nereye_txt.Location = new System.Drawing.Point(1033, 245);
            this.Nereye_txt.Name = "Nereye_txt";
            this.Nereye_txt.Size = new System.Drawing.Size(177, 20);
            this.Nereye_txt.TabIndex = 11;
            this.Nereye_txt.Text = "Nereye";
            this.Nereye_txt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Nereye_txt.Click += new System.EventHandler(this.Nereye_txt_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(5, 335);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 38);
            this.label1.TabIndex = 12;
            this.label1.UseCompatibleTextRendering = true;
            // 
            // ucretText
            // 
            this.ucretText.Location = new System.Drawing.Point(1147, 310);
            this.ucretText.Name = "ucretText";
            this.ucretText.Size = new System.Drawing.Size(62, 20);
            this.ucretText.TabIndex = 18;
            this.ucretText.Text = "Ücret";
            this.ucretText.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ucretText.Click += new System.EventHandler(this.ucretText_Click);
            // 
            // koltukTxt
            // 
            this.koltukTxt.Location = new System.Drawing.Point(1032, 310);
            this.koltukTxt.Name = "koltukTxt";
            this.koltukTxt.Size = new System.Drawing.Size(103, 20);
            this.koltukTxt.TabIndex = 17;
            this.koltukTxt.Text = "Koltuk";
            this.koltukTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.koltukTxt.Click += new System.EventHandler(this.koltukTxt_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(1033, 284);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(89, 20);
            this.dateTimePicker1.TabIndex = 19;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dateTimePicker2.Location = new System.Drawing.Point(1141, 284);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(66, 20);
            this.dateTimePicker2.TabIndex = 20;
            this.dateTimePicker2.Value = new System.DateTime(2020, 8, 21, 22, 51, 24, 0);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(1030, 268);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 13);
            this.label2.TabIndex = 21;
            this.label2.Text = "Rezervasyon Tarihi";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(1156, 268);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 13);
            this.label3.TabIndex = 22;
            this.label3.Text = "Saati";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1217, 386);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.ucretText);
            this.Controls.Add(this.koltukTxt);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Nereye_txt);
            this.Controls.Add(this.btn_Sil);
            this.Controls.Add(this.UpdateBtn);
            this.Controls.Add(this.TxtId);
            this.Controls.Add(this.btnKaydet);
            this.Controls.Add(this.Nereden_txt);
            this.Controls.Add(this.Cinsiyeti_txt);
            this.Controls.Add(this.Soyadi);
            this.Controls.Add(this.Adi);
            this.Controls.Add(this.listeleBtn);
            this.Controls.Add(this.bilet_dataGridView);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bilet_dataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView bilet_dataGridView;
        private System.Windows.Forms.Button listeleBtn;
        private System.Windows.Forms.TextBox Adi;
        private System.Windows.Forms.TextBox Soyadi;
        private System.Windows.Forms.TextBox Cinsiyeti_txt;
        private System.Windows.Forms.TextBox Nereden_txt;
        private System.Windows.Forms.Button btnKaydet;
        private System.Windows.Forms.TextBox TxtId;
        private System.Windows.Forms.Button UpdateBtn;
        private System.Windows.Forms.Button btn_Sil;
        private System.Windows.Forms.TextBox Nereye_txt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox ucretText;
        private System.Windows.Forms.TextBox koltukTxt;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}

