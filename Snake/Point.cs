using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
	class Point //класс необходим для создания точек на экране
	{
		public int x;
		public int y;
		public char sym;

		public Point()
		{
		}

		public Point(int x, int y, char sym) //функция для создания точки
		{
			this.x = x;
			this.y = y;
			this.sym = sym;
		}

		public Point(Point p) //конструктор чтобы задавать точку при помощи другой
		{
			x = p.x;
			y = p.y;
			sym = p.sym;
		}

		public void Move(int offset, Direction direction) //задаем перемещение точкам с помощью класса "направление" 
		{
			if (direction == Direction.RIGHT) //если направление направо
			{
				x = x + offset;
			}
			else if (direction == Direction.LEFT) //если направление налево
			{
				x = x - offset;
			}
			else if (direction == Direction.UP) //если направление вверх
			{
				y = y - offset;
			}
			else if (direction == Direction.DOWN) //если направление вниз
			{
				y = y + offset;
			}
		}

		public bool IsHit(Point p) //метод для проверки столкновения разных точек
		{
			return p.x == this.x && p.y == this.y;
		}

		public void Draw() //метод отрисовки точек
		{
			Console.SetCursorPosition(x, y);
			Console.Write(sym);
		}

		public void Clear() //метод для стирания точек
		{
			sym = ' ';
			Draw();
		}

		public override string ToString() 
		{
			return x + ", " + y + ", " + sym;
		}
	}
}

