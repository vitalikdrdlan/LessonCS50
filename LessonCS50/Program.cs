/*
 * Создано в SharpDevelop.
 * Пользователь: Vitaly
 * Дата: 11.07.2016
 * Время: 21:38
 */
using System;
using LessonCS50;  

namespace LessonCS50
{
	class Program
	{
		public static void Main(string[] args)
		{
			LessonCS50_1 CS50 = new LessonCS50_1();
			/* Console.WriteLine("Выбирите какую функцию вы хотите запустить, нажмите от 1-4 и Ентер");
			int Key;
			switch(Console.ReadKey())
			{
				case ConsoleKey.NumPad1:
					CS50.fun_input_output();
				break;
				case 50:
					CS50.fun_loops();
				break;
				case 51:
					CS50.fun_switch(CS50.get_fun_switch());
				break;
				case 52:
					CS50.F2C(CS50.getF2C());
				break;
				case 13:
					CS50.F2C(CS50.getF2C());
				break;
				default:
					{
						Console.WriteLine("Это число {0} НЕ в пределах существующих операции",Key);
					}
					break;
			}
			*/
			CS50.F2C(CS50.getF2C());
			Console.ReadKey(true);
		}	
	}
}