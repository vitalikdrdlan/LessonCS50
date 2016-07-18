/*
 * Создано в SharpDevelop.
 * Пользователь: Vitaly
 * Дата: 11.07.2016
 * Время: 21:38
 */
using System;
using LessonCS50_1;
using LessonCS50_2;

namespace LessonCS50
{
	class Program
	{
		public static void Main(string[] args)
		{
			LCS50_1 CS50_1 = new LCS50_1();
			LCS50_2 CS50_2 = new LCS50_2();
			/* Console.WriteLine("Выбирите какую функцию вы хотите запустить, нажмите от 1-4 и Ентер");
			int Key;
			switch(Console.ReadKey())
			{
				case ConsoleKey.NumPad1:
					CS50_1.fun_input_output();
				break;
				case 50:
					CS50_1.fun_loops();
				break;
				case 51:
					CS50_1.fun_switch(CS50.get_fun_switch());
				break;
				case 52:
					CS50_1.F2C(CS50.getF2C());
				break;
				case 13:
					CS50_1.F2C(CS50.getF2C());
				break;
				default:
					{
						Console.WriteLine("Это число {0} НЕ в пределах существующих операции",Key);
					}
					break;
			}
			*/
			CS50_1.F2C(CS50_1.getF2C());
			CS50_2.Cript("GoodBY!");
			Console.ReadKey(true);
		}	
	}
}