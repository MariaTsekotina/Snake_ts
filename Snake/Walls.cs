using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
	class Walls 
	{
		List<Figure> wallList; 

		public Walls(int mapWidth, int mapHeight)
		{
			wallList = new List<Figure>();

			//создание рамочки с указанными размерами
			HorizontalLine upLine = new HorizontalLine(0, mapWidth - 2, 0, '+');
			HorizontalLine downLine = new HorizontalLine(0, mapWidth - 2, mapHeight - 1, '+');
			VerticalLine leftLine = new VerticalLine(0, mapHeight - 1, 0, '+');
			VerticalLine rightLine = new VerticalLine(0, mapHeight - 1, mapWidth - 2, '+');
			//добавление линий в список
			wallList.Add(upLine);
			wallList.Add(downLine);
			wallList.Add(leftLine);
			wallList.Add(rightLine);
		}

		internal bool IsHit(Figure figure) //проверка столкновения змейки со стеной 
		{
			foreach (var wall in wallList)
			{
				if (wall.IsHit(figure))
				{
					return true;
				}
			}
			return false; //если столкновения нет - игра продолжается 
		}

		public void Draw() //отрисовка поля
		{
			foreach (var wall in wallList)
			{
				wall.Draw();
			}
		}
	}
}

