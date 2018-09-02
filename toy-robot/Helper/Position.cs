using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToyRobot
{
	public class Position
	{
		
		public int x, y;
		public string direction;
		public Position(int x, int y, string direction)
		{
			this.x = x;
			this.y = y;
			this.direction = direction;
		}
	}
	public class Direction
	{
		public enum directionEnum {
			NORTH,
			EAST,
			SOUTH,
			WEST
		};
	}

}
