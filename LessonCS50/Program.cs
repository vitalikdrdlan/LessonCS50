﻿/*
 * Создано в SharpDevelop.
 * Пользователь: admin
 * Дата: 11.07.2016
 * Время: 21:38
 * 
 * Для изменения этого шаблона используйте меню "Инструменты | Параметры | Кодирование | Стандартные заголовки".
 */
using System;

namespace LessonCS50
{
	class Program
	{
		public static void Main(string[] args)
		{
			FunCS50 Fun = new FunCS50();
			//Fun.fun_1();
			//Fun.fun_2();
			//Fun.fun_switch(Convert.ToInt32(Console.ReadLine()));
			Fun.F2C(Fun.getF2C());
			Console.ReadKey(true);
		}	
	}
	class FunCS50
	{
		/*
		 * калькулятор (сумма)
		 */
		public int fun_1()
		{
			Console.WriteLine("Введи число X:");
			int x = Convert.ToInt32(Console.ReadLine());
			
			Console.WriteLine("Введи число Y:");
			int y = 5; 
			y = Convert.ToInt32(Console.ReadLine());
			
			Console.Write("Summa: {0} + {1} = {2}", x, y, x+y);
			if (x+y>0)
			{
				Console.WriteLine("\nЗначение положительное!");
			}
			else
			{
				Console.WriteLine("\nЗначение отрицательное!");
			}
			return 1;
		}
			/*
			 * цыкл
			 */
		public int fun_2()
		{
			int x1=0;
			while(x1<3)
			{
				Console.WriteLine("Выполнено итераций : {0}",x1);
				x1++;
			}
			for(int x2=0; x2<3; x2++)
			{
				Console.WriteLine("Выполнено итераций : {0}",x2);
			}
			x1=0;
			do
			{
				Console.WriteLine("Выполнено итераций : {0}",x1);
				x1++;
			}
			while (x1<3);
			return 1;
		}
		/*
		 * switch
		 */
		public int fun_switch(int x1)
		{
			switch (x1) 
			{
				case 1:
				case 2:
				case 3:
				case 4:
					Console.WriteLine("Это число от 1 до 4");
					break;
				case 5:
				case 6:
				case 7:
				case 8:
					Console.WriteLine("Это число от 5 до 8");
					break;
				default:
					{
						Console.WriteLine("Это число НЕ в пределах от 1 до 8");
						//return x1;
					}
					break;
			}
			return x1;
		}
		/*
		 * Перевод с фаренгейтов на цельсии
		 */ 
		public float F2C(float x1)
		{
			float x2 = 5.0f / 9.0f * (x1 - 32.0f);
			Console.WriteLine("Значение {0} фаренгейтов будет {1:f2} по цельсию!",x1,x2);
			return x2;
		}
		public float getF2C()
		{
			Console.WriteLine("Введите значение фаренгейтов: ");
			return Convert.ToSingle(Console.ReadLine());
		}
	}
}