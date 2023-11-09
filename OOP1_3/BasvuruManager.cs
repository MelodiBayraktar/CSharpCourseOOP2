using System;
using System.Collections.Generic;

namespace OOP1_3
{
	public class BasvuruManager
	{
		public void BasvuruYap(IKrediManager krediManager)
		{
			//Başvuran bilgilerini değerlendirme
			krediManager.Hesapla();
		}

		public void KrediOnBilgilendirmesiYap(List<IKrediManager> krediler)
		{
			foreach (var kredi in krediler)
			{
				kredi.Hesapla();
			}
		}
	}
}

