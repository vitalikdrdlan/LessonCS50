using System;

namespace LessonCS50_2
{
	public class LCS50_2
	{
		/// <summary>
		/// Конструктор класса LessonCS50_1
		/// </summary>
		public LCS50_2 ()
		{
		}
		public void Cript(string str)
		{
			if(str != null)
			for(int i=0;i<str.Length;i++)
			Console.WriteLine ("{0}",str[i]);
		}
	}
}