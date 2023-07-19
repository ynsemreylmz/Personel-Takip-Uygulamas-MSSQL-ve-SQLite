using PersonelTakipUygulamasi.DataAccess.Abstract;
using PersonelTakipUygulamasi.Entities.Concrete;
using PersonelTakipUygulamasi.Tools.Connection.SQLite;
using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PersonelTakipUygulamasi.DataAccess.Concrete.SQLite
{
	public class SQLiteCalisanDal : ICalisanDal
	{
		//Parametresiz çağrılması durumunda tüm tablo verilerini döndürür
		/// <summary>
		/// Veritabanında ki tüm verileri liste haline getirir.
		/// </summary>
		/// <returns>Bu listeyi döndürür.</returns>
		public List<Calisan> Listele()
		{
			List<Calisan> calisanlar = new List<Calisan>();
			try
			{
				//Using scopeları içinde tanımlanan nesne scope dışına çıkılır çıkılmaz silinir.
				using (SQLiteCommand command = new SQLiteCommand($"SELECT * FROM Calisanlar", SQLiteBaglanti.Connection))
				{
					SQLiteBaglanti.BaglantiAc();//Bağlantı oluşturuluyor
					using (SQLiteDataReader reader = command.ExecuteReader())
					{
						while (reader.Read())//Reader nesnesi okuma işlemi yaptığı sürece dönecek
						{
							Calisan _calisan = new Calisan //Calisan entitisinden nesne oluşturuyoruz.
							{
								Id = Convert.ToInt32(reader["Id"]),
								Adi = reader["Adi"].ToString(),
								SoyAdi = reader["SoyAdi"].ToString(),
								TCKimlikNo = reader["TCKimlikNo"].ToString(),
								PersonelNo = reader["PersonelNo"].ToString(),
								DogumTarihi = Convert.ToDateTime(reader["DogumTarihi"]),
								Departman = reader["Departman"].ToString(),
								Unvan = reader["Unvan"].ToString(),
								Durumu = reader["Durumu"].ToString()
							};

							//Döngüden dönen içerisinde çalışan verilerini barındıran nesneyi listeye ekliyoruz.
							calisanlar.Add(_calisan);
						}
					}
					return calisanlar;
				}
			}

			catch (Exception ex)
			{   //Veritabanı işlemleri esnasında hata alınırsa ekrana gösterme işlemi ve geriye null değer döndürme
				MessageBox.Show(ex.Message, "Bir Hata Oluştu",
					MessageBoxButtons.OK, MessageBoxIcon.Error);
				return null;
			}
			//Try yada Catch blogu çalıştıktan sonra en son çalışacak blog finally'de baglantıyı kapatıyoruz.
			finally
			{
				SQLiteBaglanti.BaglantiKapat();
			}
		}
		
		//Overload işlemi
		/// <summary>
		/// Girilen koşula göre veri tabanında ki verileri liste haline getirir.
		/// </summary>
		/// <param name="kosulCumlesi">Hangi koşula göre verileri döndürüleceği koşul</param>
		/// <returns>Bu listeyi döndürür.</returns>
		public List<Calisan> Listele(string kosulCumlesi)
		{
			List<Calisan> calisanlar = new List<Calisan>();
			try
			{	
				//Using scopeları içinde tanımlanan nesne scope dışına çıkılır çıkılmaz silinir.
				using (var command = new SQLiteCommand($"SELECT * FROM Calisanlar {kosulCumlesi}", SQLiteBaglanti.Connection))
				{
					
					SQLiteBaglanti.BaglantiAc();
					using (SQLiteDataReader reader = command.ExecuteReader())
					{
						while (reader.Read())//Reader nesnesi okuma işlemi yaptığı sürece dönecek
						{
							Calisan _calisan = new Calisan //Calisan entitisinden nesne oluşturuyoruz.
							{
								Id = Convert.ToInt32(reader["Id"]),
								Adi = reader["Adi"].ToString(),
								SoyAdi = reader["SoyAdi"].ToString(),
								TCKimlikNo = reader["TCKimlikNo"].ToString(),
								PersonelNo = reader["PersonelNo"].ToString(),
								DogumTarihi = Convert.ToDateTime(reader["DogumTarihi"]),
								Departman = reader["Departman"].ToString(),
								Unvan = reader["Unvan"].ToString(),
								Durumu = reader["Durumu"].ToString() 
							};

							//Döngüden dönen içerisinde çalışan verilerini barındıran nesneyi listeye ekliyoruz.
							calisanlar.Add(_calisan);
						}
					}
					return calisanlar;
				}
			}

			catch (Exception ex)
			{	//Veritabanı işlemleri esnasında hata alınırsa ekrana gösterme işlemi ve geriye null değer döndürme
				MessageBox.Show(ex.Message, "Bir Hata Oluştu",
					MessageBoxButtons.OK, MessageBoxIcon.Error);
				return null;
			}
			//Try yada Catch blogu çalıştıktan sonra en son çalışacak blog finally'de baglantıyı kapatıyoruz.
			finally
			{
				SQLiteBaglanti.BaglantiKapat();
			}
		}

		//Verileri Döndürür
		public Calisan Getir(string kosulCumlesi)
		{
			Calisan _calisan = null;

			try
			{
				int _sonuc = 0;
				using (var command = new SQLiteCommand($"SELECT COUNT (*) FROM Calisanlar {kosulCumlesi}",SQLiteBaglanti.Connection))
				{
					SQLiteBaglanti.BaglantiAc();
					_sonuc = Convert.ToInt32(command.ExecuteScalar());
				}
				//Eğer görüntülenmek istenen calisan kosullarında birden fazla calısan varsa uyarı veriyoruz.
				if (_sonuc > 1) //Böyle bir koşul yapmasaydın birden fazla değer döndüğünde sadece en üstteki değeri ekrana yazdırırdı.
				{
					
					MessageBox.Show("Yapılan sorgu sonucunda birden fazla kayıt bulundu.\nLütfen daha fazla kriter ile arama yapınız.",
						"Yapılan Arama Yetersiz",MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
				else if(_sonuc==1) //Görüntülenmek istenen calisan 1 adetse geri döndürüyoruz.
				{
					using (var command = new SQLiteCommand($"SELECT * FROM Calisanlar {kosulCumlesi}",SQLiteBaglanti.Connection))
					{
						using(SQLiteDataReader reader = command.ExecuteReader())
						{
							while(reader.Read()) //Döngüye gerek yoktu 1 değer okucağını biliyoruz zaten
								//reader.Read(); dememiz yeterli olurdu.
							{
								 _calisan = new Calisan //Calisan entitisinden nesne oluşturuyoruz.
								{
									Id = Convert.ToInt32(reader["Id"]),
									Adi = reader["Adi"].ToString(),
									SoyAdi = reader["SoyAdi"].ToString(),
									TCKimlikNo = reader["TCKimlikNo"].ToString(),
									PersonelNo = reader["PersonelNo"].ToString(),
									DogumTarihi = Convert.ToDateTime(reader["DogumTarihi"]),
									Departman = reader["Departman"].ToString(),
									Unvan = reader["Unvan"].ToString(),
									Durumu = reader["Durumu"].ToString()
								};
							}
						}
					}
				}
				else
				{
					MessageBox.Show("Yapılan sorgu sonucunda kayıt bulunamadı.",
						"Kayıt Bulunamadı", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
				return _calisan;
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message, "Bir Hata Oluştu",
					MessageBoxButtons.OK, MessageBoxIcon.Error);
				return null;
			}

			finally {
				SQLiteBaglanti.BaglantiKapat();
			}
		}

		//Girilen verileri veritabanına kaydedir
		public bool Kaydet(Calisan calisan)
		{
			string sorguCumlesi = "INSERT INTO Calisanlar (Adi, SoyAdi, TCKimlikNo, PersonelNo, " +
				"DogumTarihi, Departman, Unvan, Durumu) VALUES (@p1, @p2, @p3, @p4, @p5, @p6, @p7, @p8)";
			try
			{
				using (var command = new SQLiteCommand(sorguCumlesi, SQLiteBaglanti.Connection))
				{
					command.Parameters.AddWithValue("@p1", calisan.Adi);
					command.Parameters.AddWithValue("@p2", calisan.SoyAdi);
					command.Parameters.AddWithValue("@p3", calisan.TCKimlikNo);
					command.Parameters.AddWithValue("@p4", calisan.PersonelNo);
					command.Parameters.AddWithValue("@p5", calisan.DogumTarihi.ToString("yyy.MM.dd"));//Sqlite'da text olarak kayıtlı olduğu için date olarak girilen veriyi stringe çeviriyoruz
					command.Parameters.AddWithValue("@p6", calisan.Departman);
					command.Parameters.AddWithValue("@p7", calisan.Unvan);
					command.Parameters.AddWithValue("@p8", calisan.Durumu);
					SQLiteBaglanti.BaglantiAc();
					command.ExecuteNonQuery();
				}

				return true;
				

			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message, "Bir Hata Oluştu",
					MessageBoxButtons.OK, MessageBoxIcon.Error);
				return false;
			}
			finally
			{
				SQLiteBaglanti.BaglantiKapat();
			}
		}

		//Seçilen personel bilgilerini günceller
		public bool Guncelle(Calisan calisan)
		{
			string sorguCumlesi = "UPDATE Calisanlar SET Adi = @p1, SoyAdi = @p2, TCKimlikNo = @p3, " +
				"PersonelNo = @p4, DogumTarihi = @p5, Departman = @p6, Unvan = @p7 , Durumu = @p8 WHERE Id = @p9";
			try
			{
				using (var command = new SQLiteCommand(sorguCumlesi, SQLiteBaglanti.Connection))
				{
					command.Parameters.AddWithValue("@p1", calisan.Adi);
					command.Parameters.AddWithValue("@p2", calisan.SoyAdi);
					command.Parameters.AddWithValue("@p3", calisan.TCKimlikNo);
					command.Parameters.AddWithValue("@p4", calisan.PersonelNo);
					command.Parameters.AddWithValue("@p5", calisan.DogumTarihi.ToString("yyy.MM.dd"));//Sqlite'da text olarak kayıtlı olduğu için date olarak girilen veriyi stringe çeviriyoruz
					command.Parameters.AddWithValue("@p6", calisan.Departman);
					command.Parameters.AddWithValue("@p7", calisan.Unvan);
					command.Parameters.AddWithValue("@p8", calisan.Durumu);
					command.Parameters.AddWithValue("@p9", calisan.Id);
					SQLiteBaglanti.BaglantiAc();
					command.ExecuteNonQuery();
				}

				return true;

			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message, "Bir Hata Oluştu",
					MessageBoxButtons.OK, MessageBoxIcon.Error);
				return false;
			}
			finally
			{
				SQLiteBaglanti.BaglantiKapat();
			}
		}


		//Tüm personel bilgilerini siler
		/// <summary>
		/// Tüm personel bilgilerini siler
		/// </summary>
		/// <returns>Silme işlemi başarılıysa 'true' başarısızsa 'false' değer döndürür</returns>
		public bool Sil()
		{	
			try
			{
				using (var command = new SQLiteCommand($"DELETE FROM Calisanlar",SQLiteBaglanti.Connection))
				{
					SQLiteBaglanti.BaglantiAc();
					command.ExecuteNonQuery ();
				}
				return true;

			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message, "Bir Hata Oluştu",
					MessageBoxButtons.OK, MessageBoxIcon.Error);
				return false;
			}
			finally
			{
				SQLiteBaglanti.BaglantiKapat();
			}
		}

		//Seçilen personel bilgisini id'sine göre siler
		/// <summary>
		/// Girilen personel bilgisini id'sine göre siler
		/// </summary>
		/// <param name="id">personel id'si</param>
		/// <returns>Silme işlemi başarılıysa ture başarısızsa false değerini döndürür</returns>
		public bool Sil(int id)
		{
			try
			{
				using (var command = new SQLiteCommand($"DELETE FROM Calisanlar WHERE Id = @p1", SQLiteBaglanti.Connection))
				{	
					command.Parameters.AddWithValue ("@p1", id);
					SQLiteBaglanti.BaglantiAc();
					command.ExecuteNonQuery();
				}
				return true;

			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message, "Bir Hata Oluştu",
					MessageBoxButtons.OK, MessageBoxIcon.Error);
				return false;
			}
			finally
			{
				SQLiteBaglanti.BaglantiKapat();
			}
			
		}
	}
}
