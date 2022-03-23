﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
	class HorizontalLine : Figure //класс для создания горизонтальных линий
	{
		public HorizontalLine(int xLeft, int xRight, int y, char sym) //конструктор для создания линий поля игры 
		{
			pList = new List<Point>(); //список с точками
			for (int x = xLeft; x <= xRight; x++) //цикл создания горизонтальных точек 
			{
				Point p = new Point(x, y, sym); //создание точек с нужными координатами 
				pList.Add(p); //добавление точек в список 
			}
		}
	}
}
