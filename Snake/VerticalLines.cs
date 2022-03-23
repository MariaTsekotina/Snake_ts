using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
	class VerticalLine : Figure //класс для создания вертикальных линий. работает также, как и горизонтальные линии
	{
		public VerticalLine(int yUp, int yDown, int x, char sym) //конструктор для создания линий поля игры
		{
			pList = new List<Point>(); //список с точками
			for (int y = yUp; y <= yDown; y++) //цикл создания вертикальных точек
			{
				Point p = new Point(x, y, sym); //создание точек с нужными координатами 
				pList.Add(p); //добавление точек в список
			}
		}
	}
}
