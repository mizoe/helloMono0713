using System;

namespace p7
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			double[] areas = new double[]{100,75,150};
			double oneTsubo = 3.3d;
			string[] rooms = new string[]{"101", "102", "103"};

			for (int i = 0; i < rooms.Length; i++) {
				Console.WriteLine("{0}号室 {1,3}平方メートル({2,5}坪)", rooms[i], areas[i],
				                  (areas[i] / oneTsubo).ToString("F2"));
			}
		}
	}
}
