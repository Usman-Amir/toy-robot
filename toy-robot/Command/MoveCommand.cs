using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToyRobot
{
	class MoveCommand : AbstractCommand
	{
		public MoveCommand(Robot robot) : base(robot)
		{
		}
		public override bool execute(Position position)
		{
			return base.execute(position);
		}
		public Position getNextPosition(Position position)
		{
			Position newPosition = position;
			
			switch (newPosition.direction)
			{
				case "NORTH":
					newPosition.y++;
					break;
				case "SOUTH":
					newPosition.y--;
					break;
				case "EAST":
					newPosition.x++;
					break;
				case "WEST":
					newPosition.x--;
					break;
				default:
					return position;
			}
			return position;

		}
	}
}
