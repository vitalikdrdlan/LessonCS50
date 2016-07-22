using System;

namespace LessonCS50_2
{
	public class LCS50_2
	{
		// <summary>
		// Конструктор класса LessonCS50_1
		// </summary>
		public LCS50_2 ()
		{
		}
		// <summary>
		// Статический Метод выводящий строку вертикально
		// </summary>
		public static void vstr(string str)
		{
			if(str != null)
			for(int i=0;i<str.Length;i++)
			Console.WriteLine ("{0}",str[i]);
		}
		// <summary>
		// Метод кодирования информации алгоритмом RSA, в данном случае строки
		// </summary>
		public static void RSA(string str)
		{
			if(str != null)
				for(int i=0;i<str.Length;i++)
					Console.WriteLine ("{0}",str[i]);
		}
	}
}