using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
	class Snake : Figure //змейка - наследник класса фигура
	{
		Direction direction; //хранение данных  направления

		public Snake(Point tail, int length, Direction _direction) //конструктор, который задает точку появления змейки на поле и ее направление
		{
			direction = _direction; //переменная направлений 
			pList = new List<Point>(); //список точек
			for (int i = 0; i < length; i++) //с помощью цикла создаем копию точки хвоста змейки
			{
				Point p = new Point(tail); //добавление точки в определенное место 
				p.Move(i, direction); //движение точки 
				pList.Add(p); //добавление точки в список "PList"
			}
		}

		public void Move() //движение змейки 
		{
			Point tail = pList.First(); //забирает первый элемент из списка 
			pList.Remove(tail); //удаляет последнюю точку из списка (которая является хвостом у змейки) чтобы она "передвигалась" по полю, а не увеличивалась
			Point head = GetNextPoint(); //добавляет точку в начало змейки (голову) чтобы она "передвигалась" по полю.
			pList.Add(head); //добавляет точку в список

			tail.Clear(); //стирает последнюю точку (хвост)
			head.Draw(); //добавляет точку в начало (голову)
		}

		public Point GetNextPoint() //функция, которая вычисляет где окажется точка змейки
		{
			Point head = pList.Last(); //изначальная позиция
			Point nextPoint = new Point(head); //копирование предыдущей точки
			nextPoint.Move(1, direction); //движение точки по заданному направлению
			return nextPoint;
		}

		public bool IsHitTail() //функция, в случае если змейка столкнулась со своим телом (хвостом)
		{
			var head = pList.Last(); 
			for (int i = 0; i < pList.Count - 2; i++) 
			{
				if (head.IsHit(pList[i])) //если она врезалась в голову 
					return true;
			}
			return false; //если змейка не врезалась
		}

		public void HandleKey(ConsoleKey key) 
		{
			if (key == ConsoleKey.LeftArrow)
				direction = Direction.LEFT;
			else if (key == ConsoleKey.RightArrow)
				direction = Direction.RIGHT;
			else if (key == ConsoleKey.DownArrow)
				direction = Direction.DOWN;
			else if (key == ConsoleKey.UpArrow)
				direction = Direction.UP;
		}

		public bool Eat(Point food) //функция, в случае если змейка касается "еды"
		{
			Point head = GetNextPoint();
			if (head.IsHit(food)) //если она 
			{
				food.sym = head.sym;
				pList.Add(food);
				return true;
			}
			else
				return false;
		}
	}
}