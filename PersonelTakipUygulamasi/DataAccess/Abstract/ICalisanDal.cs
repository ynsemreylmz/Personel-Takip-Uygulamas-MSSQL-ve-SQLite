using PersonelTakipUygulamasi.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonelTakipUygulamasi.DataAccess.Abstract
	//Interface
{	//Sql sorgularının yapılacağı class'da bulunmasını zorunlu tuttuğumuz fonksiyonlar
	public interface ICalisanDal

	{
		//Listleme işleri
		List<Calisan> Listele();

		//Listleme işleri overload
		List<Calisan> Listele(string kosulCumlesi);

		//Calısan getirme işlemi
		Calisan Getir(string kosulCumlesi);

		//Yeni üye ekleme işlemi
		bool Kaydet(Calisan calisan);

		//Güncelleme işlemi
		bool Guncelle(Calisan calisan);

		//Silme işlemi
		bool Sil();

		//overload yapıyoruz, int değer gönderilirse bu metot çalışacak
		bool Sil(int id);

	}
}
