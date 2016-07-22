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
			string[] Params = new string[] 
			{
				"Выбирите какую функцию вы хотите запустить:",
				"-h - команда помощи", 
				"-f2f - функция, которая переводит в фаренгейты", 
				"-fun_loops - функция, которая показывает как работают цыклы",
				"-vstr - выводит текст вертикально, текст можно ввести вторым аргументом"
			};
			LCS50_1 CS50_1 = new LCS50_1();

			if (args.Length <= 0) 
			{
				Console.WriteLine ("Вы не указали аргумент!");
			} else 
			switch(args[0])
			{
				case "-f2f":
				CS50_1.F2C(CS50_1.getF2C());
				break;
			    case "-h":
					for (int i=0; i < Params.Length; i++) 
					{
						Console.WriteLine ("{0}", Params[i].ToString());
					} 
					break;
				case "-vstr":
					if (args [1].Length <= 0) {
						Console.WriteLine ("Вы не указали второй аргумент!");
					} else {
						// так как метод Cript() в класcе LCS50_2 статический, 
						// то создавать объект класса нет надобности!
						LCS50_2.vstr (args [1]);
					}
					break;
				case "-s":
					for (int i=0; i < 5000; i++) 
					{
					Console.WriteLine(args[i].ToString());
					}
				break;
			/*	case 51:
					CS50_1.fun_switch(CS50.get_fun_switch());
				break;
				case 52:
					CS50_1.F2C(CS50.getF2C());
				break;
				case 13:
					CS50_1.F2C(CS50.getF2C());
				break;
			*/	

				default:
					{
						Console.WriteLine("НЕТ такого параметра: {0}", args[0]);
					}
					break;
			}
		}	
	}
}