using System;

namespace p9
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			int[] ages = new int[]{18,11,30,15,55,32,10};
			foreach (var item in ages) {
				var msg = item.ToString();
				if(item >= 20){
					msg += " 成人";
				}
				Console.WriteLine(msg);
			}
		}
	}
}
