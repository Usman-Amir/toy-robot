using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToyRobot
{
	public class AbstractCommand
	{
		public Robot robot;
		public AbstractCommand(Robot robot)
		{
			this.robot = robot;
		}
		public bool execute(Position position)
		{
			Table table = new Table(position.x, position.y);
			return table.IsPositionValid(position);
		}
	}
}
