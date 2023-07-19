using PersonelTakipUygulamasi.DataAccess.Abstract;
using PersonelTakipUygulamasi.DataAccess.Concrete.SQLite;
using PersonelTakipUygulamasi.DataAccess.Concrete.SqlServer;
using PersonelTakipUygulamasi.Entities.Concrete;
using PersonelTakipUygulamasi.Tools.Connection.SQLite;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PersonelTakipUygulamasi.Forms
{
	public partial class FrmAnaMenu : Form
	{
		public FrmAnaMenu(string veriTabani)
		{
			InitializeComponent();
			//Yapıcı metot içinde kullanıcının seçimine göre kullanılacak veritabanı seçimi
			switch (veriTabani)
			{
				case "SQLite":
					_calisanDal = new SQLiteCalisanDal();
					break;

				case "SqlServer":
					_calisanDal = new SqlServerCalisanDal();
					break;
			}
		}

		//SQLiteCalisanDal _calisanDal = new SQLiteCalisanDal();
		//SqlServerCalisanDal _calisanDal = new SqlServerCalisanDal();
		//Polimorfizm ile aynı interface'den implement olmuş iki classdan da obje üretebiliyoruz.
		//ICalisanDal _calisanDal = new SqlServerCalisanDal();
		//ICalisanDal _calisanDal = new SQLiteCalisanDal();

		ICalisanDal _calisanDal;

		Calisan _calisan;
		private int _seciliCalisanId;

		//METOTLAR BAŞLANGIÇ
		#region METOTLAR


		//Boş alanları temizleme metodu
		/// <summary>
		/// Formda boş bir değer var mı bunun kontrolünü sağlar.
		/// </summary>
		/// <returns>Boş değer varsa 'false' yok ise 'true' değer döndürür.</returns>
		private bool BosKayitKontrol()
		{

			//Araç kutularının olduğu panelde foreach döngüsü ile gezerek boş olan var mı bunun tespiti.
			foreach (Control item in pnlAraclar.Controls)
			{
				//Boş item varsa değeri false yap.
				if (item.Text == string.Empty || string.IsNullOrWhiteSpace(item.Text))
				{
					return false;
					//Bir tane bile boş varsa döngünün daha fazla dönmesine gerek yok.
				}
			}
			return true;
		}

		//Form elemanlarını temizleme metodu
		/// <summary>
		/// Form alanlarında ki metinleri siler
		/// </summary>
		private void AlanlariTemizle()
		{
			//Form elemanlarında dönerek kontrol etme
			foreach (Control item in pnlAraclar.Controls)
			{
				if (item.GetType().Name != "Label")
				{
					item.Text = string.Empty;
				}
			}
			cbxUnvan.SelectedIndex = -1;
			cbxDepertman.SelectedIndex = -1;
			cbxDurum.SelectedIndex = -1;

			//Tarih bölümünün formatını değiştirerek boş yapma.
			dateDogumTarihi.Format = DateTimePickerFormat.Custom;
			dateDogumTarihi.CustomFormat = " ";

			

		}

		//Data Grid View Düzenleme
		/// <summary>
		/// GridView'ın temasını düzenler, her gridview işleminden sonra çağrılması tavsiye edilir.
		/// </summary>
		private void GridViewDuzenle()
		{
			dgwCalisanlar.Columns["Id"].Visible = false;
			dgwCalisanlar.Columns["Adi"].HeaderText = "ADI";
			dgwCalisanlar.Columns["SoyAdi"].HeaderText = "SOYADI";
			dgwCalisanlar.Columns["TCKimlikNo"].HeaderText = "TC KİMLİK NO";
			dgwCalisanlar.Columns["PersonelNo"].HeaderText = "PERSONEL NO";
			dgwCalisanlar.Columns["DogumTarihi"].HeaderText = "DOĞUM TARİHİ";
			dgwCalisanlar.Columns["Departman"].HeaderText = "DEPARTMAN";
			dgwCalisanlar.Columns["Unvan"].HeaderText = "UNVAN";
			dgwCalisanlar.Columns["Durumu"].HeaderText = "DURUMU";

			dgwCalisanlar.ClearSelection(); //Seçili stunları temizliyoruz
			if (_seciliCalisanId != 0) //Seçilen bir çalışan varsa eğer
			{
				foreach (DataGridViewRow row in dgwCalisanlar.Rows)//Foreach ie datagridview içinde dönüyor
				{
					if (_seciliCalisanId == Convert.ToInt32(row.Cells[0].Value.ToString()))//Seçili değeri bulduğunda
					{	//İlgili değeri seçiyor böylece default ilk değer seçili gelmiyor önceden seçilen değer seçili geliyor
						row.Selected = true; 
						break;
					}

				}
				
			}
			


		}


		//Kosul cümlesi oluşturma
		private string KosulCumlesiOlustur()
		{
			string kosulCumlesi = string.Empty;

			List<string> alanlar = new List<string>();

			foreach (Control item in pnlAraclar.Controls)
			{
				if(item.Tag == null)  continue; 

				string alanAdi = item.Tag.ToString();
				string deger = string.Empty;

				if(string.IsNullOrWhiteSpace(item.Text) || item.Text == string.Empty) continue;

				deger = item.Text;

				if(item.Name == "dateDogumTarihi")
				{	
					DateTime dt = Convert.ToDateTime(deger);
					alanlar.Add($"{alanAdi}= '{dt.ToString("yyy.MM.dd")}'");
				}

				else
				{
					alanlar.Add($"{alanAdi} LIKE '%{deger}%'");
				}

			}

			if (alanlar.Count > 0) kosulCumlesi = $"WHERE {string.Join(" AND ", alanlar)}";





			return kosulCumlesi;
		}
		#endregion
		//METOTLAR BİTİŞ

		// (KAYDET BUTONU) Girilen verilerin veritabanına kaydedilme işlemi
		private void btnKaydet_Click(object sender, EventArgs e)

		{	//Bos alanlar var mı kontrol ederek buna göre işlem yaptırma
			if (!BosKayitKontrol())
			{
				MessageBox.Show("Lütfen gerekli bütün alanları doldurunuz.","Kayıt Başarısız",
					MessageBoxButtons.OK, MessageBoxIcon.Warning);
			}
			else
			{	
				//Calışan adında bir entiti oluşturup değerlerini kullanıcının girdiği verilerden alıyoruz
				_calisan = new Calisan
				{
					Adi = tbxAdi.Text,
					SoyAdi = tbxSoyAdi.Text,
					TCKimlikNo = tbxTCKimlikNo.Text,
					PersonelNo = tbxPersonelNo.Text,
					DogumTarihi = dateDogumTarihi.Value,
					Departman = cbxDepertman.Text,
					Unvan = cbxUnvan.Text.ToString(),//Select boxlarda bu şekilde kullanımda yapılabilir
					Durumu = cbxDurum.Text
				};

				//_calisandal referansı ile bağlanmış olan sqlitecalisandal sınıfı içerisinde ki kaydet metoduna 
				//verileri gönderiyoruz işlem başarılı olursa true değer döneceği için bu blok çalışıyor.
				if (_calisanDal.Kaydet(_calisan)) 
				{
					MessageBox.Show("Kayıt başarılı.");
					dgwCalisanlar.DataSource = _calisanDal.Listele();

					//Eklenen kayıt en sona düşeceği için son kaydın seçili kayıt olması için listele metodundan dönen
					//listenin sonuncu elemanının Id propertysini _seciliCalisanId yapıyorum
					_seciliCalisanId = _calisanDal.Listele().Last().Id;
					
					
					
					GridViewDuzenle();
				}
				

			}
		}

		// (TEMİZLE BUTONU) Form elemanlarına girilen verileri temizleme işlemi 
		private void btnTemizle_Click(object sender, EventArgs e)
		{
			AlanlariTemizle();	
		}

		// (GÜNCELLE BUTONU) Kayıtlı bir veriyi güncelleme işlemi
		private void btnGuncelle_Click(object sender, EventArgs e)
		{
			//DGW aracına tıklandı mı kontol
			if (_seciliCalisanId == 0) //Eğer hiçbir değer seçilmezse id değişkeni default 0 olacaktır
			{
				MessageBox.Show("Lütfen bir personel seçiniz.", "Güncelleme Başarısız",
					MessageBoxButtons.OK, MessageBoxIcon.Warning);
			}
			else if (!BosKayitKontrol())
			{
				MessageBox.Show("Lütfen gerekli bütün alanları doldurunuz.", "Kayıt Başarısız",
					MessageBoxButtons.OK, MessageBoxIcon.Warning);
			}
			else
			{
				//Calışan adında bir entiti oluşturup değerlerini kullanıcının girdiği verilerden alıyoruz
				_calisan = new Calisan
				{	
					Id	= _seciliCalisanId, //Id değerini seçilen calışanın id'si olarak güncelliyoruz
					Adi = tbxAdi.Text,
					SoyAdi = tbxSoyAdi.Text,
					TCKimlikNo = tbxTCKimlikNo.Text,
					PersonelNo = tbxPersonelNo.Text,
					DogumTarihi = dateDogumTarihi.Value,
					Departman = cbxDepertman.Text,
					Unvan = cbxUnvan.Text.ToString(),//Select boxlarda bu şekilde kullanımda yapılabilir
					Durumu = cbxDurum.Text
				};
				//_calisandal referansı ile bağlanmış olan sqlitecalisandal sınıfı içerisinde ki guncelle() metoduna 
				//verileri gönderiyoruz işlem başarılı olursa true değer döneceği için bu blok çalışıyor.
				if (_calisanDal.Guncelle(_calisan))
				{
					MessageBox.Show("Güncelleme başarılı.");
					dgwCalisanlar.DataSource = _calisanDal.Listele();
					GridViewDuzenle();
					
				}
				

			}
			
		}

		// (DATETİME) Form elemanlarını temizlerken doğum tarihi adlı bölümün formatı da değiştiği için eski haline getirme işlemi (DateTime Değer Değiştirme)
		private void dateDogumTarihi_ValueChanged(object sender, EventArgs e)
		{
			dateDogumTarihi.Format = DateTimePickerFormat.Short;
		}

		
		// (LOAD) Sayfa yüklenirken gerçekleşecek olan işlemler
		private void FrmAnaMenu_Load(object sender, EventArgs e)
		{
			AlanlariTemizle();
			dgwCalisanlar.DataSource = _calisanDal.Listele();
			GridViewDuzenle();
			
			cbxDepertman.DropDownStyle = ComboBoxStyle.DropDownList;
			cbxUnvan.DropDownStyle = ComboBoxStyle.DropDownList;
			cbxDurum.DropDownStyle = ComboBoxStyle.DropDownList;

		}

		//(DATAGRİDVİEW) Secilen elemanın verilerini yazdırma işlemi
		private void dgwCalisanlar_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			if (dgwCalisanlar.Rows.Count != 0) //Eğer datagridview'de eleman varsa çalışacak
			{
				_seciliCalisanId = Convert.ToInt32(dgwCalisanlar.CurrentRow.Cells[0].Value.ToString());
				tbxAdi.Text = dgwCalisanlar.CurrentRow.Cells[1].Value.ToString();
				tbxSoyAdi.Text = dgwCalisanlar.CurrentRow.Cells[2].Value.ToString();
				tbxTCKimlikNo.Text = dgwCalisanlar.CurrentRow.Cells[3].Value.ToString();
				tbxPersonelNo.Text = dgwCalisanlar.CurrentRow.Cells[4].Value.ToString();
				dateDogumTarihi.Format = DateTimePickerFormat.Short;//Date time formatı temizleme işleminde custom yapıldığı için eski haline döndürüyoruz
				dateDogumTarihi.Value = Convert.ToDateTime(dgwCalisanlar.CurrentRow.Cells[5].Value.ToString());
				cbxDepertman.Text = dgwCalisanlar.CurrentRow.Cells[6].Value.ToString();
				cbxUnvan.Text = dgwCalisanlar.CurrentRow.Cells[7].Value.ToString();
				cbxDurum.Text = dgwCalisanlar.CurrentRow.Cells[8].Value.ToString();
			}

			
			

		}


		//(SİL BUTONU) Seçili kaydı silme işlemi
		private void btnSil_Click(object sender, EventArgs e)
		{
			if(_seciliCalisanId == 0)
			{
				MessageBox.Show("Lütfen bir personel seçiniz.", "Silme Başarısız",
					MessageBoxButtons.OK, MessageBoxIcon.Warning);
			}
			else
			{
				DialogResult onay = MessageBox.Show("Personel kaydı kalıcı olarak silinecektir. \n" +
					"Bu  silmek istediğinize emin misiniz?", "Dikkat",MessageBoxButtons.YesNo,MessageBoxIcon.Question);

				if(onay == DialogResult.Yes)
				{
					
					bool islem = _calisanDal.Sil(_seciliCalisanId);

					
					if (islem)
					{
						dgwCalisanlar.DataSource = _calisanDal.Listele();
						GridViewDuzenle();
						AlanlariTemizle();
						_seciliCalisanId = 0;
						MessageBox.Show("Seçili kayıt başırlı bir şekilde silindi.");

					}
					

					
				}
				


				

			}
		}


		// (HEPSİNİ SİL) Tüm kayıtları siler
		private void btnHepsiniSil_Click(object sender, EventArgs e)
		{
			DialogResult onay = MessageBox.Show("Tüm veriler Kalıcı olarak silinecektir. \n" +
					"Tüm verileri silmek istediğinizden emin misiniz?", "Dikkat", 
					MessageBoxButtons.YesNo, MessageBoxIcon.Question);

			if (onay == DialogResult.Yes)
			{
				bool islem = _calisanDal.Sil();

				
				
				if (islem)
				{
					_seciliCalisanId = 0;
					GridViewDuzenle();
					AlanlariTemizle();
					dgwCalisanlar.DataSource = null;
					MessageBox.Show("Kayıtlar başırlı bir şekilde silindi.");
				}
				

				
			}
		}


		// (BUL BUTONU) Girilen değerlere göreme arama yapar
		private void btnBul_Click(object sender, EventArgs e)
		{
			dgwCalisanlar.DataSource = _calisanDal.Listele(KosulCumlesiOlustur());
			_seciliCalisanId = 0;
			GridViewDuzenle();
			
		}


		// (GETİR BUTONU)
		private void btnGetir_Click(object sender, EventArgs e)
		{	
			_calisan = _calisanDal.Getir(KosulCumlesiOlustur());
			if (_calisan != null)
			{
				_seciliCalisanId = _calisan.Id;
				dgwCalisanlar.DataSource = _calisanDal.Listele($"WHERE Id = '{_calisan.Id}'");
			}
			
			 
			
			
			
		}
	}
}
