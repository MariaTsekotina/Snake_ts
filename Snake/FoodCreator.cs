using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
	class FoodCreator //класс для создания "еды" для змейки. появляется в рандомных местах 
	{
		int mapWidht; 
		int mapHeight;
		char sym;

		Random random = new Random(); 

		public FoodCreator(int mapWidth, int mapHeight, char sym) //конструктор для места на поле, где будет появляться еда 
		{
			this.mapWidht = mapWidth; //ширина поля
			this.mapHeight = mapHeight; //высота поля
			this.sym = sym; //символ еды 
		}

		public Point CreateFood() //метод создания еды
		{
			int x = random.Next(2, mapWidht - 2); // генерирует кординаты x
			int y = random.Next(2, mapHeight - 2); // генерирует кординаты y 
			return new Point(x, y, sym); //новая точка появления еды с этими кординатами 
		}
	}
}

