/*
 * Создано в SharpDevelop.
 * Пользователь: admin
 * Дата: 11.07.2016
 * Время: 21:38
 * 
 * Для изменения этого шаблона используйте меню "Инструменты | Параметры | Кодирование | Стандартные заголовки".
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
			//CS50.fun_input_output();
			//CS50.fun_loops();
			CS50.fun_switch(CS50.get_fun_switch());
			CS50.F2C(CS50.getF2C());
			Console.ReadKey(true);
		}	
	}
}