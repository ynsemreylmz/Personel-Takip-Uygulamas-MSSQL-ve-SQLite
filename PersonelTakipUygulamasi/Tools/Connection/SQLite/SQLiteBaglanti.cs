using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace PersonelTakipUygulamasi.Tools.Connection.SQLite

{   //İçerisinde ki metotların static yapıda olma nedeni nesne üretmeden ulaşabilmemiz. 
	//Tools katmanında bu şekilde bir tanımlama daha kullanışlı.
	public class SQLiteBaglanti
	{
		private static SQLiteConnection _connection;

		// Singleton tasarım desenine göre:
		// Sadece 1 tane connection nesnesi oluşturduk
		//Bu desen sayesinde oluşturulan connection nesnesi her ihtiyaç duyulduğunda tekrar tekrar oluşmayacak
		//Uygulama boyunca sadece 1 kere bu nesne oluşacak ve ihtiyaç duyulan noktaya gönderilecek (referansı)
		public static SQLiteConnection Connection
		{
			get
			{
				if(_connection == null)
					_connection = new SQLiteConnection(ConfigurationManager.ConnectionStrings["PersonelTakipSQLite"].ConnectionString);

				return _connection;
			}
			set
			{
				_connection = value;

			}
		}

		public static void BaglantiAc() //Baglantı açma metodu
		{
			//Bağlantı kapalıysa aç
			if (Connection.State == ConnectionState.Closed) //Bağlantı kapalı mı onunu kontrolü
				Connection.Open();//Kapatma işlemi

		}

		public static void BaglantiKapat() //Baglantı kapatma metodu
		{
			//Bağlantı açıksa kapat
			if (Connection.State == ConnectionState.Open) //Bağlantı açık mı onunu kontrolü
				Connection.Close();//Açma işemi
		}
	}
}
