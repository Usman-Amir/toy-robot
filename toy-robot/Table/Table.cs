using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace toy_robot
{
	class Table
	{
		public int BoxX, Boxy;
		public Table(int x, int y)
		{
			//handle expectpion
			this.BoxX = x;
			this.Boxy = y;
		}

		 public bool IsPositionValid(Position position)
		{
			return !(position.x < 0 || position.y >= this.Boxy || position.y < 0 || position.y >= this.Boxy);
		}
	}
}
