using System;

namespace p6
{
	class MainClass
	{
		public static void Main (string[] args)
		{/*
			double[] distances = new double[] {715.0, 6.9, 33.8};
			double mile2km = 1.609344;
			double[] miles = new double[3];

			string[] places = new string[]{"青森→東京　", "飯田橋→渋谷", "飯田橋→横浜"};

			int i = 0;
			foreach (var item in distances) {
				miles[i] = item / mile2km;
				Console.WriteLine (places[i] + " " 
				                   + String.Format("{0:F1}", item.ToString("F1"))
				                   + "km(" + miles[i].ToString("F2") + "マイル)");
				i++;
			}
			*/

			string[] places = { "青森→東京　", "飯田橋→渋谷", "飯田橋→横浜" };
			double[] distances = { 715.0, 6.9, 33.8 };
			double oneMile = 1.609344;
			for (int i = 0; i < places.Length; i++)
			{
				Console.WriteLine
					("{0} {1,5}km({2,6}マイル)",
					 places[i],
					 distances[i].ToString("F1"),
					 (distances[i] / oneMile).ToString("F2")
					 );
			}
			Console.ReadLine();
		}
	}
}
