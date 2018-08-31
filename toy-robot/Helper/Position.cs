using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace toy_robot
{
	class Position
	{
		
		public int x, y;
		public string direction;
		Position(int x, int y, string direction)
		{
			this.x = x;
			this.y = y;
			this.direction = direction;
		}
	}
	class Direction
	{
		public enum directionEnum {
			NORTH,
			EAST,
			SOUTH,
			WEST
		};
	}

}
